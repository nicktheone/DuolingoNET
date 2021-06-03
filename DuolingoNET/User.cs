using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuolingoNET
{
    /// <summary>
    /// The user class.
    /// Contains the data for the logged in user.
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
    public class User
    {

        #region Properties

        /// <summary>
        /// A string representing the username on the website.
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        #endregion

    }
}
