
using WeCast.Infrastructure.Providers.Models;

namespace WeCast.Application.Services;

public interface IWeatherService
{
    Task<GetWeatherDetailResponse> GetWeatherDetail();
}
