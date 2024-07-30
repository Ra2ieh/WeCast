

namespace WeCast.Infrastructure;

public class InfrastructureServiceInstaller:IServiceInstaller
{
 public void InstallServices(IServiceCollection services, IConfiguration appSettings)
    {
        var optionBuilder=new DbContextOptionsBuilder();
        optionBuilder.LogTo(Console.WriteLine);
        services.AddHttpClient("deliveryTimeService", client =>
        {
            var baseUrl = appSettings.GetSection("AppConfig:GetDeliveryTimeConfig:BaseUrl").Value;
            client.BaseAddress = new Uri(baseUrl);
            client.Timeout = TimeSpan.FromSeconds(30);
        }
        );
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddDbContext<WeCastDbContext>(options =>
        options.UseSqlServer(appSettings.GetConnectionString("WeCastDbConectionString"))
        );
        
        appSettings.GetSection("AppConfig").Get<AppConfig>();
    }
}
