using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDUCFM.Models;

namespace TDUCFM.DataBase
{
    class TDUCFMDataContext : System.Data.Entity.DbContext
    {
        public TDUCFMDataContext() : base("TDUCFMConnectionString") { }
        public TDUCFMDataContext(string connectionString) : base(connectionString) { }
        public TDUCFMDataContext(DbConnection dbConnection) : base(dbConnection, true) { }

        public DbSet<File> Files { get; set; }
        public DbSet<Folder> Folders { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Department> Departments { get; set; }

        static DbConnection CreateConnection()
        {
            //var connection = DbProviderFactories.GetFactory("System.Data.SQLite.EF6").CreateConnection();
            var connection = DbProviderFactories.GetFactory("System.Data.SqlClient").CreateConnection();
            var connectionStringBuilder = new SqlConnectionStringBuilder
            {
                DataSource = "NSERVER2K8",
                InitialCatalog = "TDUCMS2",
                UserID = "sa",
                Password = "sasasa@123456"
            };
            connection.ConnectionString = connectionStringBuilder.ConnectionString;
            //MessageBox.Show(connection.ConnectionString);
            return connection;
        }
    }
}
