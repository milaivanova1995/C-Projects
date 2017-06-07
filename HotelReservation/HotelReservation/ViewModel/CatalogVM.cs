
using HotelReservation.Data;
using HotelReservation.Model;
using SQLite.Net;
using SQLite.Net.Platform.WinRT;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.ViewModel
{
    public class CatalogVM : ViewModelBase
    {
        private ObservableCollection<string> _hotelNames;
        private string _username;
        private string _name;


        public ObservableCollection<string> HotelNames
        {
            get
            {
                return _hotelNames;
            }
            set
            {
                _hotelNames = value;
                NotifyPropertyChanged();
            }
        }

        public string UserName
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
                NotifyPropertyChanged();
            }
        }
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                NotifyPropertyChanged();
            }
        }

        public void SelectHotel()
        {

        }

        public CatalogVM()
        {
            DatabaseHelperClass Db_helper = new DatabaseHelperClass();
            ObservableCollection<Hotel> list = Db_helper.ReadAllHotels();
            HotelNames = new ObservableCollection<string>();
            foreach (Hotel item in list)
            {
                name = item.name;
                HotelNames.Add(name);
            }

        }

    }
}

