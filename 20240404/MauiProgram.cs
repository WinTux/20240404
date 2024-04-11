using _20240404.Pages;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using ZXing.Net.Maui;

namespace _20240404
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .UseMauiMaps()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            builder.UseMauiApp<App>().UseBarcodeReader()
                .ConfigureMauiHandlers(h => {
                    h.AddHandler(typeof(ZXing.Net.Maui.Controls.CameraBarcodeReaderView),
                        typeof(CameraBarcodeReaderViewHandler));
                    h.AddHandler(typeof(ZXing.Net.Maui.Controls.CameraView),
                        typeof(CameraViewHandler));
                    h.AddHandler(typeof(ZXing.Net.Maui.Controls.BarcodeGeneratorView),
                        typeof(BarcodeGeneratorViewHandler));
                });

            builder.Services.AddTransient<reloj>();
            builder.Services.AddTransient<EjemploQRPage>();
            builder.Services.AddTransient<EjemploTrazos>();
            builder.Services.AddTransient<EjemploMapasPage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
