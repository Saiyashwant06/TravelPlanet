using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1.Models
{
    public class EmpModel
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string TLName { get; set; }
        public Nullable<int> DOJ { get; set; }
    }
}