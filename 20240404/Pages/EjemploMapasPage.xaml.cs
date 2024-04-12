using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;

namespace _20240404.Pages;

public partial class EjemploMapasPage : ContentPage
{
	public EjemploMapasPage()
	{
		InitializeComponent();
		//mimapa.MapType = MapType.Satellite;

		/*
		Location location = new Location(-16.530285640094156, -68.10919085233874);
		MapSpan mapSpan = new MapSpan(location, 0.01,0.01);
		mimapa.MoveToRegion(mapSpan);
		*/
		mimapa.Pins.Add(new Pin { 
			Label = "Pepe está en la Plza. del Estudiante",
			Location = new Location(-16.504174184505843, -68.13107336639273)
		});
	}

	async void OnMapaClic(object sender, MapClickedEventArgs e) {
		Polygon recuadro = new Polygon {
			StrokeColor = Color.FromArgb("00AADD"),
			StrokeWidth = 5,
			FillColor = Color.FromArgb("8800AADD"),
			Geopath = {
                new Location(-16.500559307297205, -68.1329371437234),
                new Location(-16.50075809932703, -68.13271386457438),
                new Location(-16.5009622432373, -68.13298259697872),
                new Location(-16.500807797302556, -68.13311098248941)
            }
        };
		mimapa.MapElements.Add(recuadro);

		Polyline polyline = new Polyline { 
			StrokeColor = Colors.Salmon,
			StrokeWidth= 15,
			Geopath = { 
				new Location(-16.500918862473082, -68.1330551381708),
				new Location(-16.500249150697922, -68.13395984688296),
                new Location(-16.498538176803713, -68.13287260190653),
                new Location(-16.49765772543384, -68.1343297700241)
            }
		};

		mimapa.MapElements.Add(polyline);

		Circle c = new Circle { 
			Center = new Location(-16.50318350828534, -68.13298244196788),
			Radius = new Distance(100),
			StrokeColor = Color.FromRgba("#00FF00"),
			StrokeWidth = 6,
			FillColor = Color.FromRgba("#88FFBBAA")
		};
        mimapa.MapElements.Add(c);
		System.Diagnostics.Debug.WriteLine($"Evento clic en mapa: {e.Location.Latitude},{e.Location.Longitude}");
    }
}