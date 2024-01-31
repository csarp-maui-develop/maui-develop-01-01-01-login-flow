using Kreta.Maui.Pages;
using Kreta.Maui.Services;
using Microsoft.Extensions.Logging;

namespace Kreta.Maui
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
#endif
            builder.Services.AddTransient<AuthenticationService>();
            builder.Services.AddTransient<LoadingPage>();
            return builder.Build();
        }
    }
}
