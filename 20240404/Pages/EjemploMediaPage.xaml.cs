namespace _20240404.Pages;

public partial class EjemploMediaPage : ContentPage
{
	public EjemploMediaPage()
	{
		InitializeComponent();
	}
	public void OnPlayClic(object sender, EventArgs e) {
		if (video.CurrentState == CommunityToolkit.Maui.Core.Primitives.MediaElementState.Playing)
			video.Pause();
		else
			video.Play();

	}
}