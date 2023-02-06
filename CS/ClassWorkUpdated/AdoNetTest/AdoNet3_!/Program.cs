using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace AdoNet3_1
{
    internal class Program
    {
        private static string conString = System.Configuration.ConfigurationManager.ConnectionStrings["TeachersDbConnection"].ConnectionString;
        static void Main(string[] args)
        {
            Console.Title = "Multiqueries";
            ShowTables();
            Console.WriteLine("\npress any key...");
            Console.ReadKey();
        }
        private static void ShowTables()
        {
            
            string sql = "select * from Groups; " +
                         "select * from Students; " +
                         "select * from Subjects;";
            using (SqlConnection conn = new SqlConnection(conString)) {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                var reader = cmd.ExecuteReader();
                do
                {
                    bool first = true;
                    while (reader.Read())
                    {
                        if (first)
                        {
                            first = false;
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                Console.Write($"{reader.GetName(i)}\t");
                            }
                            Console.WriteLine();
                        }
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.Write($"{reader[i]}\t");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }while (reader.NextResult());
            }
        }
    }
}
