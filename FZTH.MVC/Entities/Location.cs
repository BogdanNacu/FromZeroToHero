using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FZTH.MVC.Entities
{
    public class Location
    {
        public virtual int Id { get; set; }
        public virtual string City { get; set; }
        public virtual string County { get; set; }

        public virtual IList<Hotel> Hotels { get; set; }
    }
}