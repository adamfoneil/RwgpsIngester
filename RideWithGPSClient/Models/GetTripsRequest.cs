using Refit;

namespace RideWithGps.Models;

public class GetTripsRequest : RequestBase
{
	[AliasAs("offset")]
	public int Offset { get; set; }
	[AliasAs("limit")]
	public int Limit { get; set; }
}
