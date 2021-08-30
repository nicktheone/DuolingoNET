using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DuolingoNET
{

    /// <summary>
    /// The main class.
    /// Contains all methods for performing basic functions.
    /// </summary>
    /// <list type="bullet">
    /// <item>
    /// <term></term>
    /// <description></description>
    /// </list>
    /// </summary>
    /// <remarks>
    /// <para></para>
    /// </remarks>
    public class Duolingo
    {
        #region Fields

        /// <summary>
        /// The default <see cref="Uri"/> used by Duolingo.
        /// </summary>
        private readonly Uri baseUri = new Uri("https://www.duolingo.com/");

        /// <summary>
        /// A string representing the username or email of the account used for login.
        /// </summary>
        private readonly string loginUsername;

        /// <summary>
        /// A string representing the password of the account used for login.
        /// </summary>
        private readonly string loginPassword;

        /// <summary>
        /// The <see cref="HttpClient"/> used throughout the library.
        /// </summary>
        private readonly HttpClient client;

        #endregion

        #region Properties

        /// <summary>
        /// The <see cref="DuolingoNET.LoginData"/> containing the login data of the user.
        /// </summary>
        private LoginData LoginData { get; set; }

        /// <summary>
        /// The <see cref="DuolingoNET.User"/> containing the data of the user.
        /// </summary>
        public User.Root UserData { get; set; } = new User.Root();

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="Duolingo"/> with the specified <paramref name="username"/> 
        /// and <paramref name="password"/>.
        /// </summary>
        /// <param name="username">A string representing the username or email of the account.</param>
        /// <param name="password">A string representing the password of the account.</param>
        public Duolingo(string username, string password, HttpClient client)
        {
            if (username == null)
            {
                throw new ArgumentNullException(nameof(username));
            }

            if (username == null)
            {
                throw new ArgumentNullException(nameof(password));
            }

            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            this.loginUsername = username;
            this.loginPassword = password;
            this.client = client;

            client.BaseAddress = baseUri;

            Initialize();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets the TTS uri for any given lexeme</c>.
        /// </summary>
        public async Task<Uri> GetTtsUrlAsync(string lexemeId)
        {
            var lexeme = await GetLexemeDataAsync(lexemeId).ConfigureAwait(false);

            return new Uri(lexeme.Tts);
        }

        /// <summary>
        /// Gets a list of known words from every learned skill.
        /// </summary>
        /// <returns></returns>
        public List<string> GetKnownWords()
        {
            var words = new List<string>();

            foreach (var skill in GetLearnedSkills())
            {
                foreach (var word in skill.Words)
                {
                    words.Add(word);
                }
            }

            return words;
        }

        /// <summary>
        /// Gets a list of learned skills.
        /// </summary>
        /// <returns></returns>
        public List<User.Skill> GetLearnedSkills()
        {
            var skills = new List<User.Skill>();

            foreach (var skill in UserData.LanguageData.Skills)
            {
                if (skill.Learned)
                {
                    skills.Add(skill);
                }
            }

            return skills;
        }

        /// <summary>
        /// Gets the lexeme data through <c>https://www.duolingo.com/api/1/dictionary_page</c>.
        /// </summary>
        public async Task<Lexeme.Root> GetLexemeDataAsync(string lexemeId)
        {
            // Creates the lexeme that will be returned back
            var lexeme = new Lexeme.Root();

            // Gets the lexeme data
            var getLexemeResult = await client.GetAsync(string.Format("/api/1/dictionary_page?lexeme_id={0}&from_language_id={1}", lexemeId, "en")).ConfigureAwait(false);
            getLexemeResult.EnsureSuccessStatusCode();
            var json = await getLexemeResult.Content.ReadAsStringAsync().ConfigureAwait(false);

            // Parses the lexeme
            lexeme = JsonConvert.DeserializeObject<Lexeme.Root>(json);

            return lexeme;
        }

        /// <summary>
        /// Gets the user vocabulary data through <c>https://www.duolingo.com/vocabulary/overview</c>.
        /// </summary>
        public async Task<Vocabulary.Root> GetVocabularyAsync()
        {
            var vocabulary = new Vocabulary.Root();

            // Gets the user vocabulary
            var getVocabularyResult = await client.GetAsync("/vocabulary/overview").ConfigureAwait(false);
            getVocabularyResult.EnsureSuccessStatusCode();
            var json = await getVocabularyResult.Content.ReadAsStringAsync().ConfigureAwait(false);

            // Parses the user vocabulary
            vocabulary = JsonConvert.DeserializeObject<Vocabulary.Root>(json);

            return vocabulary;
        }

        /// <summary>
        /// Gets the user data through <c>https://www.duolingo.com/users/username</c>.
        /// </summary>
        private async Task GetUserDataAsync()
        {
            // Gets the user data using the username extracted from the login data
            var getUserDataResult = await client.GetAsync(string.Format("/users/{0}", LoginData.Username)).ConfigureAwait(false);
            getUserDataResult.EnsureSuccessStatusCode();
            var json = await getUserDataResult.Content.ReadAsStringAsync().ConfigureAwait(false);

            // Parses the language data
            UserData = JsonConvert.DeserializeObject<User.Root>(json);
            JObject o = JObject.Parse(json);
            var results = o["language_data"][UserData.LearningLanguage];
            UserData.LanguageData = results.ToObject<User.LanguageStudied>();
        }

        /// <summary>
        /// Authenticates through <c>https://www.duolingo.com/login</c>.
        /// </summary>
        private async Task LoginAsync() 
        {
            // Initial request to Duolingo homepage in order to get some basic cookies
            // It may help with login
            var homePageResult = await client.GetAsync("/").ConfigureAwait(false);
            homePageResult.EnsureSuccessStatusCode();

            // Formats the JSON string used for authentication
            var jsonString = string.Format(@"{{""login"":""{0}"",""password"":""{1}""}}", loginUsername, loginPassword);
            HttpContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");

            // Logs in and ensures success
            var loginResult = await client.PostAsync("/login", content).ConfigureAwait(false);
            loginResult.EnsureSuccessStatusCode();

            // Reads the username on the website
            LoginData = JsonConvert.DeserializeObject<LoginData>(await loginResult.Content.ReadAsStringAsync().ConfigureAwait(false));
        }

        /// <summary>
        /// Logs in the user and downloads the necessary data</c>.
        /// </summary>
        private void Initialize()
        {
            // Logs in
            LoginAsync().GetAwaiter().GetResult();

            // Gets the user data
            GetUserDataAsync().GetAwaiter().GetResult();
        }

        #endregion

    }
}
