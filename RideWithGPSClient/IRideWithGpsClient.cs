using Refit;
using RideWithGps.Models;

namespace RideWithGps;

internal interface IRideWithGpsClient
{
	[Get("/users/current.json")]
	Task<GetUserResponse> GetUserAsync(GetUserRequest request);

	[Get("/users/{userId}/trips.json")]
	Task<GetTripsResponse> GetTripsAsync(int userId, GetTripsRequest request);
}
