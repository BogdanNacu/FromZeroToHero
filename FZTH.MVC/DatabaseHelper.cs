using FZTH.MVC.Entities;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate.Linq;

namespace FZTH.MVC
{
    public class DatabaseHelper
    {
        readonly ISession _session;
        public DatabaseHelper(ISession session)
        {
            _session = session;
        }

        public IList<Hotel> GetHotels()
        {
            return _session.Query<Hotel>().ToList();
        }
    }
}