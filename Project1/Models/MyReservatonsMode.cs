using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1.Models
{
    public class MyReservatonsMode
    {
        public int Slno { get; set; }
        public string Hostel { get; set; }
        public Nullable<System.DateTime> Arrival { get; set; }
        public Nullable<System.DateTime> Departure { get; set; }
        public string Type { get; set; }
        public int Guests { get; set; }
        public Nullable<decimal> Price { get; set; }
    }
}