using HotelReservation.Data;
using HotelReservation.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;

namespace HotelReservation.ViewModel
{
    public class MapViewModel : ViewModelBase
    {
        private string _usrName;
        private string _htlName;
        private string _address;
        private string _myAddress;

        public string UserName
        {
            get
            {
                return _usrName;
            }
            set
            {
                _usrName = value;
                NotifyPropertyChanged();
            }
        }
        public string HotelName
        {
            get
            {
                return _htlName;
            }
            set
            {
                _htlName = value;
                NotifyPropertyChanged();
            }

        }
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
                NotifyPropertyChanged();
            }
        }


        public void getLocation()
        {
            string location = null;
            DatabaseHelperClass Db_helper = new DatabaseHelperClass();
            ObservableCollection<Hotel> listHotels = Db_helper.ReadAllHotels();
            foreach (Hotel hotel in listHotels)
            {
                if (HotelName.Equals(hotel.name))
                {
                    location = hotel.city + ", " + hotel.address;
                }
            }

            Address = location;
        }
    }
}
