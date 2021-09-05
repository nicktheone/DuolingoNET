using Newtonsoft.Json;

namespace DuolingoNET.Models
{
    /// <summary>
    /// The login class.
    /// Contains the login data returned from the website for the logged in user.
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
    public class LoginData
    {
        /// <summary>
        /// A string representing the username of the account.
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// A string representing the Id of the account.
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
