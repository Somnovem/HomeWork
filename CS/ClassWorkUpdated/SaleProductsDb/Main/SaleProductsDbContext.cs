using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    internal class SaleProductsDbContext : IDisposable
    {
        public IDbConnection dbConnection;
        public SaleProductsDbContext(string connectionString)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();
        }
        public SaleProductsDbContext() : this(System.Configuration.ConfigurationManager.ConnectionStrings["SaleProductsDbConnection"].ConnectionString) { }

        public void Dispose()
        {
            dbConnection?.Close();
        }
    }
}
