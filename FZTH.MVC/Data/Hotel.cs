using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FZTH.MVC.Data
{
    public class Hotel
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String Country { get; set; }
        public String City { get; set; }
        public Int32 Rating { get; set; }
    }
}