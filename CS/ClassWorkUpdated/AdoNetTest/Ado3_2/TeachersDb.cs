using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ado3_2
{
    internal class TeachersDb
    {
        public const string tableGroups = "Groups";
        public const string tableStudents = "Students";
        public const string tableSubjects = "Subjects";
        public string[] TableNames = { tableGroups, tableStudents, tableSubjects };
        private SqlConnection sqlConnection;
        private string connString;
        private DataSet dataSet;
        public DataSet TeachersSet => dataSet;

        public TeachersDb(string connStr)
        {
            connString = connStr;
            sqlConnection = new SqlConnection(connStr);
            dataSet = new DataSet("TeachersDb");
        }
        public void FillTables()
        {
            dataSet.Tables.Clear();
            string sql = $"select * from {tableGroups}; " +
                         $"select * from {tableStudents}; " +
                         $"select * from {tableSubjects};";
   
            using (sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                using (SqlDataReader reader = cmd.ExecuteReader()) {
                    int t = 0;
                    do
                    {
                        DataTable table = new DataTable();
                        dataSet.Tables.Add(table);
                        t++;
                        bool first = true;
                        while (reader.Read())
                        {
                            if (first)
                            {
                                first = false;
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    // Console.Write($"{reader.GetName(i)}\t");
                                    table.Columns.Add(new DataColumn(reader.GetName(i)));
                                }
                            }
                            DataRow row = table.NewRow();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row[i] = reader[i];
                            }
                            table.Rows.Add(row);
                        }
                        Console.WriteLine();
                    } while (reader.NextResult());
                }
            }
        }
    }
}
