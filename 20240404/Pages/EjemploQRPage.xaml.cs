using ZXing.Net.Maui;

namespace _20240404.Pages;

public partial class EjemploQRPage : ContentPage
{
	public EjemploQRPage()
	{
		InitializeComponent();
        lectorCodigo.Options = new BarcodeReaderOptions() { 
            AutoRotate = true,
            Formats = BarcodeFormats.All,
            TryHarder = true,
            Multiple = false
        };

    }
    async void OnCodigoQRDetectado(object sender, BarcodeDetectionEventArgs e)
    {
        Dispatcher.Dispatch(() => {
            resultadoCodigo.Text = $"{e.Results[0].Value} ({e.Results[0].Format})";
        });
    }
}