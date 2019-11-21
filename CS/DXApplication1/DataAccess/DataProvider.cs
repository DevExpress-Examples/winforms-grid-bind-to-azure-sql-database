using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication.Data {
    public abstract class DataProvider<T> where T : class {
        public virtual async Task<T> GetDataAsync() {
            return await Task.FromResult(GetData());
        }
        public abstract T GetData();
    }
    public class DataTableProvider : DataProvider<DataTable> {
        DataTableProvider() { }
        static DataTableProvider instance;
        public static DataTableProvider Instance {
            get {
                if(instance == null)
                    instance = new DataTableProvider();
                return instance;
            }
        }
        public override DataTable GetData() {
            try {
                using(var connection = new SqlConnection(ConnectionSettings.GetConnectionString())) {
                    connection.Open();
                    using(SqlDataAdapter adapter = new SqlDataAdapter(ConnectionSettings.SelectQuery, connection)) {
                        var dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
            catch {
                return null;
            }
        }
    }
    public class SqlDataSourceProvider : DataProvider<SqlDataSource> {
        SqlDataSourceProvider() { }
        static SqlDataSourceProvider instance;
        public static SqlDataSourceProvider Instance {
            get {
                if(instance == null)
                    instance = new SqlDataSourceProvider();
                return instance;
            }
        }
        public override SqlDataSource GetData() {
            var source = CreateSqlDataSource();
            source.Fill();
            return source;
        }
        public async override Task<SqlDataSource> GetDataAsync() {
            var source = CreateSqlDataSource();
            await source.FillAsync();
            return source;
        }
        SqlDataSource CreateSqlDataSource() {
            MsSqlConnectionParameters connectionParameters = new MsSqlConnectionParameters(
               ConnectionSettings.DataSource, ConnectionSettings.InitialCatalog, ConnectionSettings.UserID, ConnectionSettings.Password, MsSqlAuthorizationType.SqlServer);
            SqlDataSource source = new SqlDataSource(connectionParameters);
            CustomSqlQuery query = new CustomSqlQuery();
            query.Name = "AzureQuery";
            query.Sql = ConnectionSettings.SelectQuery;
            source.Queries.Add(query);
            return source;
        }
    }
    public class EFDataProvider : DataProvider<List<Product>> {
        EFDataProvider() { }
        static EFDataProvider instance;
        public static EFDataProvider Instance {
            get {
                if(instance == null)
                    instance = new EFDataProvider();
                return instance;
            }
        }
        internal static void PreInitContext() {
            using(AdventureWorksLTContext context = new AdventureWorksLTContext()) {
                context.Products.Include("SalesOrderDetails");
            }
        }
        public override List<Product> GetData() {
            using(AdventureWorksLTContext context = new AdventureWorksLTContext())
                return context.Products.ToList();
        }
        public async override Task<List<Product>> GetDataAsync() {
            using(AdventureWorksLTContext context = new AdventureWorksLTContext()) {
                context.Configuration.LazyLoadingEnabled = false; 
                var list = await context.Products.Include("SalesOrderDetails").ToListAsync();
                return list;
            }
        }
    }
}
