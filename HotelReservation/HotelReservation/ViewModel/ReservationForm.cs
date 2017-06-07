using HotelReservation.Data;
using HotelReservation.Model;
using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.Storage;

namespace HotelReservation.ViewModel
{
    public class ReservationForm : ViewModelBase
    {
        private string _usrName;
        private string _fName;
        private string _lName;
        private string _htlName;
        private string _rmType;
        private DateTimeOffset _from;
        private DateTimeOffset _to;
        private int _rmCount;
        private ObservableCollection<string> _types;
        private string _error;
        private ICommand _btnReserve;
        private bool _canExecute;
        public static string DB_PATH = Path.Combine(Path.Combine(ApplicationData.Current.LocalFolder.Path, "db.sqlite"));

        #region errors
        const string datesPopulationError = "Dates are not accurately populated";
        const string noRoomsAvailableError = "No rooms available";
        const string noRoomsSelectedError = "Select more than 0 rooms!";
        #endregion

        #region getters and setters
        public string Error
        {
            get
            {
                return _error;
            }
            set
            {
                _error = value;
                NotifyPropertyChanged();
            }
        }
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
        public string FName
        {
            get
            {
                return _fName;
            }
            set
            {
                _fName = value;
                NotifyPropertyChanged();
            }
        }
        public string LName
        {
            get
            {
                return _lName;
            }
            set
            {
                _lName = value;
                NotifyPropertyChanged();
            }

        }
        public string HtlName
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
        public string RoomType
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
        public DateTimeOffset From
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
        public DateTimeOffset To
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

        public int RmCount
        {
            get
            {
                return _rmCount;
            }
            set
            {
                _rmCount = value;
                NotifyPropertyChanged();

            }
        }
        public ObservableCollection<string> Types
        {
            get
            {
                return _types;
            }
            set
            {
                _types = value;
                NotifyPropertyChanged();
            }
        }
        public ICommand BtnReserve
        {
            get
            {
                return _btnReserve ?? (_btnReserve = new DelegateCommand(() => saveToDb(), _canExecute));
            }
        }

        #endregion


        public void getUser()
        {

            DatabaseHelperClass Db_helper = new DatabaseHelperClass();
            ObservableCollection<Users> listUsr = Db_helper.ReadAllUsers();

            foreach (Users usr in listUsr)
            {

                if (UserName.Equals(usr.userName))
                {
                    FName = usr.fName;
                    LName = usr.lName;
                }
            }

        }

        public void getHotel()
        {
            DatabaseHelperClass Db_helper = new DatabaseHelperClass();
            ObservableCollection<Hotel> listHtl = Db_helper.ReadAllHotels();
            ObservableCollection<RoomType> listRmT = Db_helper.ReadAllRoomTypes();
            Types = new ObservableCollection<string>();

            foreach (Hotel hotel in listHtl)
            {
                if (HtlName.Equals(hotel.name))
                {
                    foreach (RoomType rmT in listRmT)
                    {
                        if (rmT.hotel_id == hotel.id)
                        {
                            RoomType = rmT.type;
                            Types.Add(RoomType);
                        }
                    }
                }
            }
        }

        public void getData()
        {
            getUser();
            getHotel();
        }

        public int getHtlId()
        {
            DatabaseHelperClass Db_helper = new DatabaseHelperClass();
            ObservableCollection<Hotel> listHtl = Db_helper.ReadAllHotels();
            int id = 0;
            foreach (Hotel hotel in listHtl)
            {
                if (HtlName.Equals(hotel.name))
                {
                    id = hotel.id;
                }
            }
            return id;

        }

        public int getRmId()
        {
            DatabaseHelperClass Db_helper = new DatabaseHelperClass();
            ObservableCollection<RoomType> listRmT = Db_helper.ReadAllRoomTypes();
            int htlId = getHtlId();
            int rmId = 0;
            foreach (RoomType rmT in listRmT)
            {
                if ((rmT.hotel_id == htlId) && (rmT.type.Equals(RoomType)))
                {
                    rmId = rmT.id;

                }
            }
            return rmId;
        }



        public int getUsrId()
        {
            DatabaseHelperClass Db_helper = new DatabaseHelperClass();
            ObservableCollection<Users> listUsr = Db_helper.ReadAllUsers();
            int user_id = 0;
            foreach (Users usr in listUsr)
            {
                if (UserName.Equals(usr.userName))
                {
                    user_id = usr.id;
                }
            }
            return user_id;
        }


        public Reservations reservation()
        {

            Reservations res = new Reservations();


            int remaingngCnt = getRemainingRmCnt();
            if (RmCount < remaingngCnt && RmCount > 0)
            {
                res.room_id = getRmId();
                res.user_id = getUsrId();
                if (From >= DateTime.Now && To > From)
                {
                    res.dateFrom = From;
                    res.dateTo = To;
                    Error = null;
                }
                else
                {
                    Error = datesPopulationError;
                }
                res.count = RmCount;

            }
            else if (RmCount > remaingngCnt)
            {
                Error = noRoomsAvailableError;
            }
            else if (RmCount <= 0)
            {
                Error = noRoomsSelectedError;
            }

            return res;
        }

        public void saveToDb()
        {
            Reservations reserve;
            reserve = reservation();
            DateTimeOffset fr = reserve.dateFrom;
            DateTimeOffset to = reserve.dateTo;
            int usrId = reserve.user_id;
            int rmId = reserve.room_id;
            int cnt = reserve.count;
            if (Error == null)
            {
                DatabaseHelperClass Db_helper = new DatabaseHelperClass();
                Db_helper.InsertReservation(new Reservations(fr, to, usrId, rmId, cnt));
            }
            else if (Error != null)
            {
                ReservationForm rf = new ReservationForm();
            }
        }
        public int countReservations()
        {
            int count = 0;
            DatabaseHelperClass Db_helper = new DatabaseHelperClass();
            ObservableCollection<Reservations> listReserv = Db_helper.ReadAllReservations();
            int rmId = getRmId();
            DateTimeOffset fr = From;
            DateTimeOffset to = To;

            foreach (Reservations r in listReserv)
            {
                if (r.room_id == rmId && ((r.dateFrom.Equals(fr)) ||
                    (r.dateFrom < fr && r.dateTo > fr) || (r.dateFrom < to && r.dateTo > to)))
                {
                    count++;
                }
            }
            return count;
        }

        public int getAllCnt()
        {
            DatabaseHelperClass Db_helper = new DatabaseHelperClass();
            ObservableCollection<RoomType> listRmT = Db_helper.ReadAllRoomTypes();
            int allRooms;
            int rmId = getRmId();
            RoomType room = new RoomType();
            foreach (RoomType rmT in listRmT)
            {
                if (rmT.id == rmId)
                {
                    room = rmT;
                }
            }
            allRooms = room.count;
            return allRooms;
        }

        public int getRemainingRmCnt()
        {
            int result;
            int allRm = getAllCnt();
            int currReserved = countReservations();
            result = allRm - currReserved;
            return result;
        }


        public ReservationForm()
        {
            _canExecute = true;

        }
    }
}

