using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CoursesInfo.Data.Mappings;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace CoursesInfo.Data
{
    public class DataBaseConfig
    {
        private static FluentConfiguration _configuration;
        private static ISessionFactory _sessionFactory;

        public static void Config()
        {
            _configuration = Fluently
                .Configure()
                .Database(MsSqlConfiguration
                              .MsSql2008
                              .ConnectionString(x => x.FromConnectionStringWithKey("local")))
                .Mappings(config => config.FluentMappings.AddFromAssemblyOf<CompanyMap>());
            _sessionFactory = _configuration.BuildSessionFactory();
        }

        public static ISession OpenSession()
        {
            return _sessionFactory.OpenSession();
        }
    }
}
