using Microsoft.Extensions.Configuration;
using RideWithGps.Models;

var config = new ConfigurationBuilder()
    .AddUserSecrets("7ef8f582-67c4-4800-85c2-1150905bc0e6")
    .Build();

var client = new RideWithGps.Client();
var user = await client.GetUserAsync(new GetUserRequest
{
	Email = config["UserName"] ?? throw new Exception("UserName required"),
	Password = config["Password"] ?? throw new Exception("Password required"),
	ApiKeyName = "sample-key"
});

var rides = await client.GetTripsAsync(user.Id, new()
{    
    AuthToken = user.AuthToken,
    ApiKey = "sample-key",
	Offset = 0,
	Limit = 30
});

