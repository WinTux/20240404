using ZXing.Net.Maui;

namespace _20240404.Pages;

public partial class EjemploQRPage : ContentPage
{
	public EjemploQRPage()
	{
		InitializeComponent();
		

    }
    async void OnCodigoQRDetectado(object sender, BarcodeDetectionEventArgs e)
    {
        resultadoCodigo.Text = $"{e.Results[0].Value} ({e.Results[0].Format})";
    }
}