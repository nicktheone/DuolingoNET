using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
        public string Username { get; set; }

        /// <summary>
        /// A string representing the password of the account.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// The <see cref="HttpClient"/> used throughout the library.
        /// </summary>
        public HttpClient Client { get; set; }

        /// <summary>
        /// The <see cref="DuolingoNET.User"/> containing the data of the user.
        /// </summary>
        public User User { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="Duolingo"/> with the specified <paramref name="username"/> 
        /// and <paramref name="password"/>.
        /// </summary>
        /// <param name="username">A string representing the username or email of the account.</param>
        /// <param name="password">A string representing the password of the account.</param>
        public Duolingo(string username, string password)
        {
            Username = username;
            Password = password;

            // Creates the web client that will be used for contacting Duolingo's server
            var cookieContainer = new CookieContainer();
            var handler = new HttpClientHandler() { CookieContainer = cookieContainer };
            Client = new HttpClient(handler) { BaseAddress = BaseUri };

            // Creates the blank user used to store the data
            User = new User();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets the user data through <c>https://www.duolingo.com/users/username</c>.
        /// </summary>
        public async void GetUserData()
        {
            // Logs in
            await Login();

            // Gets the user data using the username extracted from the login data
            var getUserDataResult = await Client.GetAsync(string.Format("/users/{0}", User.Username));
            getUserDataResult.EnsureSuccessStatusCode();
            var json = await getUserDataResult.Content.ReadAsStringAsync();

            // Parses the language data
            User = JsonConvert.DeserializeObject<User>(json);
            JObject o = JObject.Parse(json);
            var results = o["language_data"][User.LearningLanguage];
            User.LanguageData = results.ToObject<User.Language>();

            //Console.WriteLine(User.Username);
            //Console.WriteLine(User.LearningLanguage);
            //Console.WriteLine(User.FullName);
            //Console.WriteLine(User.Id);
            //foreach (var skill in User.LanguageData.Skills)
            //{
            //    if (skill.Learned)
            //    {
            //        Console.WriteLine(skill.Title);
            //    }
            //}

            //foreach (var property in User.GetType().GetProperties())
            //{
            //    Console.WriteLine(@"{0} + {1}", property.Name, property.GetValue(User, null));
            //}
        }

        /// <summary>
        /// Authenticates through <c>https://www.duolingo.com/login</c>.
        /// </summary>
        private async Task Login()
        {
            // Initial request to Duolingo homepage in order to get some basic cookies
            // It may help with login
            var homePageResult = Client.GetAsync("/");
            homePageResult.Result.EnsureSuccessStatusCode();

            // Formats the JSON string used for authentication
            var jsonString = string.Format(@"{{""login"":""{0}"",""password"":""{1}""}}", Username, Password);
            HttpContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");

            // Logs in and ensures success
            var loginResult = await Client.PostAsync("/login", content);
            loginResult.EnsureSuccessStatusCode();

            // Reads the username on the website
            User = JsonConvert.DeserializeObject<User>(await loginResult.Content.ReadAsStringAsync());
        }

        #endregion

    }
}
