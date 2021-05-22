using System;

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
        #region Properties

        /// <summary>
        /// A string representing the username or email of the account.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// A string representing the password of the account.
        /// </summary>
        public string Password { get; set; }

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

    }
}
