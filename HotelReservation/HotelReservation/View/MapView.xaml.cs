using HotelReservation.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Services.Maps;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace HotelReservation.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MapView : Page
    {

        public MapView()
        {
            this.InitializeComponent();
        }
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {

            base.OnNavigatedTo(e);
            string[] parameters = new string[2];
            parameters = (string[])e.Parameter;
            var vm = new MapViewModel();
            vm.UserName = parameters[0];
            vm.HotelName = parameters[1];
            vm.getLocation();
            this.DataContext = vm;
            string address = getAddress();
            var results = await MapLocationFinder.FindLocationsAsync(address, null);
            double lat = 0.0;
            double lon = 0.0;
            if (results.Status == MapLocationFinderStatus.Success)
            {
                lat = results.Locations[0].Point.Position.Latitude;
                lon = results.Locations[0].Point.Position.Longitude;
            }
            BasicGeoposition position = new BasicGeoposition()
            {
                Latitude = lat,
                Longitude = lon


            };
            Geopoint gPoint = new Geopoint(position);
            MapIcon mapIcon1 = new MapIcon();
            mapIcon1.Location = gPoint;
            mapIcon1.NormalizedAnchorPoint = new Point(0.5, 1.0);
            mapIcon1.Title = "Your Hotel";
            mapIcon1.ZIndex = 0;

            // Add the MapIcon to the map.
            mapControl.MapElements.Add(mapIcon1);

            // Center the map over the POI.
            mapControl.Center = gPoint;
            mapControl.ZoomLevel = 14;
        }

        public string getAddress()
        {
            string adr;
            adr = address.Text;
            return adr;
        }





        private async void Directions_Click(object sender, RoutedEventArgs e)
        {
            Geopoint begin = null;
            Geopoint end = null;
            foreach (MapIcon item in mapControl.MapElements)
            {
                if (item.Title.Equals("You are here"))
                {
                    begin = item.Location;
                }
                else if (item.Title.Equals("Your Hotel"))
                {
                    end = item.Location;
                }

            }

            try
            {
                MapRouteFinderResult routeResult = await MapRouteFinder.GetDrivingRouteAsync(begin, end);

                if (routeResult.Status == MapRouteFinderStatus.Success)
                {
                    // Use the route to initialize a MapRouteView.
                    MapRouteView viewOfRoute = new MapRouteView(routeResult.Route);
                    viewOfRoute.RouteColor = Colors.Yellow;
                    viewOfRoute.OutlineColor = Colors.Black;

                    // Add the new MapRouteView to the Routes collection
                    // of the MapControl.
                    mapControl.Routes.Add(viewOfRoute);

                    // Fit the MapControl to the route.
                    await mapControl.TrySetViewBoundsAsync(
                          routeResult.Route.BoundingBox,
                          null,
                          Windows.UI.Xaml.Controls.Maps.MapAnimationKind.None);

                    System.Text.StringBuilder routeInfoKm = new System.Text.StringBuilder();
                    System.Text.StringBuilder routeInfoTime = new System.Text.StringBuilder();
                    routeInfoTime.Append("Total estimated time = ");
                    routeInfoTime.Append(routeResult.Route.EstimatedDuration.TotalMinutes.ToString());
                    routeInfoTime.Append("min");
                    routeInfoKm.Append("\nTotal length  = ");
                    routeInfoKm.Append((routeResult.Route.LengthInMeters / 1000).ToString());
                    routeInfoKm.Append("km");

                    infoKm.Text = routeInfoKm.ToString();
                    infoTime.Text = routeInfoTime.ToString();

                }
            }
            catch (NullReferenceException ex)
            {
                err.Text = "Your location must be set!";
            }

        }

        private async void btnMyLocation_Click(object sender, RoutedEventArgs e)
        {
            err.Text = "";
            var geoLocator = new Geolocator();
            geoLocator.DesiredAccuracy = PositionAccuracy.High;
            Geoposition pos = await geoLocator.GetGeopositionAsync();
            double latitude = pos.Coordinate.Point.Position.Latitude;
            double longitude = pos.Coordinate.Point.Position.Longitude;
            BasicGeoposition position = new BasicGeoposition()
            {
                Latitude = latitude,
                Longitude = longitude

            };
            Geopoint gPoint = new Geopoint(position);
            MapIcon mapIcon1 = new MapIcon();
            mapIcon1.Location = gPoint;
            mapIcon1.NormalizedAnchorPoint = new Point(0.5, 1.0);
            mapIcon1.Title = "You are here";
            mapIcon1.ZIndex = 0;

            // Add the MapIcon to the map.
            mapControl.MapElements.Add(mapIcon1);

            // Center the map over the POI.
            mapControl.Center = gPoint;
            mapControl.ZoomLevel = 14;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            string[] parameters = new string[2];
            parameters[0] = usrName.Text;
            parameters[1] = htlName.Text;
            Frame.Navigate(typeof(HotelOverview), parameters);
        }

        private void btnSignOut_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(NavigationPage));
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            string usName = usrName.Text;
            Frame.Navigate(typeof(UserData), usName);
        }
    }
}
