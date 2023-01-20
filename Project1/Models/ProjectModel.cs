using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1.Models
{
    public class ProjectModel
    {
        public Nullable<int> ProjectID { get; set; }
        public string ProjectName { get; set; }
        public string TLName { get; set; }
        public Nullable<int> TeamSize { get; set; }
    }
}