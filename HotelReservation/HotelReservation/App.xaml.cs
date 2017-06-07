using HotelReservation.Model;
using Microsoft.Data.Sqlite;
using SQLite.Net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace HotelReservation
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App : Application
    {

        public static string DB_PATH = Path.Combine(Path.Combine(ApplicationData.Current.LocalFolder.Path, "db.sqlite"));
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
            this.Suspending += OnSuspending;
            if (!CheckFileExists("db.sqlite").Result)
            {
                using (var conn = new SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), DB_PATH))
                {
                    conn.CreateTable<Users>();
                    conn.CreateTable<Hotel>();
                    conn.CreateTable<Reservations>();
                    conn.CreateTable<RoomType>();
                    putData(conn);

                }
            }




        }


        public void putData(SQLiteConnection conn)
        {
            conn.Insert(new Hotel()
            {
                id = 1,
                name = "Troyan Plaza",
                city = "Troyan",
                address = "ul. P.R. Slavejkov 54",
                phone = "0885100006",
                stars = 4,
                picPath = "/Images/TroyanPlaza.jpg",
                description = " One of our bestsellers in Troyan!Located on the bank of the Beli Ossum River in the centre of Troyan, Troyan Plaza Hotel features a fitness and spa centre.It offers spacious rooms with free LAN access."
            });
            conn.Insert(new RoomType()
            {
                id = 1,
                type = "2 beds",
                price = 50.00,
                count = 20,
                hotel_id = 1
            });
            conn.Insert(new RoomType()
            {
                id = 2,
                type = "3 beds",
                price = 75.00,
                count = 15,
                hotel_id = 1
            });

            conn.Insert(new Hotel()
            {
                id = 2,
                name = "Vitosha",
                city = "Sofia",
                address = "Studentski Grad, Ulitsa Rosario 1",
                phone = "02 816 8888",
                stars = 4,
                picPath = "/Images/Vitosha.png",
                description = "The 4-star Vitosha Park Hotel is situated in a quiet neighbourhood near a park and has easy access to the centre of Sofia and the airport. The hotel features a conference centre, 2 restaurants, a lobby bar, a night bar with live music and a modern spa and wellness centre. "
            });
            conn.Insert(new RoomType()
            {
                id = 3,
                type = "2 beds",
                price = 60.00,
                count = 20,
                hotel_id = 2
            });
            conn.Insert(new RoomType()
            {
                id = 4,
                type = "3 beds",
                price = 90.00,
                count = 15,
                hotel_id = 2
            });

            conn.Insert(new Hotel()
            {
                id = 3,
                name = "Mars",
                city = "Troyan",
                address = " Ulitsa Hristo Botev 185",
                phone = "0878 613699",
                stars = 3,
                picPath = "/Images/Mars.jpg",
                description = "All rooms are fitted with a TV with cable channels.Each room comes with a private bathroom.For your comfort, you will find free toiletries and a hairdryer.Hotel Mars features free WiFi throughout the property."
            });
            conn.Insert(new RoomType()
            {
                id = 5,
                type = "2 beds",
                price = 40.00,
                count = 20,
                hotel_id = 3
            });
            conn.Insert(new RoomType()
            {
                id = 6,
                type = "3 beds",
                price = 60.00,
                count = 10,
                hotel_id = 3
            });
            conn.Insert(new Hotel()
            {
                id = 4,
                name = "Vega",
                city = "Sofia",
                address = "Boulevard G.M. Dimitrov 75",
                phone = "02 806 6000",
                stars = 4,
                picPath = "/Images/Vega.jpg",
                description = "Set a 10-minute drive from the centre of Sofia, hotel Vega offers free WiFi, free fitness centre and free parking. An on-site spa and wellness centre is available at a surcharge."
            });
            conn.Insert(new RoomType()
            {
                id = 7,
                type = "2 beds",
                price = 80.00,
                count = 20,
                hotel_id = 4
            });
            conn.Insert(new RoomType()
            {
                id = 8,
                type = "3 beds",
                price = 110.00,
                count = 10,
                hotel_id = 4
            });
            conn.Insert(new Hotel()
            {
                id = 5,
                name = "Sofia Plaza",
                city = "Sofia",
                address = "Boulevard Hristo Botev 154",
                phone = "02 813 7912",
                stars = 4,
                picPath = "/Images/SofiaPlaza.jpg",
                description = "Sofia Plaza hotel is situated close to the central bus and train stations. Its location provides easy access to the city centre, where offices of numerous administrative and financial institutions, as well as tourist sights and shopping venues can be found. "
            });
            conn.Insert(new RoomType()
            {
                id = 9,
                type = "2 beds",
                price = 60.00,
                count = 20,
                hotel_id = 5
            });
            conn.Insert(new RoomType()
            {
                id = 10,
                type = "3 beds",
                price = 80.00,
                count = 10,
                hotel_id = 5
            });
            conn.Insert(new Hotel()
            {
                id = 6,
                name = "City Sofia",
                city = "Sofia",
                address = "1000, Ulitsa Stara Planina 6",
                phone = "02 915 1500",
                stars = 4,
                picPath = "/Images/CityHotel.jpg",
                description = "Located only 200 m from the Alexander Nevsky Cathedral and the Parliament in Sofia, BW Premier Collection City Hotel offers rooms with free Wi-Fi internet access. All interiors are strictly non-smoking."
            });
            conn.Insert(new RoomType()
            {
                id = 11,
                type = "2 beds",
                price = 60.00,
                count = 20,
                hotel_id = 6
            });
            conn.Insert(new RoomType()
            {
                id = 12,
                type = "3 beds",
                price = 80.00,
                count = 10,
                hotel_id = 6
            });
            conn.Insert(new Hotel()
            {
                id = 7,
                name = "Vereya",
                city = "Stara Zagora",
                address = "bul. Tsar Simeon Veliki 100",
                phone = "088 730 9060",
                stars = 4,
                picPath = "/Images/Vereya.jpg",
                description = "This stylishly decorated hotel is a part of the Complex Vereya and is located in the centre of Stara Zagora. It houses a fitness centre, 3 casinos and 2 restaurants. A beauty shop and a lobby bar with free Wi-Fi can also be found on site."
            });
            conn.Insert(new RoomType()
            {
                id = 13,
                type = "2 beds",
                price = 70.00,
                count = 20,
                hotel_id = 7
            });
            conn.Insert(new RoomType()
            {
                id = 14,
                type = "3 beds",
                price = 90.00,
                count = 10,
                hotel_id = 7
            });

            conn.Insert(new Hotel()
            {
                id = 8,
                name = "Marinela",
                city = "Sofia",
                address = "Bulevard Dzheyms Bauchar 100",
                phone = "02 969 2222",
                stars = 5,
                picPath = "/Images/Marinela.jpg",
                description = "Set а 20 - minute drive from Sofia Airport,the newly redesigned Hotel Marinela Sofia features an indoor pool, 6 restaurants, 4 bars, a fitness club, and scenic city and mountain views.The unique Japanese Garden is suitable for relaxation or brain storming sessions."
            });

            conn.Insert(new RoomType()
            {
                id = 15,
                type = "2 beds",
                price = 50.00,
                count = 20,
                hotel_id = 8
            });
            conn.Insert(new RoomType()
            {
                id = 16,
                type = "3 beds",
                price = 75.00,
                count = 10,
                hotel_id = 8
            });
            conn.Insert(new Hotel()
            {
                id = 9,
                name = "Ramada",
                city = "Sofia",
                address = "1202, Bulevard Knyaginya Maria Luiza 131",
                phone = "02 933 8888",
                stars = 4,
                picPath = "/Images/Ramada.jpg",
                description = "The Ramada Sofia is situated within walking distance to tourist sights and commercial areas of the city, offering comfortable rooms in a modern building. Free WiFi is available in all areas."
            });
            conn.Insert(new RoomType()
            {
                id = 17,
                type = "2 beds",
                price = 70.00,
                count = 20,
                hotel_id = 9
            });
            conn.Insert(new RoomType()
            {
                id = 18,
                type = "3 beds",
                price = 100.00,
                count = 10,
                hotel_id = 9
            });

            conn.Insert(new Hotel()
            {
                id = 10,
                name = "Hill",
                city = "Sofia",
                address = "Bulevard Dzheyms Bauchar 76",
                phone = "02 806 5555",
                stars = 4,
                picPath = "/Images/Hill.jpg",
                description = "Enjoying a magnificent location on the highest hill of Sofia, the 4-star Hill Hotel boasts wonderful views of the city centre and the Vitosha Mountain. The National Palace of Culture and the City Center Mall are a 10-minute walk away."
            });
            conn.Insert(new RoomType()
            {
                id = 19,
                type = "2 beds",
                price = 80.00,
                count = 20,
                hotel_id = 10
            });
            conn.Insert(new RoomType()
            {
                id = 20,
                type = "3 beds",
                price = 100.00,
                count = 10,
                hotel_id = 10
            });

            conn.Insert(new Hotel()
            {
                id = 11,
                name = "Hilton",
                city = "Sofia",
                address = "Boulevard Bulgaria 1",
                phone = "02 933 5000",
                stars = 5,
                picPath = "/Images/Hilton.jpg",
                description = "Opposite the National Palace of Culture and within 10 minutes on foot from the very heart of the city, Hilton Sofia is surrounded by the South Park and overlooks Vitosha Mountain. Free bicycle rental is provided from April until October."
            });

            conn.Insert(new RoomType()
            {
                id = 21,
                type = "2 beds",
                price = 90.00,
                count = 20,
                hotel_id = 11
            });
            conn.Insert(new RoomType()
            {
                id = 22,
                type = "3 beds",
                price = 120.00,
                count = 10,
                hotel_id = 11
            });


        }

        private async Task<bool> CheckFileExists(string fileName)
        {
            try
            {
                var store = await Windows.Storage.ApplicationData.Current.LocalFolder.GetFileAsync(fileName);
                return true;
            }
            catch
            {
            }
            return false;
        }
        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used such as when the application is launched to open a specific file.
        /// </summary>
        /// <param name="e">Details about the launch request and process.</param>
        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;

            // Do not repeat app initialization when the Window already has content,
            // just ensure that the window is active
            if (rootFrame == null)
            {
                // Create a Frame to act as the navigation context and navigate to the first page
                rootFrame = new Frame();

                rootFrame.NavigationFailed += OnNavigationFailed;

                if (e.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                    //TODO: Load state from previously suspended application
                }

                // Place the frame in the current Window
                Window.Current.Content = rootFrame;
            }

            if (e.PrelaunchActivated == false)
            {
                if (rootFrame.Content == null)
                {
                    // When the navigation stack isn't restored navigate to the first page,
                    // configuring the new page by passing required information as a navigation
                    // parameter
                    rootFrame.Navigate(typeof(View.NavigationPage), e.Arguments);
                }
                // Ensure the current window is active
                Window.Current.Activate();
            }
        }

        /// <summary>
        /// Invoked when Navigation to a certain page fails
        /// </summary>
        /// <param name="sender">The Frame which failed navigation</param>
        /// <param name="e">Details about the navigation failure</param>
        void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }

        /// <summary>
        /// Invoked when application execution is being suspended.  Application state is saved
        /// without knowing whether the application will be terminated or resumed with the contents
        /// of memory still intact.
        /// </summary>
        /// <param name="sender">The source of the suspend request.</param>
        /// <param name="e">Details about the suspend request.</param>
        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            //TODO: Save application state and stop any background activity
            deferral.Complete();
        }
    }
}
