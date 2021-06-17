using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
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
        private static readonly Uri BaseUri = new Uri("https://www.duolingo.com/");

        #endregion

        #region Properties

        /// <summary>
        /// A string representing the username or email of the account.
        /// </summary>
        public string LoginUsername { get; set; }

        /// <summary>
        /// A string representing the password of the account.
        /// </summary>
        public string LoginPassword { get; set; }

        /// <summary>
        /// The <see cref="HttpClient"/> used throughout the library.
        /// </summary>
        public HttpClient Client { get; set; }

        /// <summary>
        /// The <see cref="DuolingoNET.User"/> containing the data of the user.
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// The <see cref="DuolingoNET.Root"/> containing the known words of the user.
        /// </summary>
        public Vocabulary.Root Vocabulary { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="Duolingo"/> reading from a LoginData.json file.
        /// </summary>
        public Duolingo()
        {
            ReadLoginData();

            Initialize();

            // Logs in
            LoginAsync().Wait();
        }

        /// <summary>
        /// Initializes a new instance of <see cref="Duolingo"/> with the specified <paramref name="username"/> 
        /// and <paramref name="password"/>.
        /// </summary>
        /// <param name="username">A string representing the username or email of the account.</param>
        /// <param name="password">A string representing the password of the account.</param>
        public Duolingo(string username, string password)
        {
            LoginUsername = username;
            LoginPassword = password;

            Initialize();

            // Logs in
            LoginAsync().Wait();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets the lexeme data through <c>https://www.duolingo.com/api/1/dictionary_page</c>.
        /// </summary>
        public async Task<Lexeme.Root> GetLexemeDataAsync(string lexemeId)
        {
            // Creates the lexeme that will be returned back
            var lexeme = new Lexeme.Root();

            // Gets the lexeme data
            var getLexemeResult = await Client.GetAsync(string.Format("/api/1/dictionary_page?lexeme_id={0}&from_language_id={1}", lexemeId, "en"));
            getLexemeResult.EnsureSuccessStatusCode();
            var json = await getLexemeResult.Content.ReadAsStringAsync();

            // Parses the lexeme
            lexeme = JsonConvert.DeserializeObject<Lexeme.Root>(json);

            Console.WriteLine("#########\n#<DEBUG>#\n#########");
            Console.WriteLine(lexeme.Word);
            Console.WriteLine(lexeme.Translations);
            Console.WriteLine("##########\n#</DEBUG>#\n##########");

            return lexeme;
        }

        /// <summary>
        /// Gets the user vocabulary data through <c>https://www.duolingo.com/vocabulary/overview</c>.
        /// </summary>
        public async Task GetVocabularyAsync()
        {
            // Gets the user vocabulary
            var getVocabularyResult = await Client.GetAsync("/vocabulary/overview");
            getVocabularyResult.EnsureSuccessStatusCode();
            var json = await getVocabularyResult.Content.ReadAsStringAsync();

            // Parses the user vocabulary
            Vocabulary = JsonConvert.DeserializeObject<Vocabulary.Root>(json);

            Console.WriteLine("#########\n#<DEBUG>#\n#########");
            Console.WriteLine(Vocabulary.LanguageString);
            Console.WriteLine(Vocabulary.LearningLanguage);
            Console.WriteLine(Vocabulary.FromLanguage);
            foreach (var vocab in Vocabulary.VocabOverview)
            {
                Console.WriteLine(vocab.Id);
            }
            Console.WriteLine("##########\n#</DEBUG>#\n##########");

        }

        /// <summary>
        /// Gets the user data through <c>https://www.duolingo.com/users/username</c>.
        /// </summary>
        public async Task GetUserDataAsync()
        {
            // Gets the user data using the username extracted from the login data
            var getUserDataResult = await Client.GetAsync(string.Format("/users/{0}", User.Username));
            getUserDataResult.EnsureSuccessStatusCode();
            var json = await getUserDataResult.Content.ReadAsStringAsync();

            // Parses the language data
            User = JsonConvert.DeserializeObject<User>(json);
            JObject o = JObject.Parse(json);
            var results = o["language_data"][User.LearningLanguage];
            User.LanguageData = results.ToObject<User.Language>();

            Console.WriteLine("#########\n#<DEBUG>#\n#########");
            Console.WriteLine(User.Username);
            Console.WriteLine(User.LearningLanguage);
            Console.WriteLine(User.FullName);
            Console.WriteLine(User.Id);
            foreach (var skill in User.LanguageData.Skills)
            {
                if (skill.Learned)
                {
                    Console.WriteLine(skill.Title);
                }
            }
            //foreach (var property in User.GetType().GetProperties())
            //{
            //    Console.WriteLine(@"{0} + {1}", property.Name, property.GetValue(User, null));
            //}
            Console.WriteLine("##########\n#</DEBUG>#\n##########");
        }

        /// <summary>
        /// Authenticates through <c>https://www.duolingo.com/login</c>.
        /// </summary>
        private async Task LoginAsync()
        {
            // Initial request to Duolingo homepage in order to get some basic cookies
            // It may help with login
            var homePageResult = Client.GetAsync("/");
            homePageResult.Result.EnsureSuccessStatusCode();

            // Formats the JSON string used for authentication
            var jsonString = string.Format(@"{{""login"":""{0}"",""password"":""{1}""}}", LoginUsername, LoginPassword);
            HttpContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");

            // Logs in and ensures success
            var loginResult = await Client.PostAsync("/login", content);
            loginResult.EnsureSuccessStatusCode();

            // Reads the username on the website
            User = JsonConvert.DeserializeObject<User>(await loginResult.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Reads the login data from a JSON file.
        /// </summary>
        private void ReadLoginData()
        {
            using (StreamReader r = new StreamReader("LoginData.json"))
            {
                string json = r.ReadToEnd();
                dynamic loginData = JsonConvert.DeserializeObject<dynamic>(json);

                LoginUsername = loginData.login;
                LoginPassword = loginData.password;
            }
        }

        /// <summary>
        /// Initializes the <see cref="HttpClient"/> and blank <see cref="DuolingoNET.User"/>
        /// </summary>
        private void Initialize()
        {
            // The web client that will be used for contacting Duolingo's server
            var cookieContainer = new CookieContainer();
            var handler = new HttpClientHandler() { CookieContainer = cookieContainer };
            Client = new HttpClient(handler) { BaseAddress = BaseUri };

            // The blank user used to store the data
            User = new User();
        }

        #endregion

    }
}
