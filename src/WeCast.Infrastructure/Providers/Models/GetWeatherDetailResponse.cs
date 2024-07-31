namespace WeCast.Infrastructure.Providers.Models;

public class GetWeatherDetailResponse
{
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public double GenerationtimeMs { get; set; }
    public int UtcOffsetSeconds { get; set; }
    public string Timezone { get; set; }
    public string TimezoneAbbreviation { get; set; }
    public int Elevation { get; set; }
    public HourlyUnits HourlyUnits { get; set; }
    public Hourly Hourly { get; set; }
}