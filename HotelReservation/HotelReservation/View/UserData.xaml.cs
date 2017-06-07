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
    public sealed partial class UserData : Page
    {
        public UserData()
        {
            this.InitializeComponent();

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            string usrName = e.Parameter.ToString();
            var vm = new UserDataVM();
            vm.UserName = usrName;
            vm.getInfo();

            this.DataContext = vm;
        }

        private void btnCatalog_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Catalog), usrNm.Text);
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(NavigationPage), usrNm.Text);
        }

        private void btnSignOut_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(NavigationPage));
        }
    }

}
