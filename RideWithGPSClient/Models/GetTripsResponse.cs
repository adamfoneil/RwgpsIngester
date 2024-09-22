using System.Text.Json.Serialization;

namespace RideWithGps.Models;

public class GetTripsResponse
{
	[JsonPropertyName("results")]
	public List<Trip> Trips { get; set; } = [];
}


public class Trip
{
	[JsonPropertyName("id")]
	public int Id { get; set; }

	[JsonPropertyName("group_membership_id")]
	public int GroupMembershipId { get; set; }

	[JsonPropertyName("route_id")]
	public int? RouteId { get; set; }

	[JsonPropertyName("created_at")]
	public DateTime CreatedAt { get; set; }

	[JsonPropertyName("gear_id")]
	public int GearId { get; set; }

	[JsonPropertyName("departed_at")]
	public DateTime DepartedAt { get; set; }

	[JsonPropertyName("duration")]
	public int Duration { get; set; }

	[JsonPropertyName("distance")]
	public double Distance { get; set; }

	[JsonPropertyName("elevation_gain")]
	public double ElevationGain { get; set; }

	[JsonPropertyName("elevation_loss")]
	public double ElevationLoss { get; set; }

	[JsonPropertyName("visibility")]
	public int Visibility { get; set; }

	[JsonPropertyName("description")]
	public string? Description { get; set; }

	[JsonPropertyName("is_gps")]
	public bool IsGps { get; set; }

	[JsonPropertyName("name")]
	public string? Name { get; set; }

	[JsonPropertyName("max_hr")]
	public int? MaxHr { get; set; }

	[JsonPropertyName("min_hr")]
	public int? MinHr { get; set; }

	[JsonPropertyName("avg_hr")]
	public int? AvgHr { get; set; }

	[JsonPropertyName("max_cad")]
	public int? MaxCadence { get; set; }

	[JsonPropertyName("min_cad")]
	public int? MinCadence { get; set; }

	[JsonPropertyName("avg_cad")]
	public int? AvgCadence { get; set; }

	[JsonPropertyName("avg_speed")]
	public double AvgSpeed { get; set; }

	[JsonPropertyName("max_speed")]
	public double MaxSpeed { get; set; }

	[JsonPropertyName("moving_time")]
	public int MovingTime { get; set; }

	[JsonPropertyName("processed")]
	public bool Processed { get; set; }

	[JsonPropertyName("avg_watts")]
	public double? AvgWatts { get; set; }

	[JsonPropertyName("max_watts")]
	public int? MaxWatts { get; set; }

	[JsonPropertyName("min_watts")]
	public int? MinWatts { get; set; }

	[JsonPropertyName("is_stationary")]
	public bool IsStationary { get; set; }

	[JsonPropertyName("calories")]
	public int? Calories { get; set; }

	[JsonPropertyName("updated_at")]
	public DateTime UpdatedAt { get; set; }

	[JsonPropertyName("time_zone")]
	public string? TimeZone { get; set; }

	[JsonPropertyName("first_lng")]
	public double FirstLng { get; set; }

	[JsonPropertyName("first_lat")]
	public double FirstLat { get; set; }

	[JsonPropertyName("last_lng")]
	public double LastLng { get; set; }

	[JsonPropertyName("last_lat")]
	public double LastLat { get; set; }

	[JsonPropertyName("user_id")]
	public int UserId { get; set; }

	[JsonPropertyName("deleted_at")]
	public DateTime? DeletedAt { get; set; }

	[JsonPropertyName("sw_lng")]
	public double SwLng { get; set; }

	[JsonPropertyName("sw_lat")]
	public double SwLat { get; set; }

	[JsonPropertyName("ne_lng")]
	public double NeLng { get; set; }

	[JsonPropertyName("ne_lat")]
	public double NeLat { get; set; }

	[JsonPropertyName("track_id")]
	public string? TrackId { get; set; }

	[JsonPropertyName("postal_code")]
	public string? PostalCode { get; set; }

	[JsonPropertyName("locality")]
	public string? Locality { get; set; }

	[JsonPropertyName("administrative_area")]
	public string? AdministrativeArea { get; set; }

	[JsonPropertyName("country_code")]
	public string? CountryCode { get; set; }

	[JsonPropertyName("source_type")]
	public string? SourceType { get; set; }

	[JsonPropertyName("likes_count")]
	public int LikesCount { get; set; }

	[JsonPropertyName("track_type")]
	public string? TrackType { get; set; }

	[JsonPropertyName("terrain")]
	public string? Terrain { get; set; }

	[JsonPropertyName("difficulty")]
	public string? Difficulty { get; set; }

	[JsonPropertyName("activity_type_id")]
	public int ActivityTypeId { get; set; }

	[JsonPropertyName("activity_category_id")]
	public int ActivityCategoryId { get; set; }

	[JsonPropertyName("vam")]
	public int Vam { get; set; }

	[JsonPropertyName("work")]
	public object? Work { get; set; }

	[JsonPropertyName("max_grade")]
	public double? MaxGrade { get; set; }

	[JsonPropertyName("highlighted_photo_id")]
	public int HighlightedPhotoId { get; set; }

	[JsonPropertyName("highlighted_photo_checksum")]
	public string? HighlightedPhotoChecksum { get; set; }

	[JsonPropertyName("utc_offset")]
	public int UtcOffset { get; set; }
}

