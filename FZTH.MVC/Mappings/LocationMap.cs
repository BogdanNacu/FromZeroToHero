using FluentNHibernate.Mapping;
using FZTH.MVC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FZTH.MVC.Mappings
{
    public class LocationMap : ClassMap<Location>
    {
        public LocationMap()
        {
            Table("Locations");
            Id(x => x.Id);
            Map(x => x.City);
            Map(x => x.County);
            HasMany(x => x.Hotels).KeyColumn("LocationId");
        }
    }
}