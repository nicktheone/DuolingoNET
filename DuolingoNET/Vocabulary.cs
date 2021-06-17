using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuolingoNET
{
    /// <summary>
    /// The vocabulary class.
    /// Contains the known words for the logged in user.
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
    public class Vocabulary
    {
        public class Tenses
        {
        }

        public class LanguageInformation
        {
            [JsonProperty("pronoun_mapping")]
            public List<object> PronounMapping { get; set; }

            [JsonProperty("tenses")]
            public Tenses Tenses { get; set; }
        }

        public class VocabOverview
        {
            [JsonProperty("strength_bars")]
            public int StrengthBars { get; set; }

            [JsonProperty("infinitive")]
            public object Infinitive { get; set; }

            [JsonProperty("normalized_string")]
            public string NormalizedString { get; set; }

            [JsonProperty("pos")]
            public string Pos { get; set; }

            [JsonProperty("last_practiced_ms")]
            public object LastPracticedMs { get; set; }

            [JsonProperty("skill")]
            public string Skill { get; set; }

            [JsonProperty("related_lexemes")]
            public List<string> RelatedLexemes { get; set; }

            [JsonProperty("last_practiced")]
            public DateTime LastPracticed { get; set; }

            [JsonProperty("strength")]
            public double Strength { get; set; }

            [JsonProperty("skill_url_title")]
            public string SkillUrlTitle { get; set; }

            [JsonProperty("gender")]
            public string Gender { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("lexeme_id")]
            public string LexemeId { get; set; }

            [JsonProperty("word_string")]
            public string WordString { get; set; }
        }

        public class Root
        {
            [JsonProperty("language_string")]
            public string LanguageString { get; set; }

            [JsonProperty("learning_language")]
            public string LearningLanguage { get; set; }

            [JsonProperty("from_language")]
            public string FromLanguage { get; set; }

            [JsonProperty("language_information")]
            public LanguageInformation LanguageInformation { get; set; }

            [JsonProperty("vocab_overview")]
            public List<VocabOverview> VocabOverview { get; set; }
        }
    }
}
