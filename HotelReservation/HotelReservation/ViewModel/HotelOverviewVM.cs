using HotelReservation.Data;
using HotelReservation.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HotelReservation.ViewModel
{
    public class HotelOverviewVM : ViewModelBase
    {
        private string _username;
        private string _name;
        private string _city;
        private string _address;
        private string _phone;
        private string _stars;
        private string _picPath;
        private string _description;
        private string _rmType;
        private String _price;
        private ObservableCollection<string> _listTypes;
        private ObservableCollection<string> _listPrices;




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
        public string Name
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
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
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
        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                _phone = value;
                NotifyPropertyChanged();
            }
        }
        public string Stars
        {
            get
            {
                return _stars;
            }
            set
            {
                _stars = value;
                NotifyPropertyChanged();
            }
        }
        public string PicPath
        {
            get
            {
                return _picPath;
            }
            set
            {
                _picPath = value;
                NotifyPropertyChanged();
            }

        }
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                NotifyPropertyChanged();
            }
        }

        public string RmType
        {
            get
            {
                return _rmType;
            }
            set
            {
                _rmType = value;
                NotifyPropertyChanged();
            }

        }
        public string Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
                NotifyPropertyChanged();
            }

        }
        public ObservableCollection<string> ListTypes
        {
            get
            {
                return _listTypes;
            }
            set
            {
                _listTypes = value;
                NotifyPropertyChanged();
            }
        }

        public ObservableCollection<string> ListPrices
        {
            get
            {
                return _listPrices;
            }
            set
            {
                _listPrices = value;
                NotifyPropertyChanged();
            }
        }

        public void setStar(int num)
        {
            if (num == 1)
            {
                Stars = "★";
            }
            else if (num == 2)
            {
                Stars = "★★";
            }
            else if (num == 3)
            {
                Stars = "★★★";
            }
            else if (num == 4)
            {
                Stars = "★★★★";
            }
            else if (num == 5)
            {
                Stars = "★★★★★";
            }
        }
        public void viewHoteInfo()
        {
            DatabaseHelperClass Db_helper = new DatabaseHelperClass();
            ObservableCollection<Hotel> listHotels = Db_helper.ReadAllHotels();
            ObservableCollection<RoomType> listRmTypes = Db_helper.ReadAllRoomTypes();
            ListTypes = new ObservableCollection<string>();
            ListPrices = new ObservableCollection<string>();
            int num = 0;
            int hotelId = getHotelId();

            foreach (Hotel item in listHotels)
            {
                if (item.id == hotelId)
                {
                    Name = item.name;
                    City = item.city;
                    Address = item.address;
                    Phone = item.phone;
                    num = item.stars;
                    setStar(num);
                    PicPath = item.picPath;
                    Description = item.description;

                    foreach (RoomType rmTyp in listRmTypes)
                    {
                        if (rmTyp.hotel_id == item.id)
                        {
                            RmType = rmTyp.type;
                            Price = rmTyp.price + " lv.";
                            ListPrices.Add(Price);
                            ListTypes.Add(RmType);

                        }
                    }
                }

            }

        }
        public int getHotelId()
        {
            DatabaseHelperClass Db_helper = new DatabaseHelperClass();
            ObservableCollection<Hotel> list = Db_helper.ReadAllHotels();
            int htlId = 0;
            string n = this.Name;
            foreach (Hotel htl in list)
            {
                if (n.Equals(htl.name))
                {
                    htlId = htl.id;
                }
            }
            return htlId;

        }

    }
}
