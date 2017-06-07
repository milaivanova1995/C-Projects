using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Model
{
    public class Reservations
    {
        [PrimaryKey,AutoIncrement]
        public int id { get; set; }
        public DateTimeOffset dateFrom { get; set; }
        public DateTimeOffset dateTo { get; set; }
        public int user_id { get; set; }
        public int room_id { get; set; }
        public int count { get; set; }

        public Reservations() {
        }

        public Reservations(DateTimeOffset from, DateTimeOffset to, int userId, int roomId, int cnt)
        {
            dateFrom = from;
            dateTo = to;
            user_id = userId;
            room_id = roomId;
            count = cnt;
        }
     
    }
}
