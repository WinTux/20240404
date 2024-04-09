using System.Timers;

namespace _20240404.Pages;

public partial class reloj : ContentPage
{
	public reloj()
	{
		InitializeComponent();
        var temporizador = new System.Timers.Timer(1000);
        temporizador.Elapsed += new System.Timers.ElapsedEventHandler(RedibujarRelor);
        temporizador.Start();
    }
    private void RedibujarRelor(object? sender, ElapsedEventArgs e)
    {
        var graficosView = this.relojGraphicsView;
        graficosView.Invalidate();
    }
}