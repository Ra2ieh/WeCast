


using WeCast.Infrastructure.Providers;
using WeCast.Infrastructure.Providers.Models;

namespace WeCast.Application.Services;

    public class WeatherService: IWeatherService
{
        private readonly IWeatherProvider _weatherProvider;

        public WeatherService(IWeatherProvider weatherProvider)
        {
            _weatherProvider = weatherProvider;
        }

        public async Task<GetWeatherDetailResponse> GetWeatherDetail()
        {

            using var cancellationToken = new CancellationTokenSource(TimeSpan.FromSeconds(5));
            var downloadTask =  _weatherProvider.GetWeatherDetail(cancellationToken.Token);
            var timeoutTask = Task.Delay(Timeout.InfiniteTimeSpan, cancellationToken.Token);
            var completedTask = await Task.WhenAny(downloadTask, timeoutTask);
            //if (completedTask == timeoutTask)
                //db
            return await downloadTask;
        }

    }


