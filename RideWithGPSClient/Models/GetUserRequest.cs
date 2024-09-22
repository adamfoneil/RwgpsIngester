using Refit;
namespace RideWithGps.Models;

public class GetUserRequest
{
	[AliasAs("email")]
	public string Email { get; set; } = default!;
	[AliasAs("password")]
	public string Password { get; set; } = default!;
	[AliasAs("apikey")]
	public string ApiKeyName { get; set; } = default!;
}
