using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Model
{
   
    public class RoomType {
    [PrimaryKey]
    public int id { get; set; }
    public string type { get; set; }
    public double price { get; set; }
    public int count { get; set; }
    public int hotel_id { get; set; }    

   

    public RoomType() { }
}
    
}
