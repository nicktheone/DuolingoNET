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

        #region Constants

        /// <summary>
        /// The default <see cref="Uri"/> used by Duolingo.
        /// </summary>
        private readonly Uri BaseUri = new Uri("https://www.duolingo.com/");

        #endregion

        #region Fields

        /// <summary>
        /// A string representing the username or email of the account used for login.
        /// </summary>
        private readonly string loginUsername;

        /// <summary>
        /// A string representing the password of the account used for login.
        /// </summary>
        private readonly string loginPassword;

        #endregion

        #region Properties

        /// <summary>
        /// The <see cref="HttpClient"/> used throughout the library.
        /// </summary>
        private HttpClient Client { get; set; }

        /// <summary>
        /// The <see cref="DuolingoNET.LoginData"/> containing the login data of the user.
        /// </summary>
        private LoginData LoginData { get; set; }

        /// <summary>
        /// The <see cref="DuolingoNET.User"/> containing the data of the user.
        /// </summary>
        public User UserData { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="Duolingo"/> reading from a LoginData.json file.
        /// </summary>
        //public Duolingo()
        //{
        //    ReadLoginData();

        //    Initialize();

        //    // Logs in
        //    LoginAsync().Wait();

        //    // Gets the user data
        //    GetUserDataAsync().Wait();
        //}

        /// <summary>
        /// Initializes a new instance of <see cref="Duolingo"/> with the specified <paramref name="username"/> 
        /// and <paramref name="password"/>.
        /// </summary>
        /// <param name="username">A string representing the username or email of the account.</param>
        /// <param name="password">A string representing the password of the account.</param>
        public Duolingo(string username, string password)
        {
            if (username == null)
            {
                throw new ArgumentNullException("username");
            }
            loginUsername = username;

            if (username == null)
            {
                throw new ArgumentNullException("password");
            }
            loginPassword = password;

            Initialize();

            // Logs in
            LoginAsync().Wait();

            // Gets the user data
            GetUserDataAsync().Wait();
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
            var getLexemeResult = await Client.GetAsync(string.Format("/api/1/dictionary_page?lexeme_id={0}&from_language_id={1}", lexemeId, "en")).ConfigureAwait(false);
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
            var getVocabularyResult = await Client.GetAsync("/vocabulary/overview").ConfigureAwait(false);
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
            var getUserDataResult = await Client.GetAsync(string.Format("/users/{0}", LoginData.Username)).ConfigureAwait(false);
            getUserDataResult.EnsureSuccessStatusCode();
            var json = await getUserDataResult.Content.ReadAsStringAsync().ConfigureAwait(false);

            // Parses the language data
            UserData = JsonConvert.DeserializeObject<User>(json);
            JObject o = JObject.Parse(json);
            var results = o["language_data"][UserData.LearningLanguage];
            UserData.LanguageData = results.ToObject<User.Language>();
        }

        /// <summary>
        /// Authenticates through <c>https://www.duolingo.com/login</c>.
        /// </summary>
        
        private void Initialize()
        {
            // The web client that will be used for contacting Duolingo's server
            var cookieContainer = new CookieContainer();
            var handler = new HttpClientHandler() { CookieContainer = cookieContainer };
            Client = new HttpClient(handler) { BaseAddress = BaseUri };

            // The blank user used to store the data
            UserData = new User();
        }

        #endregion

    }
}
