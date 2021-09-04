using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace DuolingoNET
{
    public class User
    {
        public class LevelTest
        {
            [JsonProperty("index")]
            public int Index { get; set; }

            [JsonProperty("attempts")]
            public int Attempts { get; set; }

            [JsonProperty("completed")]
            public bool Completed { get; set; }

            [JsonProperty("level")]
            public int Level { get; set; }
        }

        public class Notifications
        {
            [JsonProperty("chrome_app_ad")]
            public bool ChromeAppAd { get; set; }

            [JsonProperty("net_promoter")]
            public bool NetPromoter { get; set; }

            [JsonProperty("schools_2016_07_ad")]
            public bool Schools201607Ad { get; set; }
        }

        public class PointsData
        {
            [JsonProperty("languages")]
            public List<object> Languages { get; set; }

            [JsonProperty("total")]
            public int Total { get; set; }
        }

        public class PointsRankingData
        {
            [JsonProperty("username")]
            public string Username { get; set; }

            [JsonProperty("language_string")]
            public string LanguageString { get; set; }

            [JsonProperty("points_data")]
            public PointsData PointsData { get; set; }

            [JsonProperty("avatar")]
            public string Avatar { get; set; }

            [JsonProperty("language")]
            public string Language { get; set; }

            [JsonProperty("fullname")]
            public string Fullname { get; set; }

            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("rank")]
            public int Rank { get; set; }

            [JsonProperty("self")]
            public bool Self { get; set; }
        }

        public class Calendar
        {
            [JsonProperty("skill_id")]
            public string SkillId { get; set; }

            [JsonProperty("improvement")]
            public int Improvement { get; set; }

            [JsonProperty("event_type")]
            public string EventType { get; set; }

            [JsonProperty("datetime")]
            public object Datetime { get; set; }
        }

        public class TrackingProperties
        {
            [JsonProperty("direction")]
            public string Direction { get; set; }

            [JsonProperty("took_placementtest")]
            public bool TookPlacementtest { get; set; }

            [JsonProperty("learning_language")]
            public string LearningLanguage { get; set; }

            [JsonProperty("utc_offset")]
            public double UtcOffset { get; set; }

            [JsonProperty("unsafe_lexeme_restriction")]
            public bool UnsafeLexemeRestriction { get; set; }

            [JsonProperty("ui_language")]
            public string UiLanguage { get; set; }

            [JsonProperty("max_tree_level")]
            public int MaxTreeLevel { get; set; }

            [JsonProperty("streak")]
            public int Streak { get; set; }

            [JsonProperty("username")]
            public string Username { get; set; }

            [JsonProperty("creation_age")]
            public long CreationAge { get; set; }

            [JsonProperty("has_observer")]
            public bool HasObserver { get; set; }

            [JsonProperty("has_picture")]
            public bool HasPicture { get; set; }

            [JsonProperty("is_age_restricted")]
            public bool IsAgeRestricted { get; set; }

            [JsonProperty("acquisition_last_landing_page")]
            public string AcquisitionLastLandingPage { get; set; }

            [JsonProperty("acquisition_survey_reason")]
            public string AcquisitionSurveyReason { get; set; }

            [JsonProperty("premium_had_previous_item")]
            public bool PremiumHadPreviousItem { get; set; }

            [JsonProperty("creation_date")]
            public DateTime CreationDate { get; set; }

            [JsonProperty("num_followers")]
            public int NumFollowers { get; set; }

            [JsonProperty("is_pearson_user")]
            public bool IsPearsonUser { get; set; }

            [JsonProperty("placement_section_index")]
            public object PlacementSectionIndex { get; set; }

            [JsonProperty("notification_wechat_enabled")]
            public bool NotificationWechatEnabled { get; set; }

            [JsonProperty("has_item_weekend_amulet")]
            public bool HasItemWeekendAmulet { get; set; }

            [JsonProperty("disable_clubs")]
            public bool DisableClubs { get; set; }

            [JsonProperty("gems")]
            public int Gems { get; set; }

            [JsonProperty("has_fullname")]
            public bool HasFullname { get; set; }

            [JsonProperty("beta_shake_to_report_enabled")]
            public object BetaShakeToReportEnabled { get; set; }

            [JsonProperty("user_id")]
            public int UserId { get; set; }

            [JsonProperty("goal")]
            public int Goal { get; set; }

            [JsonProperty("disable_personalized_ads")]
            public bool DisablePersonalizedAds { get; set; }

            [JsonProperty("has_item_rupee_wager")]
            public bool HasItemRupeeWager { get; set; }

            [JsonProperty("disable_events")]
            public bool DisableEvents { get; set; }

            [JsonProperty("disable_discussions")]
            public bool DisableDiscussions { get; set; }

            [JsonProperty("disable_third_party_tracking")]
            public bool DisableThirdPartyTracking { get; set; }

            [JsonProperty("has_item_streak_repair")]
            public bool HasItemStreakRepair { get; set; }

            [JsonProperty("creation_date_new")]
            public DateTime CreationDateNew { get; set; }

            [JsonProperty("disable_mature_words")]
            public bool DisableMatureWords { get; set; }

            [JsonProperty("skill_tree_id")]
            public string SkillTreeId { get; set; }

            [JsonProperty("disable_stream")]
            public bool DisableStream { get; set; }

            [JsonProperty("placement_depth")]
            public object PlacementDepth { get; set; }

            [JsonProperty("has_item_streak_freeze")]
            public bool HasItemStreakFreeze { get; set; }

            [JsonProperty("has_item_immersive_subscription")]
            public bool HasItemImmersiveSubscription { get; set; }

            [JsonProperty("learning_reason")]
            public string LearningReason { get; set; }

            [JsonProperty("has_item_live_subscription")]
            public bool HasItemLiveSubscription { get; set; }

            [JsonProperty("num_sections_unlocked")]
            public int NumSectionsUnlocked { get; set; }

            [JsonProperty("num_classrooms")]
            public int NumClassrooms { get; set; }

            [JsonProperty("creation_date_millis")]
            public long CreationDateMillis { get; set; }

            [JsonProperty("beta_enrollment_status")]
            public string BetaEnrollmentStatus { get; set; }

            [JsonProperty("disable_profile_country")]
            public bool DisableProfileCountry { get; set; }

            [JsonProperty("distinct_id")]
            public int DistinctId { get; set; }

            [JsonProperty("num_skills_unlocked")]
            public int NumSkillsUnlocked { get; set; }

            [JsonProperty("has_facebook")]
            public bool HasFacebook { get; set; }

            [JsonProperty("num_observees")]
            public int NumObservees { get; set; }

            [JsonProperty("acquisition_last_landing_url")]
            public string AcquisitionLastLandingUrl { get; set; }

            [JsonProperty("achievements")]
            public List<string> Achievements { get; set; }

            [JsonProperty("notification_whatsapp_enabled")]
            public bool NotificationWhatsappEnabled { get; set; }

            [JsonProperty("has_item_premium_subscription")]
            public bool HasItemPremiumSubscription { get; set; }

            [JsonProperty("lingots")]
            public int Lingots { get; set; }

            [JsonProperty("trial_account")]
            public bool TrialAccount { get; set; }

            [JsonProperty("prior_proficiency_onboarding")]
            public object PriorProficiencyOnboarding { get; set; }

            [JsonProperty("level")]
            public int Level { get; set; }

            [JsonProperty("notification_sms_enabled")]
            public bool NotificationSmsEnabled { get; set; }

            [JsonProperty("is_self_observer")]
            public bool IsSelfObserver { get; set; }

            [JsonProperty("num_sessions_completed")]
            public int NumSessionsCompleted { get; set; }

            [JsonProperty("has_item_streak_wager")]
            public bool HasItemStreakWager { get; set; }

            [JsonProperty("disable_immersion")]
            public bool DisableImmersion { get; set; }

            [JsonProperty("acquisition_last_landing_page_date")]
            public long AcquisitionLastLandingPageDate { get; set; }

            [JsonProperty("leaderboard_league")]
            public int LeaderboardLeague { get; set; }

            [JsonProperty("num_item_streak_freeze")]
            public int NumItemStreakFreeze { get; set; }

            [JsonProperty("has_phone_number")]
            public bool HasPhoneNumber { get; set; }

            [JsonProperty("num_following")]
            public int NumFollowing { get; set; }

            [JsonProperty("has_location")]
            public bool HasLocation { get; set; }
        }

        public class NextLesson
        {
            [JsonProperty("lesson_number")]
            public int LessonNumber { get; set; }

            [JsonProperty("skill_title")]
            public string SkillTitle { get; set; }

            [JsonProperty("skill_url")]
            public string SkillUrl { get; set; }
        }

        public class SkillProgress
        {
            [JsonProperty("level")]
            public int Level { get; set; }
        }

        public class CommentData
        {
        }

        public class Skill
        {
            [JsonProperty("language_string")]
            public string LanguageString { get; set; }

            [JsonProperty("dependencies_name")]
            public List<string> DependenciesName { get; set; }

            [JsonProperty("practice_recommended")]
            public bool PracticeRecommended { get; set; }

            [JsonProperty("disabled")]
            public bool Disabled { get; set; }

            [JsonProperty("test_count")]
            public int TestCount { get; set; }

            [JsonProperty("missing_lessons")]
            public int MissingLessons { get; set; }

            [JsonProperty("skill_progress")]
            public SkillProgress SkillProgress { get; set; }

            [JsonProperty("lesson")]
            public bool Lesson { get; set; }

            [JsonProperty("has_explanation")]
            public object HasExplanation { get; set; }

            [JsonProperty("url_title")]
            public string UrlTitle { get; set; }

            [JsonProperty("icon_color")]
            public string IconColor { get; set; }

            [JsonProperty("category")]
            public string Category { get; set; }

            [JsonProperty("num_lessons")]
            public int NumLessons { get; set; }

            [JsonProperty("strength")]
            public double Strength { get; set; }

            [JsonProperty("beginner")]
            public bool Beginner { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("num_levels")]
            public int NumLevels { get; set; }

            [JsonProperty("coords_y")]
            public int CoordsY { get; set; }

            [JsonProperty("coords_x")]
            public int CoordsX { get; set; }

            [JsonProperty("progress_level_session_index")]
            public int ProgressLevelSessionIndex { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("level_sessions_finished")]
            public int LevelSessionsFinished { get; set; }

            [JsonProperty("levels_finished")]
            public int LevelsFinished { get; set; }

            [JsonProperty("test")]
            public bool Test { get; set; }

            [JsonProperty("lesson_number")]
            public int LessonNumber { get; set; }

            [JsonProperty("learned")]
            public bool Learned { get; set; }

            [JsonProperty("num_translation_nodes")]
            public int NumTranslationNodes { get; set; }

            [JsonProperty("achievements")]
            public List<object> Achievements { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("index")]
            public int Index { get; set; }

            [JsonProperty("bonus")]
            public bool Bonus { get; set; }

            [JsonProperty("locked")]
            public bool Locked { get; set; }

            [JsonProperty("explanation")]
            public string Explanation { get; set; }

            [JsonProperty("num_lexemes")]
            public int NumLexemes { get; set; }

            [JsonProperty("num_missing")]
            public int NumMissing { get; set; }

            [JsonProperty("comment_data")]
            public CommentData CommentData { get; set; }

            [JsonProperty("dependencies")]
            public List<string> Dependencies { get; set; }

            [JsonProperty("known_lexemes")]
            public List<string> KnownLexemes { get; set; }

            [JsonProperty("words")]
            public List<string> Words { get; set; }

            [JsonProperty("num_sessions_for_level")]
            public int NumSessionsForLevel { get; set; }

            [JsonProperty("path")]
            public List<object> Path { get; set; }

            [JsonProperty("strength_no_disabled_no_character")]
            public double StrengthNoDisabledNoCharacter { get; set; }

            [JsonProperty("strength_no_disabled")]
            public double StrengthNoDisabled { get; set; }

            [JsonProperty("short")]
            public string Short { get; set; }

            [JsonProperty("grammar")]
            public bool Grammar { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("language")]
            public string Language { get; set; }

            [JsonProperty("is_new_grammar")]
            public bool IsNewGrammar { get; set; }

            [JsonProperty("new_index")]
            public int NewIndex { get; set; }

            [JsonProperty("progress_percent")]
            public double ProgressPercent { get; set; }

            [JsonProperty("mastered")]
            public bool Mastered { get; set; }

            [JsonProperty("learned_ts")]
            public int? LearnedTs { get; set; }
        }

        public class PlacementTest
        {
            [JsonProperty("attempts")]
            public int Attempts { get; set; }
        }

        public class LanguageStudied
        {
            [JsonProperty("streak")]
            public int Streak { get; set; }

            [JsonProperty("language_string")]
            public string LanguageString { get; set; }

            [JsonProperty("level_progress")]
            public int LevelProgress { get; set; }

            [JsonProperty("first_time")]
            public bool FirstTime { get; set; }

            [JsonProperty("bonus_rows")]
            public List<object> BonusRows { get; set; }

            [JsonProperty("points_rank")]
            public int PointsRank { get; set; }

            [JsonProperty("fluency_score")]
            public double FluencyScore { get; set; }

            [JsonProperty("push_practice")]
            public bool PushPractice { get; set; }

            [JsonProperty("max_section_index")]
            public int MaxSectionIndex { get; set; }

            [JsonProperty("level_tests")]
            public List<LevelTest> LevelTests { get; set; }

            [JsonProperty("direction_status")]
            public string DirectionStatus { get; set; }

            [JsonProperty("next_level")]
            public int NextLevel { get; set; }

            [JsonProperty("linkedin_share_url")]
            public string LinkedinShareUrl { get; set; }

            [JsonProperty("notify_practice")]
            public bool NotifyPractice { get; set; }

            [JsonProperty("notifications")]
            public Notifications Notifications { get; set; }

            [JsonProperty("max_cefr_level")]
            public object MaxCefrLevel { get; set; }

            [JsonProperty("notify_time")]
            public int NotifyTime { get; set; }

            [JsonProperty("points_ranking_data")]
            public List<PointsRankingData> PointsRankingData { get; set; }

            [JsonProperty("num_skills_learned")]
            public int NumSkillsLearned { get; set; }

            [JsonProperty("calendar")]
            public List<Calendar> Calendar { get; set; }

            [JsonProperty("can_transliterate")]
            public bool CanTransliterate { get; set; }

            [JsonProperty("level_left")]
            public int LevelLeft { get; set; }

            [JsonProperty("no_dep")]
            public bool NoDep { get; set; }

            [JsonProperty("tracking_properties")]
            public TrackingProperties TrackingProperties { get; set; }

            [JsonProperty("language_strength")]
            public double LanguageStrength { get; set; }

            [JsonProperty("next_lesson")]
            public NextLesson NextLesson { get; set; }

            [JsonProperty("max_level")]
            public bool MaxLevel { get; set; }

            [JsonProperty("level_percent")]
            public int LevelPercent { get; set; }

            [JsonProperty("language")]
            public string Language { get; set; }

            [JsonProperty("level")]
            public int Level { get; set; }

            [JsonProperty("skills")]
            public List<Skill> Skills { get; set; }

            [JsonProperty("bonus_skills")]
            public List<object> BonusSkills { get; set; }

            [JsonProperty("level_points")]
            public int LevelPoints { get; set; }

            [JsonProperty("all_time_rank")]
            public List<string> AllTimeRank { get; set; }

            [JsonProperty("useSmartReminderTime")]
            public bool UseSmartReminderTime { get; set; }

            [JsonProperty("max_depth_learned")]
            public int MaxDepthLearned { get; set; }

            [JsonProperty("points")]
            public int Points { get; set; }

            [JsonProperty("immersion_enabled")]
            public bool ImmersionEnabled { get; set; }

            [JsonProperty("placement_test")]
            public PlacementTest PlacementTest { get; set; }

            [JsonProperty("exempt_from_health")]
            public bool ExemptFromHealth { get; set; }

            [JsonProperty("max_tree_level")]
            public int MaxTreeLevel { get; set; }
        }

        public class Language
        {
            [JsonProperty("streak")]
            public int Streak { get; set; }

            [JsonProperty("language_string")]
            public string LanguageString { get; set; }

            [JsonProperty("points")]
            public int Points { get; set; }

            [JsonProperty("learning")]
            public bool Learning { get; set; }

            [JsonProperty("language")]
            public string Abbreviation { get; set; }

            [JsonProperty("level")]
            public int Level { get; set; }

            [JsonProperty("current_learning")]
            public bool CurrentLearning { get; set; }

            [JsonProperty("sentences_translated")]
            public int SentencesTranslated { get; set; }

            [JsonProperty("to_next_level")]
            public int ToNextLevel { get; set; }
        }

        public class LastStreak
        {
            [JsonProperty("shortened_product_id")]
            public string ShortenedProductId { get; set; }

            [JsonProperty("is_available_for_repair")]
            public bool IsAvailableForRepair { get; set; }

            [JsonProperty("google_play_product_id")]
            public string GooglePlayProductId { get; set; }

            [JsonProperty("product_id")]
            public string ProductId { get; set; }

            [JsonProperty("days_ago")]
            public int DaysAgo { get; set; }

            [JsonProperty("length")]
            public int Length { get; set; }

            [JsonProperty("last_reached_goal")]
            public long LastReachedGoal { get; set; }
        }

        public class PrivacySettings
        {
            [JsonProperty("disable_clubs")]
            public bool DisableClubs { get; set; }

            [JsonProperty("disable_discussions")]
            public bool DisableDiscussions { get; set; }

            [JsonProperty("disable_events")]
            public bool DisableEvents { get; set; }

            [JsonProperty("disable_immersion")]
            public bool DisableImmersion { get; set; }

            [JsonProperty("disable_mature_words")]
            public bool DisableMatureWords { get; set; }

            [JsonProperty("disable_personalized_ads")]
            public bool DisablePersonalizedAds { get; set; }

            [JsonProperty("disable_stream")]
            public bool DisableStream { get; set; }

            [JsonProperty("disable_third_party_tracking")]
            public bool DisableThirdPartyTracking { get; set; }

            [JsonProperty("disable_profile_country")]
            public bool DisableProfileCountry { get; set; }
        }

        public class Inventory
        {
            [JsonProperty("formal_outfit")]
            public string FormalOutfit { get; set; }

            [JsonProperty("superhero_outfit")]
            public string SuperheroOutfit { get; set; }

            [JsonProperty("luxury_outfit")]
            public string LuxuryOutfit { get; set; }

            [JsonProperty("streak_freeze")]
            public string StreakFreeze { get; set; }

            [JsonProperty("gem_wager")]
            public int GemWager { get; set; }
        }

        public class AbOptions
        {
        }

        public class Root
        {
            public LanguageStudied LanguageData { get; set; }

            [JsonProperty("filter_stream")]
            public bool FilterStream { get; set; }

            [JsonProperty("deactivated")]
            public bool Deactivated { get; set; }

            [JsonProperty("push_clubs")]
            public bool PushClubs { get; set; }

            [JsonProperty("site_streak")]
            public int SiteStreak { get; set; }

            [JsonProperty("tts_base_url_http")]
            public string TtsBaseUrlHttp { get; set; }

            [JsonProperty("push_edit_suggested")]
            public bool PushEditSuggested { get; set; }

            [JsonProperty("transliterate")]
            public bool Transliterate { get; set; }

            [JsonProperty("languages")]
            public List<Language> Languages { get; set; }

            [JsonProperty("location")]
            public string Location { get; set; }

            [JsonProperty("bio")]
            public string Bio { get; set; }

            [JsonProperty("insite_sentence_edited")]
            public bool InsiteSentenceEdited { get; set; }

            [JsonProperty("push_comment")]
            public bool PushComment { get; set; }

            [JsonProperty("notify_activity_comment")]
            public bool NotifyActivityComment { get; set; }

            [JsonProperty("email_streak_saver")]
            public bool EmailStreakSaver { get; set; }

            [JsonProperty("requires_parental_consent")]
            public bool RequiresParentalConsent { get; set; }

            [JsonProperty("push_passed")]
            public bool PushPassed { get; set; }

            [JsonProperty("notify_assignment")]
            public bool NotifyAssignment { get; set; }

            [JsonProperty("avatar")]
            public string Avatar { get; set; }

            [JsonProperty("gplus_id")]
            public string GplusId { get; set; }

            [JsonProperty("ui_language")]
            public string UiLanguage { get; set; }

            [JsonProperty("notify_announcement")]
            public bool NotifyAnnouncement { get; set; }

            [JsonProperty("upload-self-service")]
            public bool UploadSelfService { get; set; }

            [JsonProperty("creation_date")]
            public DateTime CreationDate { get; set; }

            [JsonProperty("calendar")]
            public List<Calendar> Calendar { get; set; }

            [JsonProperty("daily_goal")]
            public int DailyGoal { get; set; }

            [JsonProperty("push_leaderboards")]
            public bool PushLeaderboards { get; set; }

            [JsonProperty("push_announcement")]
            public bool PushAnnouncement { get; set; }

            [JsonProperty("ads_enabled")]
            public bool AdsEnabled { get; set; }

            [JsonProperty("created_dt")]
            public long CreatedDt { get; set; }

            [JsonProperty("is_self_observer")]
            public bool IsSelfObserver { get; set; }

            [JsonProperty("notif_event_ids")]
            public List<object> NotifEventIds { get; set; }

            [JsonProperty("notify_activity_reply")]
            public bool NotifyActivityReply { get; set; }

            [JsonProperty("push_stream_post")]
            public bool PushStreamPost { get; set; }

            [JsonProperty("email")]
            public string Email { get; set; }

            [JsonProperty("week_old_account")]
            public bool WeekOldAccount { get; set; }

            [JsonProperty("email_promotion")]
            public bool EmailPromotion { get; set; }

            [JsonProperty("timezone_offset")]
            public string TimezoneOffset { get; set; }

            [JsonProperty("num_classrooms")]
            public int NumClassrooms { get; set; }

            [JsonProperty("snooze_expiration_time")]
            public int SnoozeExpirationTime { get; set; }

            [JsonProperty("is_observer")]
            public bool IsObserver { get; set; }

            [JsonProperty("notify_weekly_report")]
            public bool NotifyWeeklyReport { get; set; }

            [JsonProperty("delete-permissions")]
            public bool DeletePermissions { get; set; }

            [JsonProperty("notify_comment")]
            public bool NotifyComment { get; set; }

            [JsonProperty("insite_immersion_lingots")]
            public bool InsiteImmersionLingots { get; set; }

            [JsonProperty("notify_edit_suggested")]
            public bool NotifyEditSuggested { get; set; }

            [JsonProperty("notify_weekly_progress_report")]
            public bool NotifyWeeklyProgressReport { get; set; }

            [JsonProperty("created")]
            public string Created { get; set; }

            [JsonProperty("admin")]
            public bool Admin { get; set; }

            [JsonProperty("learning_language")]
            public string LearningLanguage { get; set; }

            [JsonProperty("notify_classroom_leave")]
            public bool NotifyClassroomLeave { get; set; }

            [JsonProperty("notify_clubs")]
            public bool NotifyClubs { get; set; }

            [JsonProperty("freeze-permissions")]
            public bool FreezePermissions { get; set; }

            [JsonProperty("notify_follow")]
            public bool NotifyFollow { get; set; }

            [JsonProperty("last_streak")]
            public LastStreak LastStreak { get; set; }

            [JsonProperty("auto_facebook_post")]
            public bool AutoFacebookPost { get; set; }

            [JsonProperty("privacy_settings")]
            public PrivacySettings PrivacySettings { get; set; }

            [JsonProperty("num_observees")]
            public int NumObservees { get; set; }

            [JsonProperty("notification_sms_disabled")]
            public bool NotificationSmsDisabled { get; set; }

            [JsonProperty("notification_wechat_enabled")]
            public bool NotificationWechatEnabled { get; set; }

            [JsonProperty("dict_base_url")]
            public string DictBaseUrl { get; set; }

            [JsonProperty("push_follow")]
            public bool PushFollow { get; set; }

            [JsonProperty("email_events_digest")]
            public bool EmailEventsDigest { get; set; }

            [JsonProperty("facebook_id")]
            public string FacebookId { get; set; }

            [JsonProperty("browser_language")]
            public string BrowserLanguage { get; set; }

            [JsonProperty("username")]
            public string Username { get; set; }

            [JsonProperty("has_observer")]
            public bool HasObserver { get; set; }

            [JsonProperty("tts_cdn_url")]
            public string TtsCdnUrl { get; set; }

            [JsonProperty("push_activity_reply")]
            public bool PushActivityReply { get; set; }

            [JsonProperty("notification_whatsapp_enabled")]
            public bool NotificationWhatsappEnabled { get; set; }

            [JsonProperty("tracking_properties")]
            public TrackingProperties TrackingProperties { get; set; }

            [JsonProperty("tts_base_url")]
            public string TtsBaseUrl { get; set; }

            [JsonProperty("trial_account")]
            public bool TrialAccount { get; set; }

            [JsonProperty("streak_extended_today")]
            public bool StreakExtendedToday { get; set; }

            [JsonProperty("notify_classroom_join")]
            public bool NotifyClassroomJoin { get; set; }

            [JsonProperty("twitter_id")]
            public string TwitterId { get; set; }

            [JsonProperty("notify_stream_post")]
            public bool NotifyStreamPost { get; set; }

            [JsonProperty("fullname")]
            public string Fullname { get; set; }

            [JsonProperty("push_streak_freeze_used")]
            public bool PushStreakFreezeUsed { get; set; }

            [JsonProperty("push_activity_comment")]
            public bool PushActivityComment { get; set; }

            [JsonProperty("timezone")]
            public string Timezone { get; set; }

            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("current_time")]
            public long CurrentTime { get; set; }

            [JsonProperty("microphone")]
            public bool Microphone { get; set; }

            [JsonProperty("invite_url")]
            public string InviteUrl { get; set; }

            [JsonProperty("sound_effects")]
            public bool SoundEffects { get; set; }

            [JsonProperty("change-design")]
            public bool ChangeDesign { get; set; }

            [JsonProperty("speaker")]
            public bool Speaker { get; set; }

            [JsonProperty("inventory")]
            public Inventory Inventory { get; set; }

            [JsonProperty("learning_language_string")]
            public string LearningLanguageString { get; set; }

            [JsonProperty("notify_schools_announcement")]
            public bool NotifySchoolsAnnouncement { get; set; }

            [JsonProperty("cohort")]
            public object Cohort { get; set; }

            [JsonProperty("ab_options")]
            public AbOptions AbOptions { get; set; }

            [JsonProperty("notify_assignment_complete")]
            public bool NotifyAssignmentComplete { get; set; }

            [JsonProperty("email_verified")]
            public bool EmailVerified { get; set; }

            [JsonProperty("notify_pass")]
            public bool NotifyPass { get; set; }

            [JsonProperty("email_word_of_the_day")]
            public bool EmailWordOfTheDay { get; set; }

            [JsonProperty("push_promotion")]
            public bool PushPromotion { get; set; }

            [JsonProperty("rupees")]
            public int Rupees { get; set; }

            [JsonProperty("email_streak_freeze_used")]
            public bool EmailStreakFreezeUsed { get; set; }

            [JsonProperty("push_streak_saver")]
            public bool PushStreakSaver { get; set; }

            [JsonProperty("autoplay")]
            public bool Autoplay { get; set; }
        }
    }
}
