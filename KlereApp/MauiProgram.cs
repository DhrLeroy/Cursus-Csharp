using KlereApp_Data;
using KlereApp_MySQL;
using KlereAppImplementations;
using KlereAppInterfaces;
using Microsoft.Extensions.Logging;

namespace KlereApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder.Services.AddScoped<IKledijLogic, KledijController>();
            builder.Services.AddScoped<IKledijData, MySQLDatabank>();

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
