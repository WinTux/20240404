﻿using _20240404.Pages;

namespace _20240404
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(reloj), typeof(reloj));
            Routing.RegisterRoute(nameof(EjemploQRPage), typeof(EjemploQRPage));
        }
    }
}
