﻿
namespace WeCast.Api
{
    public static class HostingExtensions
    {
        public static WebApplication ConfigureService(this WebApplicationBuilder builder)
        {

            // Add services to the container.
            builder.Services.AddMvc();
            builder.Services.AddApiVersioning();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WeCastWebAPI", Version = "v1" });
            });

            builder.Services.InstallServicesInAssemblies(builder.Configuration);
            return builder.Build();
        }
        public static WebApplication ConfigurePileLine(this WebApplication app)
        {
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.MapDefaultControllerRoute();
            app.UseAuthorization();

            app.MapRazorPages();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "WeCastWebAPI");
            });
            return app;
        }
    }
}
