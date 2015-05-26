using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FZTH.MVC.Mappings;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FZTH.MVC
{
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;
        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                    InitializeSessionFactory();
                return _sessionFactory;
            }
        }
        public static void InitializeSessionFactory()
        {
            _sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008
                             .ConnectionString(c => c.Server("localhost").Database("Booking").Username("sa").Password("1234%asd")))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<HotelMap>())
               .BuildSessionFactory()
           ;
        }
        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
        public static void CloseSesion()
        {

            SessionFactory.Dispose();
        }
    }
}