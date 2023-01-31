using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Data Source=localhost
            //Data Source=192.168.1.1
            //Data Source=192.168.1.1\\SQLEXPRESS
            //Data Source=(local)\\SQLEXPRESS
            //Data Source=(local)
            //Data Source=192.168.1.1\\MSSQL
            string connectionStr = "Data Source = DESKTOP-6FEP48M\\SQLEXPRESS;Initial Catalog = TeachersDb;Integrated Security=true"; //true|yes|sspi
            //string connectionStr = "Data Source = DESKTOP-6FEP48M\\SQLEXPRESS;Initial Catalog = TeachersDb;User ID = Mark; Password=1234";
            using (SqlConnection conn = new SqlConnection(connectionStr))
            {
                conn.Open();
                //SqlCommand cmd = conn.CreateCommand();
                //cmd.CommandText = "select * from Students";
                ShowTable("Faculties", conn);
                ShowScalarValue("Faculties", conn);
                //InsertFaculty(conn);
                //Console.WriteLine("----------------------------------------------");
                //ShowTable("Faculties", conn);
                //DeleteFaculty(conn);
                //Console.WriteLine("----------------------------------------------");
                //ShowTable("Faculties", conn);
            }
            Console.WriteLine("\nPress enter key...");
            Console.ReadLine();
        }

        private static void InsertFaculty(SqlConnection conn)
        {
            Console.Write("\nEnter name: ");
            string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name)){
                Console.WriteLine("Invalid name");
                return;
            }
            //SqlParameter param = new SqlParameter("@name",SqlDbType.NVarChar,100);
           // param.Value = name;
            string sql = $"insert into Faculties values(@name)";
            SqlCommand command = new SqlCommand(sql, conn);
            //command.Parameters.Add(param);
            command.Parameters.Add(new SqlParameter("@name", name));
            int res = command.ExecuteNonQuery();
            Console.WriteLine($"{res} row(s) affected");
        }

        static void ShowTable(string tableName, SqlConnection conn) {
            string sql = "select * from " + tableName;

            SqlCommand cmd = new SqlCommand(sql, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                bool first = true;
                while (reader.Read())
                {
                    //reader["id"] - доступ к значению по имени колонки
                    if (first)
                    {
                        first = false;
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.Write(reader.GetName(i) + "\t");
                        }
                        Console.WriteLine();
                    }
                    for (int i = 0; i < reader.FieldCount; ++i)
                    {
                        Console.Write(reader[i] + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }
        static void ShowScalarValue(string tableName, SqlConnection conn) {
            string sql = "select count(*) from " + tableName;

            SqlCommand cmd = new SqlCommand(sql, conn);
            int result;
            object res = cmd.ExecuteScalar();
            if (int.TryParse(res.ToString(), out result)){
                Console.WriteLine($"Record count = {result}");
            }
            else
            {
                Console.WriteLine("Cannor exec query!");
            }
        }

        private static void DeleteFaculty(SqlConnection conn) {
            Console.Write("\nEnter Id: ");
            int id;
            try
            {
                 id= Convert.ToInt32(Console.ReadLine());
            }
            catch {
                Console.WriteLine("Invalid ID");
                return;
            }
            string sql = "delete from Faculties where ID = @id";
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.Add(new SqlParameter("@id", id));
            int res = command.ExecuteNonQuery();
            Console.WriteLine($"{res} row(s) affected");
        }
    }
}
