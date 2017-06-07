using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Model
{
    public class Hotel
    {
        [PrimaryKey] 
        public int id { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public byte stars { get; set; }
        public string picPath { get; set; }
        public string description { get; set; }


        public Hotel() { }
    }


}
