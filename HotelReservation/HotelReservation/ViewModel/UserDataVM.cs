using HotelReservation.Data;
using HotelReservation.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.ViewModel
{
    public class UserDataVM : ViewModelBase
    {
        private string _userName;
        private string _info;
        private ObservableCollection<Reservations> _reservations;
        private string _hotelName;
        private string _from;
        private string _to;
        private string _roomType;
        private ObservableCollection<string> _listRes;
        public string Info
        {
            get
            {
                return _info;
            }
            set
            {
                _info = value;
                NotifyPropertyChanged();
            }
        }

        public ObservableCollection<string> ListRes
        {
            get
            {
                return _listRes;
            }
            set
            {
                _listRes = value;
                NotifyPropertyChanged();
            }
        }


        public string RoomTyp
        {
            get
            {
                return _roomType;
            }
            set
            {
                _roomType = value;
                NotifyPropertyChanged();
            }
        }


        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
                NotifyPropertyChanged();
            }
        }

        public ObservableCollection<Reservations> Reservation
        {
            get
            {
                return _reservations;
            }
            set
            {
                _reservations = value;
                NotifyPropertyChanged();
            }
        }

        public string HotelName
        {
            get
            {
                return _hotelName;
            }
            set
            {
                _hotelName = value;
                NotifyPropertyChanged();
            }
        }

        public string From
        {
            get
            {
                return _from;
            }
            set
            {
                _from = value;
                NotifyPropertyChanged();
            }
        }

        public string To
        {
            get
            {
                return _to;
            }
            set
            {
                _to = value;
                NotifyPropertyChanged();
            }
        }

        public void getInfo()
        {
            ObservableCollection<int> hotelsId = getHotelId();
            DatabaseHelperClass Db_helper = new DatabaseHelperClass();
            ObservableCollection<Hotel> list = Db_helper.ReadAllHotels();
            ListRes = new ObservableCollection<string>();

            foreach (Hotel hotel in list)
            {
                foreach (int htl in hotelsId)
                {
                    if (htl == hotel.id)
                    {

                        HotelName = hotel.name;

                        Info = HotelName + ", " + RoomTyp + ", " + From + ", " + To;
                        ListRes.Add(Info);
                    }
                }
            }
        }

        public ObservableCollection<int> getHotelId()
        {
            ObservableCollection<int> hotelsId = new ObservableCollection<int>();
            ObservableCollection<int> roomsId = getReservations();
            DatabaseHelperClass Db_helper = new DatabaseHelperClass();
            ObservableCollection<RoomType> list = Db_helper.ReadAllRoomTypes();

            foreach (RoomType room in list)
            {
                foreach (int rm in roomsId)
                {
                    if (rm == (room.id))
                    {

                        RoomTyp = room.type;

                        hotelsId.Add(room.hotel_id);
                    }
                }
            }
            return hotelsId;
        }

        public ObservableCollection<int> getReservations()
        {
            DatabaseHelperClass Db_helper = new DatabaseHelperClass();
            Reservation = Db_helper.ReadAllReservations();
            ObservableCollection<int> roomsId = new ObservableCollection<int>();
            int usrId = getUserId();
            foreach (Reservations reservation in Reservation)
            {
                if (reservation.user_id == usrId)
                {

                    From = reservation.dateFrom.ToString("dd/MM/yyyy");
                    To = reservation.dateTo.ToString("dd/MM/yyyy");
                    roomsId.Add(reservation.room_id);
                }
            }
            return roomsId;
        }

        public int getUserId()
        {
            DatabaseHelperClass Db_helper = new DatabaseHelperClass();
            ObservableCollection<Users> list = Db_helper.ReadAllUsers();
            int usrId = 0;
            foreach (Users usr in list)
            {
                if (UserName.Equals(usr.userName))
                {
                    usrId = usr.id;
                }
            }
            return usrId;

        }

    }
}