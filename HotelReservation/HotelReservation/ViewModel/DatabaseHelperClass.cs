using HotelReservation.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Data
{
    public class DatabaseHelperClass
    {
        public void InsertUser(Users usr)
        {
            using (SQLite.Net.SQLiteConnection conn = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), App.DB_PATH))
            {
                conn.RunInTransaction(() =>
                {
                    conn.Insert(usr);
                });
            }
        }
        public void InsertReservation(Reservations reservation)
        {
            using (SQLite.Net.SQLiteConnection conn = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), App.DB_PATH))
            {
                conn.RunInTransaction(() =>
                {
                    conn.Insert(reservation);
                });
            }
        }

        public Users ReadUsers(int user_id)
        {
            using (SQLite.Net.SQLiteConnection conn = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), App.DB_PATH))
            {
                var existingusr = conn.Query<Users>("select * from Contacts where Id =" + user_id).FirstOrDefault();
                return existingusr;
            }
        }

        public ObservableCollection<Users> ReadAllUsers()
        {
            try
            {
                using (SQLite.Net.SQLiteConnection conn = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), App.DB_PATH))
                {
                    List<Users> myCollection = conn.Table<Users>().ToList<Users>();
                    ObservableCollection<Users> listUsers = new ObservableCollection<Users>(myCollection);
                    return listUsers;
                }
            }
            catch
            {
                return null;
            }

        }
       
        
        public ObservableCollection<Hotel> ReadAllHotels()
        {
            try
            {
                using (SQLite.Net.SQLiteConnection conn = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), App.DB_PATH))
                {
                    List<Hotel> myCollection = conn.Table<Hotel>().ToList<Hotel>();
                    ObservableCollection<Hotel> listRmT = new ObservableCollection<Hotel>(myCollection);
                    return listRmT;
                }
            }
            catch
            {
                return null;
            }

        }


        public ObservableCollection<RoomType> ReadAllRoomTypes()
        {
        try
        {
            using (SQLite.Net.SQLiteConnection conn = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), App.DB_PATH))
            {
                List<RoomType> myCollection = conn.Table<RoomType>().ToList<RoomType>();
                ObservableCollection<RoomType> listRmT = new ObservableCollection<RoomType>(myCollection);
                return listRmT;
            }
        }
        catch
        {
            return null;
        }

    }

        public ObservableCollection<Reservations> ReadAllReservations()
        {
            try
            {
                using (SQLite.Net.SQLiteConnection conn = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), App.DB_PATH))
                {
                    List<Reservations> myCollection = conn.Table<Reservations>().ToList<Reservations>();
                    ObservableCollection<Reservations> listReservations = new ObservableCollection<Reservations>(myCollection);
                    return listReservations;
                }
            }
            catch
            {
                return null;
            }

        }
    }

public class ReadAllUserList
    {
        DatabaseHelperClass Db_Helper = new DatabaseHelperClass();
        public ObservableCollection<Users> GetAllContacts()
        {
            return Db_Helper.ReadAllUsers();
        }

    }
}
