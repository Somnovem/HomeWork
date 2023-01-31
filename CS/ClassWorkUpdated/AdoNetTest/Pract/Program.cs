using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Pract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionStr = "Data Source = DESKTOP-6FEP48M\\SQLEXPRESS;Initial Catalog = StudentsGrades;Integrated Security=true";
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1-Connect to database");
                Console.WriteLine("2-Disconnect from database");
                Console.Write("Option: ");
                int ans = 0;
                try
                {
                    ans = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Invalid option");
                    Environment.Exit(1);
                }
                using (SqlConnection conn = new SqlConnection(connectionStr))
                {
                    Console.Clear();
                    switch (ans)
                    {
                        case 1:
                            if (conn.State == ConnectionState.Closed)
                            {
                                try
                                {
                                    conn.Open();
                                    Console.WriteLine("Succssfully connected!");
                                }
                                catch
                                {
                                    Console.WriteLine("Could not connect to database!");
                                    Console.ReadLine();
                                }
                            }
                            break;
                        case 2:
                            if (conn.State == ConnectionState.Open)
                            {
                                try
                                {
                                    conn.Close();
                                    Console.WriteLine("Succssfully disconnected!");
                                }
                                catch
                                {
                                    Console.WriteLine("Could not disconnect from database!");
                                    Console.ReadLine();
                                }
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid option!");
                            break;
                    }
                    Console.ReadLine();
                    break;
                }
            }
            using (SqlConnection connect = new SqlConnection(connectionStr))
            {
                Console.ReadLine();
            }
        }
        static void ShowTable(SqlConnection conn)
        {
            Console.Clear();
            string sql = "select * from Grades";

            SqlCommand cmd = new SqlCommand(sql, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                bool first = true;
                while (reader.Read())
                {
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
        static void ShowNames(SqlConnection conn)
        {
            Console.Clear();
            string sql = "select Lastname + ' ' + Firstname + ' ' + Fathersname as 'Fullname'  from Grades";
            SqlCommand cmd = new SqlCommand(sql, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine(reader[0]);
                }
            }
        }
        static void ShowAverages(SqlConnection conn)
        {
            Console.Clear();
            string sql = "select AvgGrade  from Grades";
            SqlCommand cmd = new SqlCommand(sql, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine(reader[0]);
                }
            }
        }
        static void ShowStudentsWithGradesHigher(SqlConnection conn,int grade)
        {
            Console.Clear();
            string sql = "select Lastname + ' ' + Firstname + ' ' + Fathersname as 'Fullname'  from Grades where AvgGrade > @grade";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@grade", grade));
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine(reader[0]);
                }
            }
        }
        static void ShowSubjectWithMinimalGrades(SqlConnection conn){
            Console.Clear();
            string sql = "select distinct SubjectMinimalAvgGrade from Grades";
            SqlCommand cmd = new SqlCommand(sql, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine(reader[0]);
                }
            }
        }
        static void MinimalAvgGrade(SqlConnection conn) {
            Console.Clear();
            int res = 0;
            string sql = "select Min(AvgGrade) from Grades";
            SqlCommand cmd = new SqlCommand(sql, conn);
            object result = cmd.ExecuteScalar();
            if (int.TryParse(res.ToString(), out res))
            {
                Console.WriteLine($"Minimal avg grade = {res}");
            }
            else
            {
                Console.WriteLine("Cannor exec query!");
            }
        }
        static void MaximalAvgGrade(SqlConnection conn)
        {
            Console.Clear();
            int res = 0;
            string sql = "select Max(AvgGrade) from Grades";
            SqlCommand cmd = new SqlCommand(sql, conn);
            object result = cmd.ExecuteScalar();
            if (int.TryParse(res.ToString(), out res))
            {
                Console.WriteLine($"Maximal avg grade = {res}");
            }
            else
            {
                Console.WriteLine("Cannor exec query!");
            }
        }
        static void NumOfStudentsMinMath(SqlConnection conn) {
            Console.Clear();
            int res = 0;
            string sql = "select count(Lastname) from Grades";
            SqlCommand cmd = new SqlCommand(sql, conn);
        }
    }
}
