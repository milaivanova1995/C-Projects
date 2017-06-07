using HotelReservation.ViewModel;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace HotelReservation.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Catalog : Page
    {
        public Catalog()
        {

            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            string usrName = e.Parameter.ToString();
            var vm = new CatalogVM();
            vm.UserName = usrName;
            this.DataContext = vm;

        }

        private void btnShowHotel_Click(object sender, RoutedEventArgs e)
        {
            string[] parameters = new string[2];
            parameters[0] = usNm.Text;
            string selected = (string)listHotels.SelectedValue;
            parameters[1] = selected;

            if (selected != null)
            {
                Frame.Navigate(typeof(HotelOverview), parameters);
            }

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            string usrName = usNm.Text;
            Frame.Navigate(typeof(UserData), usrName);
        }

        private void btnSignOut_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(NavigationPage));
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            string usrName = usNm.Text;
            Frame.Navigate(typeof(UserData), usrName);
        }
    }
}
