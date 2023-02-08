using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FruitsWinForms
{
    public partial class MainForm : Form
    {
        DbConnection connection;
        DbProviderFactory factory;
        DbDataAdapter adapter;
        Stopwatch watch = new Stopwatch();
        public MainForm(DbConnection conn, DbProviderFactory factory)
        {
            InitializeComponent();
            this.connection = conn;
            this.factory = factory;
            adapter = this.factory.CreateDataAdapter();
            btnUpdate_Click(null, null);
            edType.SelectedIndex = 0;
        }
        private async void ExecCmdToGrid(DbCommand cmd)
        {
            DataTable dt = new DataTable();
            dgvQueries.DataSource = null;
            DbDataReader reader = await cmd.ExecuteReaderAsync();
            dt.Load(reader);
            dgvQueries.DataSource = dt;
        }
        private void ExecSqlWithoutParams(string sql)
        {
            watch.Reset();
            watch.Start();
            DbCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;
            ExecCmdToGrid(cmd);
            watch.Stop();
            ShowTimeSpentOnQuery();
        }
        private KeyValuePair<bool, string> MakeRequest(string reqStr)
            =>new KeyValuePair<bool, string>(new Request(reqStr).ShowDialog() == DialogResult.OK, Request.strAnswer);

        private void ShowTimeSpentOnQuery()
        {
            MessageBox.Show($"Query executed in {watch.ElapsedMilliseconds.ToString()} miliseconds", "Query ended", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ExecSqlWithoutParams("select * from Stats");
        }

        private void btnShowAllNames_Click(object sender, EventArgs e)
        {
            ExecSqlWithoutParams("select Name from Stats");
        }

        private void btnShowAllColors_Click(object sender, EventArgs e)
        {
            ExecSqlWithoutParams("select distinct Color from Stats");
        }

        private void btnYelOrRedProds_Click(object sender, EventArgs e)
        {
            ExecSqlWithoutParams("select * from Stats where Color = 'Yellow' or Color = 'Red'");
        }

        private void btnMaxCalories_Click(object sender, EventArgs e)
        {
            ExecSqlWithoutParams("select max(Calories) as 'Maximum calories found' from Stats");
        }

        private void btnMinCalories_Click(object sender, EventArgs e)
        {
            ExecSqlWithoutParams("select min(Calories) as 'Minimum calories found' from Stats");
        }

        private void btnVegNum_Click(object sender, EventArgs e)
        {
            ExecSqlWithoutParams("select count(*) as 'Number of vegetables' from Stats where Type = 'Vegetable'");
        }

        private void btnFruitNum_Click(object sender, EventArgs e)
        {
            ExecSqlWithoutParams("select count(*) as 'Number of fruits' from Stats where Type = 'Fruit'");
        }

        private void btnNumProdsInColor_Click(object sender, EventArgs e)
        {
            watch.Reset();
            watch.Start();
            KeyValuePair<bool, string> req = MakeRequest("In what color do you want products:");
            if (!req.Key) return;
            string sql = "select count(*) as 'Number of products in this color' from Stats where Color = @color";
            DbCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("@color", req.Value));
            watch.Stop();
            ShowTimeSpentOnQuery();
        }

        private void btnNumProdsPerColor_Click(object sender, EventArgs e)
        {
            ExecSqlWithoutParams("select Name from Stats");
        }

        private void btnProdsWithLessCalor_Click(object sender, EventArgs e)
        {
            watch.Reset();
            watch.Start();
            DateTime start = DateTime.Now;
            KeyValuePair<bool, string> req = MakeRequest("Show products with calories less than:");
            if (!req.Key) return;
            int calories;
            if (!int.TryParse(req.Value, out calories))
            {
                MessageBox.Show("Invalid entry", "Warning");
                return;
            }
            string sql = "select * from Stats where Calories < @calor";
            DbCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("@calor", calories));
            ExecCmdToGrid(cmd);
            watch.Stop();
            ShowTimeSpentOnQuery();
        }

        private void btnProdsWithMoreCalor_Click(object sender, EventArgs e)
        {
            watch.Reset();
            watch.Start();
            DateTime start = DateTime.Now;
            KeyValuePair<bool, string> req = MakeRequest("Show products with calories more than:");
            if (!req.Key) return;
            int calories;
            if (!int.TryParse(req.Value, out calories))
            {
                MessageBox.Show("Invalid entry", "Warning");
                return;
            }
            string sql = "select * from Stats where Calories > @calor";
            DbCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("@calor", calories));
            ExecCmdToGrid(cmd);
            watch.Stop();
            ShowTimeSpentOnQuery();
        }

        private void btnCaloriesRanged_Click(object sender, EventArgs e)
        {
            watch.Reset();
            watch.Start();
            DateTime start = DateTime.Now;
            KeyValuePair<bool, string> req = MakeRequest("Show products with calories more than:");
            if (!req.Key) return;
            int calStart, calEnd;
            if (!(int.TryParse(req.Value, out calStart)))
            {
                MessageBox.Show("Invalid entry", "Warning");
                return;
            }
            req = MakeRequest("Enter start of range of calories:");
            if (!req.Key) return;
            if (!(int.TryParse(req.Value, out calEnd)))
            {
                MessageBox.Show("Invalid entry", "Warning");
                return;
            }
            if (calEnd < calStart)
            {
                MessageBox.Show("End of range must be bigger than the start", "Warning");
                return;
            }
            string sql = "select *  from Stats where Calories between @calStart and @calEnd";
            DbCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("@calStart", calStart));
            cmd.Parameters.Add(new SqlParameter("@calEnd", calEnd));
            ExecCmdToGrid(cmd);
            watch.Stop();
            ShowTimeSpentOnQuery();
        }

        private void btnAvgCalories_Click(object sender, EventArgs e)
        {
            ExecSqlWithoutParams("select avg(Calories) as 'Average calories' from Stats");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DbCommand cmd = connection.CreateCommand();
            cmd.CommandText = "select * from Stats";
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            dgvControl.DataSource = dt;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (edCalories.Value <= 0 || string.IsNullOrEmpty(edColor.Text) || string.IsNullOrEmpty(edName.Text))
                return;
            watch.Reset();
            watch.Start();
            btnAdd.Enabled = false;
            string sql = "insert into [Stats]([Name],[Type],[Color],[Calories]) values(@name,@type,@color,@calories)";
            DbCommand command = connection.CreateCommand();
            command.CommandText = sql;
            try
            {
                DbParameter name = command.CreateParameter();
                DbParameter type = command.CreateParameter();
                DbParameter color = command.CreateParameter();
                DbParameter calories = command.CreateParameter();

                name.ParameterName = "@name";
                type.ParameterName = "@type";
                color.ParameterName = "@color";
                calories.ParameterName = "@calories";

                name.Value = edName.Text;
                type.Value = (string)edType.SelectedItem;
                color.Value = edColor.Text;
                calories.Value = edCalories.Value;

                command.Parameters.Add(name);
                command.Parameters.Add(type);
                command.Parameters.Add(color);
                command.Parameters.Add(calories);
                await command.ExecuteNonQueryAsync();
                btnUpdate_Click(null, null);
                watch.Stop();
                ShowTimeSpentOnQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning");
            }
            finally 
            {
                btnAdd.Enabled = true;
                watch.Stop();
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (edId.Value <= 0)
                return;
            watch.Reset();
            watch.Start();
            btnDelete.Enabled = false;
            string sql = "DELETE FROM Stats WHERE Id = @Id";
            DbCommand cmd = connection.CreateCommand();
            try
            {
                DbParameter id = cmd.CreateParameter();
                id.ParameterName = "@Id";
                id.Value = edId.Value;
                cmd.CommandText = sql;
                cmd.Parameters.Add(id);
                await cmd.ExecuteNonQueryAsync();
                btnUpdate_Click(null, null);
                watch.Stop();
                ShowTimeSpentOnQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning");
            }
            finally
            {
                btnDelete.Enabled = true;
                watch.Stop();
            }
        }
    }

}
