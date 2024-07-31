namespace WeCast.Infrastructure.Services.Models;

public class Hourly
{
    public List<string> Time { get; set; }
    [JsonProperty("Temperature2m")]
    public List<double> Temperature2M { get; set; }
}