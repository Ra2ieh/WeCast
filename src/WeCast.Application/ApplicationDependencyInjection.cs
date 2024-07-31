namespace WeCast.Application;

    public class ApplicationDependencyInjection: IServiceInstaller
    {

            public void InstallServices(IServiceCollection services, IConfiguration appSettings)
            {

                services.AddScoped<IWeatherService, WeatherService>();

            }
        
    }

