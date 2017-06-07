using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using HotelReservation.ViewModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace HotelReservation.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HotelOverview : Page
    {
        public HotelOverview()
        {

            this.InitializeComponent();

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            base.OnNavigatedTo(e);
            string[] parameters = new string[2];
            parameters = (string[])e.Parameter;
            var vm = new HotelOverviewVM();
            vm.UserName = parameters[0];
            vm.Name = parameters[1];
            vm.viewHoteInfo();
            this.DataContext = vm;


        }

        private void btnReserve_Click(object sender, RoutedEventArgs e)
        {
            string[] parameters = new string[2];
            parameters[0] = usrName.Text;
            parameters[1] = htlName.Text;
            Frame.Navigate(typeof(Reservation), parameters);
        }


        private void btnMap_Click(object sender, RoutedEventArgs e)
        {
            string[] parameters = new string[2];
            parameters[0] = usrName.Text;
            parameters[1] = htlName.Text;

            Frame.Navigate(typeof(MapView), parameters);
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            string usNm = usrName.Text;
            Frame.Navigate(typeof(Catalog), usNm);
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
