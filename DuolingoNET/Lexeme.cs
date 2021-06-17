using Newtonsoft.Json;
using System.Collections.Generic;

namespace DuolingoNET
{
    public class Lexeme
    {
        public class Discussion
        {
            [JsonProperty("url")]
            public string Url { get; set; }

            [JsonProperty("num_comments")]
            public string NumComments { get; set; }
        }

        public class AlternativeForm
        {
            [JsonProperty("case")]
            public object Case { get; set; }

            [JsonProperty("gender")]
            public object Gender { get; set; }

            [JsonProperty("word")]
            public string Word { get; set; }

            [JsonProperty("tts")]
            public string Tts { get; set; }

            [JsonProperty("text")]
            public string Text { get; set; }

            [JsonProperty("discussion")]
            public Discussion Discussion { get; set; }

            [JsonProperty("number")]
            public object Number { get; set; }

            [JsonProperty("invalid")]
            public bool Invalid { get; set; }

            [JsonProperty("highlighted")]
            public bool Highlighted { get; set; }

            [JsonProperty("translation_text")]
            public string TranslationText { get; set; }

            [JsonProperty("link")]
            public string Link { get; set; }

            [JsonProperty("example_sentence")]
            public string ExampleSentence { get; set; }

            [JsonProperty("word_value_matched")]
            public bool WordValueMatched { get; set; }

            [JsonProperty("translation")]
            public string Translation { get; set; }
        }

        public class LanguageInformation
        {
        }

        public class RelatedDiscussion
        {
            [JsonProperty("url")]
            public string Url { get; set; }

            [JsonProperty("num_comments")]
            public string NumComments { get; set; }

            [JsonProperty("anchor")]
            public string Anchor { get; set; }
        }

        public class Root
        {
            [JsonProperty("alternative_forms")]
            public List<AlternativeForm> AlternativeForms { get; set; }

            [JsonProperty("has_tts")]
            public bool HasTts { get; set; }

            [JsonProperty("word")]
            public string Word { get; set; }

            [JsonProperty("language_information")]
            public LanguageInformation LanguageInformation { get; set; }

            [JsonProperty("from_language_name")]
            public string FromLanguageName { get; set; }

            [JsonProperty("tts")]
            public string Tts { get; set; }

            [JsonProperty("infinitive")]
            public object Infinitive { get; set; }

            [JsonProperty("learning_language")]
            public string LearningLanguage { get; set; }

            [JsonProperty("translations")]
            public string Translations { get; set; }

            [JsonProperty("learning_language_name")]
            public string LearningLanguageName { get; set; }

            [JsonProperty("pos")]
            public object Pos { get; set; }

            [JsonProperty("lexeme_image")]
            public object LexemeImage { get; set; }

            [JsonProperty("from_language")]
            public string FromLanguage { get; set; }

            [JsonProperty("is_generic")]
            public bool IsGeneric { get; set; }

            [JsonProperty("lexeme_id")]
            public string LexemeId { get; set; }

            [JsonProperty("related_lexemes")]
            public List<object> RelatedLexemes { get; set; }

            [JsonProperty("related_discussions")]
            public List<RelatedDiscussion> RelatedDiscussions { get; set; }

            [JsonProperty("canonical_path")]
            public string CanonicalPath { get; set; }
        }


    }
}
