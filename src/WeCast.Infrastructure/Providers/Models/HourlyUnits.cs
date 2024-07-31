namespace WeCast.Infrastructure.Services.Models;

public class HourlyUnits
{
    public string Time { get; set; }
    [JsonProperty("Temperature2m")]
    public string Temperature2M { get; set; }
}