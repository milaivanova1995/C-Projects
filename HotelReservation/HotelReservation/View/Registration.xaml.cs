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
using SQLite.Net.Attributes;
using HotelReservation.Data;
using Windows.UI.Popups;
using System.Threading.Tasks;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace HotelReservation.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Registration : Page
    {


        public Registration()
        {
            DataContext = new ConnectToUsers();
            this.InitializeComponent();


        }



        private async void btnAdd_Click(object sender, RoutedEventArgs e)
        {

            await Task.Delay(1);
            if (txtErr.Text == "")
            {
                Frame.Navigate(typeof(NavigationPage));
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(NavigationPage));
        }
    }


}
