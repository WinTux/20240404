using CommunityToolkit.Maui.Core;

namespace _20240404.Pages;

public partial class EjemploTrazos : ContentPage
{
	public EjemploTrazos()
	{
		InitializeComponent();
	}
	async void OnLineaDibujada(object sender, DrawingLineCompletedEventArgs e)
	{
		var stream = await lienzo.GetImageStream(200, 200);
		Dispatcher.Dispatch(() => {
			imagen.Source = ImageSource.FromStream(() => stream);
		});
	}
}