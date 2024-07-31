using WeCast.Infrastructure.Providers.Models;

namespace WeCast.Infrastructure.Providers;

public interface IWeatherProvider
{
    Task<GetWeatherDetailResponse> GetWeatherDetail(CancellationToken cancellationToken);

}