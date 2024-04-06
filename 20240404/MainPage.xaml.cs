using System.Timers;

namespace _20240404
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
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

}
