using IMovieLogic;
using Microsoft.Extensions.Logging;
using MovieLogic;
using MyMovieApp_Data;
using MyMovieApp_MySQL;

namespace MyMovieApp_Device
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.Services.AddScoped<IMovieController, MovieController>();
            builder.Services.AddScoped<IMovieData, MYSQLDatabase>();
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
