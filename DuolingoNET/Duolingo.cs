using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Text;

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
        /// The <see cref="HttpClient"/> used throughout the library
        /// </summary>
        public HttpClient Client { get; set; }

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
        }

        #endregion

        #region Methods

        /// <summary>
        /// Authenticates through <c>https://www.duolingo.com/login</c>.
        /// </summary>
        private async void Login()
        {
            var cookieContainer = new CookieContainer();
            var handler = new HttpClientHandler() { CookieContainer = cookieContainer };
            Client = new HttpClient(handler) { BaseAddress = BaseUri };

            // Initial request to Duolingo homepage in order to get some basic cookies
            // It may help with login
            var homePageResult = Client.GetAsync("/");
            homePageResult.Result.EnsureSuccessStatusCode();

            // Formats the JSON string used for authentication
            var jsonString = String.Format(@"{{""login"":""{0}"",""password"":""{1}""}}", Username, Password);
            HttpContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");

            // Logs in and ensures success
            var loginResult = await Client.PostAsync("/login", content);
            loginResult.EnsureSuccessStatusCode();
        }

        #endregion

    }
}
