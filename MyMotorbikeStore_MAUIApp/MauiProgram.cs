using Microsoft.Extensions.Logging;
using MyMotorbikeStore_Controllers;
using MyMotorbikeStore_Data;
using MyMotorbikeStore_MySQL;
using MyMotorbikeStore_Services;

namespace MyMotorbikeStore_MAUIApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder.Services.AddScoped<IMotorbikeService, MotorbikeController>();
            builder.Services.AddScoped<IMotorbikeData, MySQLDatabase>();

            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
