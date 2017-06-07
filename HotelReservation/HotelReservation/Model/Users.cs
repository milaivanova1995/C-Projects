using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Model
{
   public class Users
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public string phone { get; set; }

        

        public Users() { }

        public Users( string usnm, string pass, string firstN,string lastN, string ph)
        {
            
            userName = usnm;
            password = pass;
            fName = firstN;
            lName = lastN;
            phone = ph;
        }
        
    }
}
