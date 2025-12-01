using Microsoft.Extensions.Logging;
using MyRestaurant_Data;
using MySQLDatabank;
using RestaurantLogicController;
using RestaurantLogicInterfaces;

namespace MyRestaurant_Device
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder.Services.AddScoped<IMenuLogic, MenuController>();
            builder.Services.AddScoped<IMenuData, Databank>();

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
