using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication.Data {
    public static class ConnectionSettings {
        public static string DataSource, UserID, Password, InitialCatalog;
        public static string SelectQuery;
        public static void SetUp(string dataSource, string userId, string password, string initialCatalog) {
            DataSource = dataSource;
            UserID = userId;
            Password = password;
            InitialCatalog = initialCatalog;
        }
        public static string GetConnectionString() {
            var builder = new SqlConnectionStringBuilder();
            builder.DataSource = ConnectionSettings.DataSource;
            builder.UserID = ConnectionSettings.UserID;
            builder.Password = ConnectionSettings.Password;
            builder.InitialCatalog = ConnectionSettings.InitialCatalog;
            return builder.ConnectionString;
        } 
    }
}
