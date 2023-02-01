using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitsVegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionStr = "Data Source = DESKTOP-6FEP48M\\SQLEXPRESS;Initial Catalog = FruirsVegetables;Integrated Security=true";
            using (SqlConnection conn = new SqlConnection(connectionStr)){
                conn.Open();
                ShowAll(conn);
            }

        }
        static void ShowAll(SqlConnection conn)
        {
            string sql = "select * from Stats";

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
        static void ShowAllNames(SqlConnection conn) {
            string sql = "select Name from Stats";
            SqlCommand cmd = new SqlCommand(sql, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                Console.WriteLine(reader.GetName(0));
                while (reader.Read())
                {
                    Console.WriteLine(reader[0]);
                }
            }
        }
        static void ShowAllColors(SqlConnection conn)
        {
            string sql = "select distinct Color from Stats";
            SqlCommand cmd = new SqlCommand(sql, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                Console.WriteLine(reader.GetName(0));
                while (reader.Read())
                {
                    Console.WriteLine(reader[0]);
                }
            }
        }
        static void ShowMaxCalories(SqlConnection conn)
        {
            string sql = "select max(Calories) from Stats";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int res = 0;
            object result = cmd.ExecuteScalar();
            if (int.TryParse(result.ToString(), out res))
            {
                Console.WriteLine($"Maximal calories = {res}");
            }
        }
        static void ShowMinCalories(SqlConnection conn)
        {
            string sql = "select min(Calories) from Stats";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int res = 0;
            object result = cmd.ExecuteScalar();
            if (int.TryParse(result.ToString(), out res))
            {
                Console.WriteLine($"Minimal calories = {res}");
            }
        }
        static void ShowAvgCalories(SqlConnection conn)
        {
            string sql = "select avg(Calories) from Stats";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int res = 0;
            object result = cmd.ExecuteScalar();
            if (int.TryParse(result.ToString(), out res))
            {
                Console.WriteLine($"Average calories = {res}");
            }
        }
        static void NumOfVegetables(SqlConnection conn)
        {
            string sql = "select count(*) from Stats where Type = 'Vegetable'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int res = 0;
            object result = cmd.ExecuteScalar();
            if (int.TryParse(result.ToString(), out res))
            {
                Console.WriteLine($"Number of vegetables = {res}");
            }
        }
        static void NumOfFruits(SqlConnection conn)
        {
            string sql = "select count(*) from Stats where Type = 'Fruit'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int res = 0;
            object result = cmd.ExecuteScalar();
            if (int.TryParse(result.ToString(), out res))
            {
                Console.WriteLine($"Number of fruits = {res}");
            }
        }
        static void NumOfProdsInColor(SqlConnection conn)
        {
            Console.Write("\nEnter name: ");
            string color = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(color))
            {
                Console.WriteLine("Invalid color");
                return;
            }
            string sql = "select count(*) from Stats where Color = @color";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@color", color));
            int res = 0;
            object result = cmd.ExecuteScalar();
            if (int.TryParse(result.ToString(), out res))
            {
                Console.WriteLine($"Number of prods in {color} color = {res}");
            }
        }
        static void NumOfProdsPerColor(SqlConnection conn){
            string sql = "select Color,count(Name) as 'Num of products' from Stats group by Color";
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
        static void ShowProdsWithLessCalories(SqlConnection conn)
        {
            int calories;
            Console.Write("\nEnter number of calories: ");
            try
            {
                calories = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid number");
                return;
            }
            string sql = "select *  from Stats where Calories < @calor";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@calor", calories));
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
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
        }
        static void ShowProdsWithMoreCalories(SqlConnection conn)
        {
            int calories;
            Console.Write("\nEnter number of calories: ");
            try
            {
                calories = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid number");
                return;
            }
            string sql = "select *  from Stats where Calories > @calor";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@calor", calories));
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
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
        }
        static void ShowProdsWithCaloriesBetween(SqlConnection conn)
        {
            int calStart,calEnd;
            Console.Write("\nEnter start of range: ");
            try
            {
                calStart = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid number");
                return;
            }
            Console.Write("\nEnter end of range: ");
            try
            {
                calEnd = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid number");
                return;
            }
            string sql = "select *  from Stats where Calories between @calStart and @calEnd";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@calStart", calStart));
            cmd.Parameters.Add(new SqlParameter("@calEnd", calEnd));
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
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
        }
        static void ShowAllYellowOrRed(SqlConnection conn){
            string sql = "select * from Stats where Color = 'Yellow' or Color = 'Red'";
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
    }
}
