using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Cfg;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Tool.hbm2ddl;
using NHibernate.Driver;
using User.Infrastructure.Mappings;

namespace User.Infrastructure
{
    public static class NHibernateSessionFactory
    {
        private static ISessionFactory session;

        private static ISessionFactory CreateSession()
        {
            const string connectionString = "Server=localhost;Database=contatos;User ID=sa;Password=root;Trusted_Connection=False; TrustServerCertificate=True;";

            if (session != null)
            {
                return session;
            }
            var sqlConfiguration = MsSqlConfiguration.MsSql2012.ShowSql().Driver<MicrosoftDataSqlClientDriver>().ConnectionString(connectionString);

            return Fluently.Configure()
                .Database(sqlConfiguration)
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<UserMapping>())
                .ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(true, true))
                .BuildSessionFactory();
        }
        public static ISession OpenSession()
        {
            return CreateSession().OpenSession();
        }
    }
}
