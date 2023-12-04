using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WeatherForecastApp.Manager.Contracts;
using WeatherForecastApp.Manager.Data;
using WeatherForecastApp.Manager.Services;
using WeatherForecastApp.Views;

namespace WeatherForecastApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
          

            Routing.RegisterRoute(nameof(WeatherDetails), typeof(WeatherDetails));

            builder.Services.AddDbContext<AppDbContext>();
            builder.Services.AddScoped<IWeatherForecast, WeatherForecast>();
            builder.Services.AddScoped<IMySavedLocationsService, MySavedLocationsService>();
#if DEBUG
            builder.Logging.AddDebug();
            #endif

            return builder.Build();
        }
    }
}
