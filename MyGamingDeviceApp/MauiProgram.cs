using IData;
using ILogic;
using Logic;
using Microsoft.Extensions.Logging;
using MyGaming_MySQL;

namespace MyGamingDeviceApp
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

#if DEBUG
    		builder.Logging.AddDebug();
            builder.Services.AddScoped<IGameLogic, MockingGameLogic>();
#endif

#if (!DEBUG)
            builder.Services.AddScoped<IGameLogic,GameLogic>();
            builder.Services.AddScoped<IGameData, MySQLDatabase>();
#endif



            return builder.Build();
        }
    }
}
