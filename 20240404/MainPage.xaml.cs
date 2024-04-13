using _20240404.Pages;
using System.Timers;

namespace _20240404
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            
        }

        async void Onejemplo1Clicked(object sender, EventArgs e)
        {
            // Al darle clic se espera que se llame a la page reoloj correspondiente
            await Shell.Current.GoToAsync(nameof(reloj));
        }
        async void Onejemplo2Clicked(object sender, EventArgs e)
        {
            // Al darle clic se espera que se llame a la page reoloj correspondiente
            await Shell.Current.GoToAsync(nameof(EjemploQRPage));
        }
        async void Onejemplo3Clicked(object sender, EventArgs e)
        {
            // Al darle clic se espera que se llame a la page reoloj correspondiente
            await Shell.Current.GoToAsync(nameof(EjemploTrazos));
        }
        async void Onejemplo4Clicked(object sender, EventArgs e)
        {
            // Al darle clic se espera que se llame a la page reoloj correspondiente
            await Shell.Current.GoToAsync(nameof(EjemploMapasPage));
        }
        async void Onejemplo5Clicked(object sender, EventArgs e)
        {
            // Al darle clic se espera que se llame a la page reoloj correspondiente
            await Shell.Current.GoToAsync(nameof(EjemploMediaPage));
        }
    }

}
