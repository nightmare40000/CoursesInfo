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
                              .ConnectionString(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\GitHub\CoursesInfo\CoursesInfoData.mdf;Integrated Security=True;Connect Timeout=30"))
                .Mappings(config => config.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()));
            _sessionFactory = _configuration.BuildSessionFactory();
        }

        public static ISession OpenSession()
        {
            return _sessionFactory.OpenSession();
        }
    }
}
