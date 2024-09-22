using Refit;
using RideWithGps.Models;

namespace RideWithGps;

public class Client
{
	private readonly IRideWithGpsClient _api;

    public Client()
    {
		_api = RestService.For<IRideWithGpsClient>("https://ridewithgps.com");
	}

    public async Task<User> GetUserAsync(GetUserRequest request) => 
		(await _api.GetUserAsync(request)).User;

	public async Task<GetTripsResponse> GetTripsAsync(int userId, GetTripsRequest request) =>
		await _api.GetTripsAsync(userId, request);

}
