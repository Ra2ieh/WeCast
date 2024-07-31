
using WeCast.Infrastructure.Providers.Models;

namespace WeCast.Infrastructure.Providers;

    public class WeatherProvider:IWeatherProvider
    {
        public async Task<GetWeatherDetailResponse> GetWeatherDetail(CancellationToken cancellationToken)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://api.open-meteo.com/v1/forecast?latitude=52.52&longitude=13.41&hourly=temperature_2m&relativehumidity_2");
            var response = await client.SendAsync(request, cancellationToken);
            response.EnsureSuccessStatusCode();
           return JsonConvert.DeserializeObject<GetWeatherDetailResponse>(await response.Content.ReadAsStringAsync(cancellationToken)) ;
         
        }
    }

