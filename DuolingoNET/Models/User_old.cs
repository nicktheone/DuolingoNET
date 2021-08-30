using Newtonsoft.Json;
using System.Collections.Generic;

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
    public class User_old
    {

        #region Properties

        /// <summary>
        /// A string representing the username on the website.
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// A string representing the active language being studied.
        /// </summary>
        [JsonProperty("learning_language")]
        public string LearningLanguage { get; set; }

        /// <summary>
        /// A string the complete username.
        /// </summary>
        [JsonProperty("fullname")]
        public string FullName { get; set; }

        /// <summary>
        /// A string representing ID of the account.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// A <see cref="Language"> class containing the user language data and learned skills.
        /// </summary>
        public Language LanguageData { get; set; }

        #endregion

        public class Skill
        {
            [JsonProperty("url_title")]
            public string UrlTitle { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("learned")]
            public bool Learned { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("explanation")]
            public string Explanation { get; set; }

            [JsonProperty("words")]
            public List<string> Words { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("language")]
            public string Language { get; set; }

            [JsonProperty("mastered")]
            public bool Mastered { get; set; }
        }

        public class Language
        {
            [JsonProperty("language_string")]
            public string LanguageString { get; set; }

            [JsonProperty("level")]
            public int Level { get; set; }

            [JsonProperty("skills")]
            public List<Skill> Skills { get; set; }
        }
    }
}
