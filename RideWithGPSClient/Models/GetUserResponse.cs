using System.Text.Json.Serialization;

namespace RideWithGps.Models;

// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
public class Facebook
{
	[JsonPropertyName("notify_on_activity")]
	public bool NotifyOnActivity { get; set; }

	[JsonPropertyName("notify_on_route")]
	public bool NotifyOnRoute { get; set; }
}

public class Gear
{
	[JsonPropertyName("id")]
	public int Id { get; set; }

	[JsonPropertyName("make")]
	public string Make { get; set; } = default!;

	[JsonPropertyName("model")]
	public string Model { get; set; } = default!;

	[JsonPropertyName("year")]
	public int? Year { get; set; }

	[JsonPropertyName("description")]
	public string? Description { get; set; }

	[JsonPropertyName("group_membership_id")]
	public int GroupMembershipId { get; set; }

	[JsonPropertyName("gear_type_id")]
	public int? GearTypeId { get; set; }

	[JsonPropertyName("gear_model_id")]
	public int? GearModelId { get; set; }

	[JsonPropertyName("created_at")]
	public DateTime CreatedAt { get; set; }

	[JsonPropertyName("exclude_from_totals")]
	public bool ExcludeFromTotals { get; set; }

	[JsonPropertyName("nickname")]
	public string? Nickname { get; set; }

	[JsonPropertyName("serial_number")]
	public string? SerialNumber { get; set; }

	[JsonPropertyName("weight")]
	public double? Weight { get; set; }

	[JsonPropertyName("visibility")]
	public int Visibility { get; set; }

	[JsonPropertyName("archived")]
	public bool Archived { get; set; }

	[JsonPropertyName("use_user_timezone")]
	public bool UseUserTimezone { get; set; }

	[JsonPropertyName("project_529_id")]
	public int? Project529Id { get; set; }

	[JsonPropertyName("default_activity_type_id")]
	public int? DefaultActivityTypeId { get; set; }

	[JsonPropertyName("name")]
	public string? Name { get; set; }
}

public class Heatmap
{
	[JsonPropertyName("assets")]
	public string? Assets { get; set; }

	[JsonPropertyName("name")]
	public string? Name { get; set; }

	[JsonPropertyName("key")]
	public string? Key { get; set; }

	[JsonPropertyName("track_count")]
	public int TrackCount { get; set; }

	[JsonPropertyName("built_at")]
	public DateTime BuiltAt { get; set; }
}

public class Labs
{
	[JsonPropertyName("fit_export")]
	public bool FitExport { get; set; }

	[JsonPropertyName("rsp_redesign")]
	public bool RspRedesign { get; set; }

	[JsonPropertyName("homepage_redesign")]
	public bool HomepageRedesign { get; set; }

	[JsonPropertyName("pinned_in_searchbar")]
	public bool PinnedInSearchbar { get; set; }

	[JsonPropertyName("smart_export")]
	public bool SmartExport { get; set; }

	[JsonPropertyName("mobile_home_redesign")]
	public bool MobileHomeRedesign { get; set; }

	[JsonPropertyName("can_see_homepage_opt_in")]
	public bool CanSeeHomepageOptIn { get; set; }

	[JsonPropertyName("strava_sync")]
	public bool StravaSync { get; set; }

	[JsonPropertyName("relive_sync")]
	public bool ReliveSync { get; set; }

	[JsonPropertyName("varia")]
	public bool Varia { get; set; }

	[JsonPropertyName("route_planner")]
	public bool RoutePlanner { get; set; }

	[JsonPropertyName("app_home_v3")]
	public bool AppHomeV3 { get; set; }

	[JsonPropertyName("prevent_sticky_gmaps")]
	public bool PreventStickyGmaps { get; set; }

	[JsonPropertyName("surface_types")]
	public bool SurfaceTypes { get; set; }

	[JsonPropertyName("new_logging_service")]
	public bool NewLoggingService { get; set; }

	[JsonPropertyName("new_search_results")]
	public bool NewSearchResults { get; set; }

	[JsonPropertyName("kaboom")]
	public bool Kaboom { get; set; }

	[JsonPropertyName("zd_chat")]
	public bool ZdChat { get; set; }

	[JsonPropertyName("personal_explore_web")]
	public bool PersonalExploreWeb { get; set; }

	[JsonPropertyName("mobile_explore_filters")]
	public bool MobileExploreFilters { get; set; }

	[JsonPropertyName("inspect_promo")]
	public bool InspectPromo { get; set; }

	[JsonPropertyName("watch_auto_pause")]
	public bool WatchAutoPause { get; set; }

	[JsonPropertyName("remove_find_filters")]
	public bool RemoveFindFilters { get; set; }

	[JsonPropertyName("fast_auto_pause")]
	public bool FastAutoPause { get; set; }

	[JsonPropertyName("personal_explore_mobile_map")]
	public bool PersonalExploreMobileMap { get; set; }

	[JsonPropertyName("mobile_choice")]
	public bool MobileChoice { get; set; }

	[JsonPropertyName("personal_routes_explore_web")]
	public bool PersonalRoutesExploreWeb { get; set; }

	[JsonPropertyName("inspect_in_planner")]
	public bool InspectInPlanner { get; set; }

	[JsonPropertyName("pew_photos")]
	public bool PewPhotos { get; set; }

	[JsonPropertyName("reviews_in_comments")]
	public bool ReviewsInComments { get; set; }

	[JsonPropertyName("personal_explore_mobile_location")]
	public bool PersonalExploreMobileLocation { get; set; }

	[JsonPropertyName("reviews_menu_item")]
	public bool ReviewsMenuItem { get; set; }

	[JsonPropertyName("Personal Explore Mobile Inspect")]
	public bool PersonalExploreMobileInspect { get; set; }

	[JsonPropertyName("fb_migration")]
	public bool FbMigration { get; set; }

	[JsonPropertyName("fb_migration_save")]
	public bool FbMigrationSave { get; set; }

	[JsonPropertyName("fb_removal_mobile")]
	public bool FbRemovalMobile { get; set; }

	[JsonPropertyName("fb_removal_web")]
	public bool FbRemovalWeb { get; set; }

	[JsonPropertyName("Heatmap Upsell")]
	public bool HeatmapUpsell { get; set; }

	[JsonPropertyName("web_hide_basic")]
	public bool WebHideBasic { get; set; }

	[JsonPropertyName("Personal Explore Mobile Promo")]
	public bool PersonalExploreMobilePromo { get; set; }

	[JsonPropertyName("rwgps_cycle_takeover")]
	public bool RwgpsCycleTakeover { get; set; }

	[JsonPropertyName("mapbox_planner")]
	public bool MapboxPlanner { get; set; }

	[JsonPropertyName("web_explore")]
	public bool WebExplore { get; set; }

	[JsonPropertyName("push_on_ride_sync")]
	public bool PushOnRideSync { get; set; }

	[JsonPropertyName("mobile_zd_chat")]
	public bool MobileZdChat { get; set; }

	[JsonPropertyName("ios_premium_push")]
	public bool IosPremiumPush { get; set; }

	[JsonPropertyName("upload_page_redesign")]
	public bool UploadPageRedesign { get; set; }

	[JsonPropertyName("global_search_ng")]
	public bool GlobalSearchNg { get; set; }

	[JsonPropertyName("org_upload_redesign")]
	public bool OrgUploadRedesign { get; set; }

	[JsonPropertyName("apps_disable_auto_record")]
	public bool AppsDisableAutoRecord { get; set; }

	[JsonPropertyName("set_home_location_modal")]
	public bool SetHomeLocationModal { get; set; }

	[JsonPropertyName("map_layers")]
	public bool MapLayers { get; set; }

	[JsonPropertyName("explore_hover_name_only")]
	public bool ExploreHoverNameOnly { get; set; }

	[JsonPropertyName("explore_club_suggestion")]
	public bool ExploreClubSuggestion { get; set; }

	[JsonPropertyName("trsp_explore_more")]
	public bool TrspExploreMore { get; set; }

	[JsonPropertyName("explore_autochoose")]
	public bool ExploreAutochoose { get; set; }

	[JsonPropertyName("new_mobile_onboarding_experience")]
	public bool NewMobileOnboardingExperience { get; set; }

	[JsonPropertyName("s2d_hammerhead")]
	public bool S2dHammerhead { get; set; }

	[JsonPropertyName("settings_privacy_tab")]
	public bool SettingsPrivacyTab { get; set; }

	[JsonPropertyName("region_content_portal")]
	public bool RegionContentPortal { get; set; }

	[JsonPropertyName("change_start_release")]
	public bool ChangeStartRelease { get; set; }

	[JsonPropertyName("map_layers_sticky")]
	public bool MapLayersSticky { get; set; }

	[JsonPropertyName("s2d_use_hammerhead_production")]
	public bool S2dUseHammerheadProduction { get; set; }

	[JsonPropertyName("new_routing_options")]
	public bool NewRoutingOptions { get; set; }

	[JsonPropertyName("unpaved_surfaces_layer")]
	public bool UnpavedSurfacesLayer { get; set; }

	[JsonPropertyName("private_contributions_card")]
	public bool PrivateContributionsCard { get; set; }

	[JsonPropertyName("signup_modal_trial_prompt")]
	public bool SignupModalTrialPrompt { get; set; }

	[JsonPropertyName("new_signup_and_trial_modal")]
	public bool NewSignupAndTrialModal { get; set; }

	[JsonPropertyName("samsung_battery_warning")]
	public bool SamsungBatteryWarning { get; set; }

	[JsonPropertyName("new_login_modal")]
	public bool NewLoginModal { get; set; }

	[JsonPropertyName("new_routing_options_toggle")]
	public bool NewRoutingOptionsToggle { get; set; }

	[JsonPropertyName("new_homepage")]
	public bool NewHomepage { get; set; }
}

public class Preferences
{
	[JsonPropertyName("default_privacy_trip")]
	public int DefaultPrivacyTrip { get; set; }

	[JsonPropertyName("default_privacy_route")]
	public int DefaultPrivacyRoute { get; set; }

	[JsonPropertyName("metric_units")]
	public bool MetricUnits { get; set; }

	[JsonPropertyName("facebook")]
	public Facebook? Facebook { get; set; }

	[JsonPropertyName("hide_location")]
	public string? HideLocation { get; set; }

	[JsonPropertyName("default_gear_id")]
	public string? DefaultGearId { get; set; }

	[JsonPropertyName("default_home")]
	public string? DefaultHome { get; set; }

	[JsonPropertyName("segments_private")]
	public bool SegmentsPrivate { get; set; }

	[JsonPropertyName("receive_segment_notifications")]
	public bool ReceiveSegmentNotifications { get; set; }

	[JsonPropertyName("route_planner_directions_type")]
	public string? RoutePlannerDirectionsType { get; set; }

	[JsonPropertyName("private_trips")]
	public bool PrivateTrips { get; set; }

	[JsonPropertyName("route_viewer_active_tab")]
	public string? RouteViewerActiveTab { get; set; }

	[JsonPropertyName("route_viewer_active_subtab")]
	public string? RouteViewerActiveSubtab { get; set; }

	[JsonPropertyName("calendar_show_hr")]
	public bool CalendarShowHr { get; set; }

	[JsonPropertyName("profile_default_tab")]
	public string? ProfileDefaultTab { get; set; }

	[JsonPropertyName("route_planner_options_opened")]
	public bool RoutePlannerOptionsOpened { get; set; }

	[JsonPropertyName("route_planner_right_sidebar_closed")]
	public bool RoutePlannerRightSidebarClosed { get; set; }

	[JsonPropertyName("route_viewer_options_opened")]
	public bool RouteViewerOptionsOpened { get; set; }

	[JsonPropertyName("route_viewer_enable_distance_markers")]
	public bool RouteViewerEnableDistanceMarkers { get; set; }

	[JsonPropertyName("route_viewer_enable_scrollwheel_zoom")]
	public bool RouteViewerEnableScrollwheelZoom { get; set; }

	[JsonPropertyName("route_planner_left_sidebar_closed")]
	public bool RoutePlannerLeftSidebarClosed { get; set; }

	[JsonPropertyName("feeds_default_tab")]
	public string FeedsDefaultTab { get; set; }

	[JsonPropertyName("planner_overlay")]
	public string PlannerOverlay { get; set; }

	[JsonPropertyName("print.include_elevation")]
	public bool PrintIncludeElevation { get; set; }

	[JsonPropertyName("default_career_interval")]
	public string DefaultCareerInterval { get; set; }

	[JsonPropertyName("activities_user_index_list_mode")]
	public string ActivitiesUserIndexListMode { get; set; }

	[JsonPropertyName("planner-onboarding-dismissed")]
	public bool PlannerOnboardingDismissed { get; set; }

	[JsonPropertyName("RSP:noticebar_dismissed")]
	public bool RSPNoticebarDismissed { get; set; }

	[JsonPropertyName("date_format")]
	public string DateFormat { get; set; }

	[JsonPropertyName("show_dash_onboarding_overlay")]
	public bool ShowDashOnboardingOverlay { get; set; }

	[JsonPropertyName("show_dash_mini_onboarding")]
	public bool ShowDashMiniOnboarding { get; set; }

	[JsonPropertyName("hide_zendesk_button")]
	public bool HideZendeskButton { get; set; }

	[JsonPropertyName("dashboard_home")]
	public string DashboardHome { get; set; }

	[JsonPropertyName("trsp_notice_dismissed")]
	public bool TrspNoticeDismissed { get; set; }

	[JsonPropertyName("default_to_tsp_pref")]
	public DateTime DefaultToTspPref { get; set; }

	[JsonPropertyName("smart_export_state")]
	public string SmartExportState { get; set; }

	[JsonPropertyName("global_notification_dismissed")]
	public int GlobalNotificationDismissed { get; set; }

	[JsonPropertyName("smart_export_show_phone_push_option")]
	public bool SmartExportShowPhonePushOption { get; set; }

	[JsonPropertyName("heatmap_overlay")]
	public bool HeatmapOverlay { get; set; }

	[JsonPropertyName("gift_sub_banner_dismissed")]
	public bool GiftSubBannerDismissed { get; set; }

	[JsonPropertyName("personal_heatmap")]
	public bool PersonalHeatmap { get; set; }

	[JsonPropertyName("show_subscribe_newsletter")]
	public bool ShowSubscribeNewsletter { get; set; }

	[JsonPropertyName("PEREX_RIDES_PROMO_PREF")]
	public bool PEREXRIDESPROMOPREF { get; set; }

	[JsonPropertyName("SHOW_EXPLORE_PROMO")]
	public bool SHOWEXPLOREPROMO { get; set; }

	[JsonPropertyName("PEREX_ROUTES_PROMO_PREF")]
	public bool PEREXROUTESPROMOPREF { get; set; }

	[JsonPropertyName("2023_gift_sub_banner_dismissed")]
	public bool _2023GiftSubBannerDismissed { get; set; }

	[JsonPropertyName("2024_gift_sub_banner_dismissed")]
	public bool _2024GiftSubBannerDismissed { get; set; }

	[JsonPropertyName("smarter_export_state")]
	public string SmarterExportState { get; set; }

	[JsonPropertyName("print.include_maps_in_cuesheet")]
	public bool PrintIncludeMapsInCuesheet { get; set; }

	[JsonPropertyName("2024_gravel_getaway_banner_dismissed")]
	public bool _2024GravelGetawayBannerDismissed { get; set; }

	[JsonPropertyName("private_contributions_card_dismissed")]
	public bool PrivateContributionsCardDismissed { get; set; }

	[JsonPropertyName("allow_anon_private_ride_contributions")]
	public bool AllowAnonPrivateRideContributions { get; set; }

	[JsonPropertyName("change_start_bump_dismissed")]
	public bool ChangeStartBumpDismissed { get; set; }

	[JsonPropertyName("map_layers_bump_dismissed")]
	public bool MapLayersBumpDismissed { get; set; }

	[JsonPropertyName("route_planner_routing_opts")]
	public string RoutePlannerRoutingOpts { get; set; }

	[JsonPropertyName("analytics_consent")]
	public bool AnalyticsConsent { get; set; }
}

public class GetUserResponse
{
	[JsonPropertyName("user")]
	public User User { get; set; } = default!;

	[JsonPropertyName("labs")]
	public Labs Labs { get; set; } = default!;

	//[JsonPropertyName("additional_drawer_items")]
	//public List<object> AdditionalDrawerItems { get; set; }
}

public class SlimFavorite
{
	[JsonPropertyName("id")]
	public int Id { get; set; }

	[JsonPropertyName("associated_object_type")]
	public string AssociatedObjectType { get; set; }

	[JsonPropertyName("associated_object_id")]
	public int AssociatedObjectId { get; set; }
}

public class SystemCollection
{
	[JsonPropertyName("id")]
	public int Id { get; set; }

	[JsonPropertyName("kind")]
	public string Kind { get; set; }

	[JsonPropertyName("title")]
	public string Title { get; set; }

	[JsonPropertyName("created_at")]
	public DateTime CreatedAt { get; set; }

	[JsonPropertyName("updated_at")]
	public DateTime UpdatedAt { get; set; }
}

public class User
{
	[JsonPropertyName("id")]
	public int Id { get; set; }

	[JsonPropertyName("first_name")]
	public string? FirstName { get; set; }

	[JsonPropertyName("last_name")]
	public string? LastName { get; set; }

	[JsonPropertyName("email")]
	public string Email { get; set; } = default!;

	[JsonPropertyName("created_at")]
	public DateTime CreatedAt { get; set; }

	[JsonPropertyName("self_membership_id")]
	public int SelfMembershipId { get; set; }

	[JsonPropertyName("description")]
	public string Description { get; set; }

	[JsonPropertyName("interests")]
	public string Interests { get; set; }

	[JsonPropertyName("email_visible")]
	public bool EmailVisible { get; set; }

	[JsonPropertyName("last_login_at")]
	public DateTime LastLoginAt { get; set; }

	[JsonPropertyName("total_route_distance")]
	public double TotalRouteDistance { get; set; }

	[JsonPropertyName("metric_units")]
	public bool MetricUnits { get; set; }

	[JsonPropertyName("hr_max")]
	public string? HrMax { get; set; }

	[JsonPropertyName("hr_rest")]
	public string? HrRest { get; set; }

	[JsonPropertyName("hr_zone_1_low")]
	public string? HrZone1Low { get; set; }

	[JsonPropertyName("hr_zone_1_high")]
	public string? HrZone1High { get; set; }

	[JsonPropertyName("hr_zone_2_low")]
	public string? HrZone2Low { get; set; }

	[JsonPropertyName("hr_zone_2_high")]
	public string? HrZone2High { get; set; }

	[JsonPropertyName("hr_zone_3_low")]
	public string? HrZone3Low { get; set; }

	[JsonPropertyName("hr_zone_3_high")]
	public string? HrZone3High { get; set; }

	[JsonPropertyName("hr_zone_4_low")]
	public string? HrZone4Low { get; set; }

	[JsonPropertyName("hr_zone_4_high")]
	public string? HrZone4High { get; set; }

	[JsonPropertyName("hr_zone_5_low")]
	public string? HrZone5Low { get; set; }

	[JsonPropertyName("hr_zone_5_high")]
	public string? HrZone5High { get; set; }

	[JsonPropertyName("is_male")]
	public bool? IsMale { get; set; }

	[JsonPropertyName("weight")]
	public int? Weight { get; set; }

	[JsonPropertyName("vo2max")]
	public int? Vo2max { get; set; }

	[JsonPropertyName("num_unread_messages")]
	public int NumUnreadMessages { get; set; }

	[JsonPropertyName("lat")]
	public double Lat { get; set; }

	[JsonPropertyName("lng")]
	public double Lng { get; set; }

	[JsonPropertyName("display_name")]
	public string? DisplayName { get; set; }

	[JsonPropertyName("locality")]
	public string Locality { get; set; }

	[JsonPropertyName("administrative_area")]
	public string AdministrativeArea { get; set; }

	[JsonPropertyName("postal_code")]
	public string PostalCode { get; set; }

	[JsonPropertyName("country_code")]
	public string CountryCode { get; set; }

	[JsonPropertyName("email_on_message")]
	public bool EmailOnMessage { get; set; }

	[JsonPropertyName("email_on_comment")]
	public bool EmailOnComment { get; set; }

	[JsonPropertyName("email_on_update")]
	public bool EmailOnUpdate { get; set; }

	[JsonPropertyName("visibility")]
	public int Visibility { get; set; }

	[JsonPropertyName("time_zone")]
	public string TimeZone { get; set; }

	[JsonPropertyName("facebook_id")]
	public object FacebookId { get; set; }

	[JsonPropertyName("account_level")]
	public int AccountLevel { get; set; }

	[JsonPropertyName("weeks_start_on")]
	public int WeeksStartOn { get; set; }

	[JsonPropertyName("email_bounce_count")]
	public int EmailBounceCount { get; set; }

	[JsonPropertyName("trips_included_in_totals_count")]
	public int TripsIncludedInTotalsCount { get; set; }

	[JsonPropertyName("site_id")]
	public int SiteId { get; set; }

	[JsonPropertyName("dob")]
	public object Dob { get; set; }

	[JsonPropertyName("deactivated")]
	public int Deactivated { get; set; }

	[JsonPropertyName("updated_at")]
	public DateTime UpdatedAt { get; set; }

	[JsonPropertyName("deactivated_at")]
	public object DeactivatedAt { get; set; }

	[JsonPropertyName("locale")]
	public string Locale { get; set; }

	[JsonPropertyName("heatmap_optout")]
	public bool HeatmapOptout { get; set; }

	[JsonPropertyName("email_on_follow")]
	public bool EmailOnFollow { get; set; }

	[JsonPropertyName("email_on_goal")]
	public bool EmailOnGoal { get; set; }

	[JsonPropertyName("email_monthly_summary")]
	public bool EmailMonthlySummary { get; set; }

	[JsonPropertyName("facebook_access_token_ciphertext")]
	public object FacebookAccessTokenCiphertext { get; set; }

	[JsonPropertyName("email_recommendations")]
	public bool EmailRecommendations { get; set; }

	[JsonPropertyName("email_reviews")]
	public bool EmailReviews { get; set; }

	[JsonPropertyName("push_on_comment")]
	public bool PushOnComment { get; set; }

	[JsonPropertyName("push_on_segment")]
	public bool PushOnSegment { get; set; }

	[JsonPropertyName("push_on_follow")]
	public bool PushOnFollow { get; set; }

	[JsonPropertyName("push_on_ride_sync")]
	public bool PushOnRideSync { get; set; }

	[JsonPropertyName("push_on_like")]
	public bool PushOnLike { get; set; }

	[JsonPropertyName("email_on_like")]
	public bool EmailOnLike { get; set; }

	[JsonPropertyName("email_marketing_email_recommendations")]
	public bool EmailMarketingEmailRecommendations { get; set; }

	[JsonPropertyName("email_marketing_updates_and_announcements")]
	public bool EmailMarketingUpdatesAndAnnouncements { get; set; }

	[JsonPropertyName("email_marketing_tips_and_how_tos")]
	public bool EmailMarketingTipsAndHowTos { get; set; }

	[JsonPropertyName("email_marketing_partnerships_and_promotions")]
	public bool EmailMarketingPartnershipsAndPromotions { get; set; }

	[JsonPropertyName("migrated_facebook_access_token")]
	public object MigratedFacebookAccessToken { get; set; }

	[JsonPropertyName("delete_on")]
	public object DeleteOn { get; set; }

	[JsonPropertyName("name")]
	public string Name { get; set; }

	[JsonPropertyName("age")]
	public object Age { get; set; }

	[JsonPropertyName("privileges")]
	public List<string> Privileges { get; set; }

	[JsonPropertyName("highlighted_photo_id")]
	public int HighlightedPhotoId { get; set; }

	[JsonPropertyName("preferences")]
	public Preferences Preferences { get; set; }

	[JsonPropertyName("gear")]
	public List<Gear> Gear { get; set; }

	[JsonPropertyName("unseen_updates")]
	public List<object> UnseenUpdates { get; set; }

	[JsonPropertyName("push_applications")]
	public List<object> PushApplications { get; set; }

	[JsonPropertyName("relevant_goal_participants")]
	public List<object> RelevantGoalParticipants { get; set; }

	[JsonPropertyName("relevant_challenge_participants")]
	public List<object> RelevantChallengeParticipants { get; set; }

	[JsonPropertyName("has_challenge_participants")]
	public bool HasChallengeParticipants { get; set; }

	[JsonPropertyName("club_ids")]
	public List<object> ClubIds { get; set; }

	[JsonPropertyName("slim_favorites")]
	public List<SlimFavorite> SlimFavorites { get; set; }

	[JsonPropertyName("has_events")]
	public bool HasEvents { get; set; }

	[JsonPropertyName("needs_password_reset")]
	public bool NeedsPasswordReset { get; set; }

	[JsonPropertyName("eligible_for_onetime_trial")]
	public bool EligibleForOnetimeTrial { get; set; }

	[JsonPropertyName("email_on_segment")]
	public bool EmailOnSegment { get; set; }

	[JsonPropertyName("is_shadow_user")]
	public bool IsShadowUser { get; set; }

	[JsonPropertyName("has_set_location")]
	public bool HasSetLocation { get; set; }

	[JsonPropertyName("location")]
	public string? Location { get; set; }

	[JsonPropertyName("auth_token")]
	public string AuthToken { get; set; } = default!;

	//[JsonPropertyName("user_summary")]
	//public UserSummary UserSummary { get; set; }

	[JsonPropertyName("heatmaps")]
	public List<Heatmap> Heatmaps { get; set; } = [];

	[JsonPropertyName("system_collections")]
	public List<SystemCollection> SystemCollections { get; set; } = [];
}

/*
public class UserSummary
{
	[JsonPropertyName("-15")]
	public List<double> _15 { get; set; }

	[JsonPropertyName("-14")]
	public List<double> _14 { get; set; }

	[JsonPropertyName("-13")]
	public List<double> _13 { get; set; }

	[JsonPropertyName("-12")]
	public List<double> _12 { get; set; }

	[JsonPropertyName("-11")]
	public List<double> _11 { get; set; }

	[JsonPropertyName("-10")]
	public List<double> _10 { get; set; }

	[JsonPropertyName("-9")]
	public List<double> _9 { get; set; }

	[JsonPropertyName("-8")]
	public List<double> _8 { get; set; }

	[JsonPropertyName("-7")]
	public List<double> _7 { get; set; }

	[JsonPropertyName("-6")]
	public List<double> _6 { get; set; }

	[JsonPropertyName("-5")]
	public List<double> _5 { get; set; }

	[JsonPropertyName("-4")]
	public List<double> _4 { get; set; }

	[JsonPropertyName("-3")]
	public List<double> _3 { get; set; }

	[JsonPropertyName("-2")]
	public List<double> _2 { get; set; }

	[JsonPropertyName("-1")]
	public List<double> _1 { get; set; }

	[JsonPropertyName("0")]
	public List<double> _0 { get; set; }

	[JsonPropertyName("1")]
	public List<double> _1 { get; set; }

	[JsonPropertyName("2")]
	public List<double> _2 { get; set; }

	[JsonPropertyName("3")]
	public List<double> _3 { get; set; }

	[JsonPropertyName("4")]
	public List<double> _4 { get; set; }

	[JsonPropertyName("5")]
	public List<double> _5 { get; set; }

	[JsonPropertyName("6")]
	public List<double> _6 { get; set; }

	[JsonPropertyName("7")]
	public List<double> _7 { get; set; }

	[JsonPropertyName("8")]
	public List<double> _8 { get; set; }

	[JsonPropertyName("9")]
	public List<double> _9 { get; set; }

	[JsonPropertyName("10")]
	public List<double> _10 { get; set; }

	[JsonPropertyName("11")]
	public List<double> _11 { get; set; }

	[JsonPropertyName("12")]
	public List<double> _12 { get; set; }

	[JsonPropertyName("13")]
	public List<double> _13 { get; set; }

	[JsonPropertyName("14")]
	public List<double> _14 { get; set; }

	[JsonPropertyName("15")]
	public List<double> _15 { get; set; }
}
*/