using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
namespace Ado2_1
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            //string connStr = ConfigurationManager.ConnectionStrings["ConnectionString1"].ConnectionString;
            
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder(ConfigurationManager.ConnectionStrings["ConnectionString1"].ConnectionString);
            SqlConnection conn = new SqlConnection(sb.ToString());
            try
            {
                conn.Open();
                Console.WriteLine($"Current state: {conn.State.ToString()}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"{ex.Message}, {ex.Data}");
            }
            finally
            {
                conn.Close();
                Console.ReadLine();
            }
        }
    }
}
