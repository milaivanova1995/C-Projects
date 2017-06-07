using HotelReservation.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
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
    public sealed partial class Reservation : Page
    {
        public Reservation()
        {
            // this.DataContext = new ReservationForm();
            //from.Date = DateTimeOffset.Now;
            this.InitializeComponent();
            //from.Date = DateTimeOffset.Now;
            //  to.Date = DateTimeOffset.Now;
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            base.OnNavigatedTo(e);
            string[] parameters = new string[2];
            parameters = (string[])e.Parameter;
            var vm = new ReservationForm();
            vm.UserName = parameters[0];
            vm.HtlName = parameters[1];
            vm.getData();
            vm.From = DateTimeOffset.Now;
            vm.To = DateTimeOffset.Now;
            this.DataContext = vm;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string[] parameters = new string[2];
            parameters[0] = usrNm.Text;
            parameters[1] = htlName.Text;

            Frame.Navigate(typeof(HotelOverview), parameters);
        }

        private void btnSignOut_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(NavigationPage));
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            string usName = usrNm.Text;

            Frame.Navigate(typeof(UserData), usName);
        }

        private async void btnReserve_Click(object sender, RoutedEventArgs e)
        {
            await Task.Delay(1);
            if (err.Text == "")
            {
                Frame.Navigate(typeof(UserData), usrNm.Text);
            }

        }
    }
}
