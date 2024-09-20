using Microsoft.Extensions.Configuration;

var config = new ConfigurationBuilder()
    .AddUserSecrets("7ef8f582-67c4-4800-85c2-1150905bc0e6")
    .Build();

var http = new HttpClient()
{ 
    BaseAddress = new Uri("https://ridewithgps.com"),    
};

var apiKey = config["ApiKey"];
var userId = int.Parse(config["UserId"] ?? "0");
http.DefaultRequestHeaders.Add("x-rwgps-api-key", apiKey);
http.DefaultRequestHeaders.Add("x-rwgps-api-version", "3");
http.DefaultRequestHeaders.Add("accept", "application/json");
http.DefaultRequestHeaders.Add("user-agent", "adamo console app");

Dictionary<string, object> requestParams = new()
{
    ["models"] = "trips",
    ["route_fields"] = "id,name,location,visibility,first_lat,first_lng,distance,elevation_gain,elevation_loss,surface_type,has_cuesheet,sw_lat,sw_lng,ne_lat,ne_lng,pinned,highlighted_photo_id,created_at,updated_at",
    ["sort_by"] = "departed_or_created DESC",
    ["trip_fields"] = "id,location,visibility,first_lat,first_lng,is_gps,distance,moving_time,elevation_gain,avg_speed,avg_watts,avg_watts_estimated,sw_lat,sw_lng,ne_lat,ne_lng,pinned,highlighted_photo_id,departed_at,created_at,updated_at",
    ["user_id"] = userId
};

var response = await http.GetAsync($"/explore/personal.json?{ToQueryString(requestParams)}");
//var response = await http.GetAsync("https://ridewithgps.com/explore/personal.json?models=trips&route_fields=id%2Cname%2Clocation%2Cvisibility%2Cfirst_lat%2Cfirst_lng%2Cdistance%2Celevation_gain%2Celevation_loss%2Csurface_type%2Chas_cuesheet%2Csw_lat%2Csw_lng%2Cne_lat%2Cne_lng%2Cpinned%2Chighlighted_photo_id%2Ccreated_at%2Cupdated_at&sort_by=departed_or_created%20DESC&trip_fields=id%2Cname%2Clocation%2Cvisibility%2Cfirst_lat%2Cfirst_lng%2Cis_gps%2Cdistance%2Cmoving_time%2Celevation_gain%2Cavg_speed%2Cavg_watts%2Cavg_watts_estimated%2Csw_lat%2Csw_lng%2Cne_lat%2Cne_lng%2Cpinned%2Chighlighted_photo_id%2Cdeparted_at%2Ccreated_at%2Cupdated_at&user_id=132441");
response.EnsureSuccessStatusCode(); // keep getting 404
var content = await response.Content.ReadAsStringAsync();
Console.WriteLine(content);

/*
 * fetch("https://ridewithgps.com/explore/personal.json?models=trips&route_fields=id%2Cname%2Clocation%2Cvisibility%2Cfirst_lat%2Cfirst_lng%2Cdistance%2Celevation_gain%2Celevation_loss%2Csurface_type%2Chas_cuesheet%2Csw_lat%2Csw_lng%2Cne_lat%2Cne_lng%2Cpinned%2Chighlighted_photo_id%2Ccreated_at%2Cupdated_at&sort_by=departed_or_created%20DESC&trip_fields=id%2Cname%2Clocation%2Cvisibility%2Cfirst_lat%2Cfirst_lng%2Cis_gps%2Cdistance%2Cmoving_time%2Celevation_gain%2Cavg_speed%2Cavg_watts%2Cavg_watts_estimated%2Csw_lat%2Csw_lng%2Cne_lat%2Cne_lng%2Cpinned%2Chighlighted_photo_id%2Cdeparted_at%2Ccreated_at%2Cupdated_at&user_id=132441", {
  "headers": {
    "accept": "application/json",
    "accept-language": "en-US,en;q=0.9",
    "content-type": "application/json",
    "if-none-match": "W/\"853c18b25143a8d4cc9ca5dd9dd7809a\"",
    "priority": "u=1, i",
    "sec-ch-ua": "\"Chromium\";v=\"128\", \"Not;A=Brand\";v=\"24\", \"Microsoft Edge\";v=\"128\"",
    "sec-ch-ua-mobile": "?0",
    "sec-ch-ua-platform": "\"Windows\"",
    "sec-fetch-dest": "empty",
    "sec-fetch-mode": "cors",
    "sec-fetch-site": "same-origin",
    "x-rwgps-api-key": "RWGPS_API_KEY_FIXME",
    "x-rwgps-api-version": "3"
  },
  "referrer": "https://ridewithgps.com/rides",
  "referrerPolicy": "strict-origin-when-cross-origin",
  "body": null,
  "method": "GET",
  "mode": "cors",
  "credentials": "include"
});
*/

static string ToQueryString(Dictionary<string, object> dictionary) => 
    dictionary.Where(kp => kp.Value is not null)
    .Select(kp => $"{Uri.EscapeDataString(kp.Key)}={Uri.EscapeDataString(kp.Value.ToString()!)}")
    .Aggregate((key, val) => $"{key}&{val}");