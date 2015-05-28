using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate.Linq;
using FZTH.MVC.Data;

namespace FZTH.MVC
{
    public class DatabaseHelper
    {
        readonly ISession _session;
        public DatabaseHelper(ISession session)
        {
            _session = session;
        }

        public IList<Entities.Hotel> GetHotels()
        {
            return _session.Query<Entities.Hotel>().ToList();
        }

        public static bool ContainsLocation(Entities.Location location)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var locationList = session.Get<Entities.Location>(location.Id);
                if (locationList != null) return true;
            }
            return false;
        }

        public static bool ContainsLocation(string city, string county)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var locationList = session.Query<Entities.Location>().ToList();
                var isPresent = locationList.FirstOrDefault(x=>(x.County == county) && (x.City == city));
                if (isPresent != null) return true;
            }
            return false;
        }

        public static Entities.Location GetLocation(string city, string county)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var locationList = session.Query<Entities.Location>().ToList();
                var location = locationList.FirstOrDefault(x => (x.County == county) && (x.City == city));
                return location;
            }
        }

        public static void UpdateHotel(int id, Hotel hotel)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var hotelToUpdate = session.Get<Entities.Hotel>(id);

                hotelToUpdate.Name = hotel.Name;

                hotelToUpdate.Location.City = hotel.City;
                hotelToUpdate.Location.County = hotel.Country;
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(hotelToUpdate);
                    transaction.Commit();
                }
            }
        }

    }
}