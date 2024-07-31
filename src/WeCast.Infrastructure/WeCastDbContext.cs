using WeCast.Domain.Entities;
using Hourly = WeCast.Infrastructure.Services.Models.Hourly;
using HourlyUnits = WeCast.Infrastructure.Services.Models.HourlyUnits;

namespace WeCast.Infrastructure;

public class WeCastDbContext : DbContext
{
    #region constructor
    public WeCastDbContext(DbContextOptions<WeCastDbContext> options) : base(options)
    {

    }

    #endregion
    public DbSet<WeatherData> WeatherData { get; set; }
    public DbSet<HourlyUnit> HourlyUnits { get; set; }
    public DbSet<HourlyData> Hourly { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<WeatherData>()
            .OwnsOne(w => w.HourlyUnits);

        modelBuilder.Entity<HourlyData>()
            .HasOne(h => h.WeatherData)
            .WithMany(w => w.Hourly)
            .HasForeignKey(h => h.WeatherDataId);

    }
}
