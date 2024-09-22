using Refit;

namespace RideWithGps.Models;

public abstract class RequestBase
{
	[AliasAs("apikey")]
	public string ApiKey { get; set; } = default!;
	[AliasAs("version")]
	public int Version { get; set; } = 2;
	[AliasAs("auth_token")]
	public string AuthToken { get; set; } = default!;
}
