using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
namespace maps
{
    public partial class mapsPage : ContentPage
    {
        public mapsPage()
        {
            InitializeComponent();
            PopulatePicker();
			var initialMapLocation = MapSpan.FromCenterAndRadius
											(new Position(33.1307785, -117.1601826)
											 , Distance.FromMiles(1));

			MyMap.MoveToRegion(initialMapLocation);
            PlaceAMarker();
            PlaceAMarker1();
            PlaceAMarker2();
            PlaceAMarker3();
            PlaceAMarker4();
            PlaceAMarker5();
        }
        private void PopulatePicker()
        {
            Dictionary<string, MapType> nameToMap = new Dictionary<string, MapType>
            {
                {"Street View", MapType.Street},
                {"Hybrid View", MapType.Hybrid},
                {"Satellite", MapType.Satellite}
            };
            foreach(var item in nameToMap)
            {
                PMap.Items.Add(item.Key);
            }
            PMap.SelectedIndex = 1;

        }
		private void PlaceAMarker()
		{
			var position = new Position(33.1372026, -117.2010273); // Latitude, Longitude
			var pin = new Pin
			{
				Type = PinType.Place,
				Position = position,
				Label = "Panda Express",
				Address = "670 W. San Marcos Boulevard, San Marcos, CA 92069"
			};

			
            MyMap.Pins.Add(pin);
           

		}
		private void PlaceAMarker1()
		{
			var position = new Position(33.1205808, -117.2255772); // Latitude, Longitude
			var pin = new Pin
			{
				Type = PinType.Place,
				Position = position,
				Label = "Best Buy",
				Address = "567 Grand Ave, San Marcos, CA 92078"


                    
			};


			MyMap.Pins.Add(pin);


		}
		private void PlaceAMarker2()
		{
			var position = new Position(33.1350034, -117.1949602); // Latitude, Longitude
			var pin = new Pin
			{
				Type = PinType.Place,
				Position = position,
				Label = "Edward Cinema 18",
				Address = "1180 W San Marcos Blvd, San Marcos, CA 92069"
			};


			MyMap.Pins.Add(pin);


		}
		private void PlaceAMarker3()
		{
			var position = new Position(33.1307785, -117.1601826); // Latitude, Longitude
			var pin = new Pin
			{
				Type = PinType.Place,
				Position = position,
				Label = "Cal State San Marcos",
				Address = "333 S. Twin Oaks Valley Rd, San Marcos, CA 92096"
			};


			MyMap.Pins.Add(pin);


		}
		private void PlaceAMarker4()
		{
			var position = new Position(33.1494858, -117.1861202); // Latitude, Longitude
			var pin = new Pin
			{
				Type = PinType.Place,
				Position = position,
				Label = "Palomar College",
				Address = "1140 W Mission Rd, San Marcos, CA 92069"
			};


			MyMap.Pins.Add(pin);


		}
		private void PlaceAMarker5()
		{
			var position = new Position(33.1372039, -117.1857065); // Latitude, Longitude
			var pin = new Pin
			{
				Type = PinType.Place,
				Position = position,
				Label = "Fry's Electronics",
				Address = "150 S Bent Ave, San Marcos, CA 92069"
			};


			MyMap.Pins.Add(pin);


		}
        void Handle_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var mapType = (MapType)PMap.SelectedIndex;
            if(PMap.SelectedIndex == 0)
            {
                MyMap.MapType = MapType.Street;
            }
			if (PMap.SelectedIndex == 1)
			{
                MyMap.MapType = MapType.Hybrid;
			}
			if (PMap.SelectedIndex == 2)
			{
                MyMap.MapType = MapType.Satellite;
			}
        }
    }
}
