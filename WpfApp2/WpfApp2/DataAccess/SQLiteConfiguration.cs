using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite.EF6;
using System.Data.Entity.Migrations;
using System.Data.SQLite.EF6.Migrations;

namespace WpfApp2.DataAccess
{
    public class SQLiteConfiguration : DbMigrationsConfiguration<AppContex>
    {
        public SQLiteConfiguration()
        {
            SetSqlGenerator("System.Data.SQLite", new SQLiteMigrationSqlGenerator());
        }
    }
}
