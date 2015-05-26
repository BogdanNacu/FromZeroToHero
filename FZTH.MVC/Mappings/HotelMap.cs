using FluentNHibernate.Mapping;
using FZTH.MVC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FZTH.MVC.Mappings
{
    public class HotelMap: ClassMap<Hotel>
    {
        public HotelMap()
        {
            Table("Hotels");
            Id(x => x.Id);
            Map(x => x.Name);
            References(x => x.Location).Column("LocationId");
        }
    }
}