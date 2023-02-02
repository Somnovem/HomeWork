using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseDb
{
    public partial class MainForm : Form
    {
        private SqlConnection sqlConnection;
        private const string sqlSelect = "select * from Products";
        private const string sqlSelectTypes = "select * from Types";
        private const string sqlSelectMans = "select * from Manufacturers";
        public MainForm()
        {
            this.sqlConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings[0].ConnectionString);
            try
            {
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(1);
            }
            InitializeComponent();
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ReadOnly = true;

            dgvTypes.MultiSelect = false;
            dgvTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTypes.ReadOnly = true;

            dgvMans.MultiSelect = false;
            dgvMans.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMans.ReadOnly = true;

            UpdateView();
            UpdateTypes();
            UpdateMans();
        }

        //////////////////////PRODUCTS 

        private void UpdateView()
        {
            dgv.DataSource = null;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlSelect, sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgv.DataSource = dt;
        }

        private void FillView(string sql)
        {
            dgv.DataSource = null;
            SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgv.DataSource = dt;
        }

        private void btnManMax_Click(object sender, EventArgs e)
        {
            string sql = "select M.[Name] from(select top 1 P.ManufacturerId,sum(P.Stock) SumStock from Products P join Manufacturers M on P.ManufacturerId = M.Id group by P.[ManufacturerId] order by SumStock desc) s,Manufacturers M where M.Id = S.ManufacturerId";
            FillView(sql);
        }

        private void btnManMin_Click(object sender, EventArgs e)
        {
            string sql = "select M.[Name] from(select top 1 P.ManufacturerId,sum(P.Stock) SumStock from Products P join Manufacturers M on P.ManufacturerId = M.Id group by P.[ManufacturerId] order by SumStock) s,Manufacturers M where M.Id = S.ManufacturerId";
            FillView(sql);
        }

        private void btnTypeMax_Click(object sender, EventArgs e)
        {
            string sql = "select T.[Name] from(select top 1 P.TypeId,sum(P.Stock) SumStock from Products P join [Types] T on P.TypeId = T.Id  group by P.[TypeId] order by SumStock desc) s,[Types] T where T.Id = S.TypeId";
            FillView(sql);
        }

        private void btnTypeMin_Click(object sender, EventArgs e)
        {
            string sql = "select T.[Name] from(select top 1 P.TypeId,sum(P.Stock) SumStock from Products P join [Types] T on P.TypeId = T.Id  group by P.[TypeId] order by SumStock) s,[Types] T where T.Id = S.TypeId";
            FillView(sql);
        }

        private void btnRecent_Click(object sender, EventArgs e)
        {
            int days;
            if (edDays.Text == "" || !int.TryParse(edDays.Text, out days)) {
                MessageBox.Show("Invalid number of days", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            SqlCommand cmd = new SqlCommand("select * from Products where DATEDIFF(day,DateIn,getdate()) = @days");
            cmd.Parameters.Add(new SqlParameter("@days",days));
            dgv.DataSource = null;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgv.DataSource = dt;
        }

        private void btnProdAdd_Click(object sender, EventArgs e)
        {
            btnProdAdd.Enabled = false;
            string sql = "insert into [Products]([Name],[TypeId],[ManufacturerId],[Stock],[PrimeCost],[DateIn]) values(@name,@typeid,@manid,@stock,@primecost,@datein)";
            SqlCommand command = new SqlCommand(sql, sqlConnection);
            try
            {
                if (string.IsNullOrWhiteSpace(edProdName.Text) || string.IsNullOrWhiteSpace(edPrimeCost.Text))
                {
                    MessageBox.Show("Empty name or cost", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                command.Parameters.Add(new SqlParameter("@name", edProdName.Text));
                SqlParameter typeid = new SqlParameter("@typeid", SqlDbType.Int);
                SqlParameter manid = new SqlParameter("@manid", SqlDbType.Int);
                SqlParameter stock = new SqlParameter("@stock", SqlDbType.Int);
                SqlParameter primecost = new SqlParameter("@primecost", SqlDbType.Money);
                SqlParameter datein = new SqlParameter("@datein", SqlDbType.Date);
                typeid.Value = (int)edTypeId.Value;
                manid.Value = (int)edManId.Value;
                stock.Value = (int)edStock.Value;
                float val;
                if (!float.TryParse(edPrimeCost.Text, out val))
                {
                    MessageBox.Show("Invalid cost", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                primecost.Value = val;
                datein.Value = edDate.Value;
                command.Parameters.Add(typeid);
                command.Parameters.Add(manid);
                command.Parameters.Add(stock);
                command.Parameters.Add(primecost);
                command.Parameters.Add(datein);
                command.ExecuteNonQuery();
                edStock.Value = 0;
                edTypeId.Value = 1;
                edManId.Value = 1;
                edPrimeCost.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnProdAdd.Enabled = true;
                UpdateView();
            }
        }

        private void btnProdDelete_Click(object sender, EventArgs e)
        {
            btnProdDelete.Enabled = false;
            int id = (int)dgv.SelectedRows[0].Cells[0].Value;
            string sql = "delete from Products where Id = @id";
            SqlCommand cmd = new SqlCommand(sql,sqlConnection);
            cmd.Parameters.Add(new SqlParameter("@id",id));
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnProdDelete.Enabled = false;
                UpdateView();
            }
        }
        /////////////////////////////////////

        ////////////////////Types
        private void UpdateTypes()
        {
            dgvTypes.DataSource = null;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlSelectTypes, sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvTypes.DataSource = dt;
        }
        private void btnAddType_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(edTypeName.Text))
            {
                MessageBox.Show("Type cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            btnAddType.Enabled = false;
            string sql = "insert into Types([Name]) values(@name)";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            cmd.Parameters.Add(new SqlParameter("@name", edTypeName.Text));
            try
            {
                cmd.ExecuteNonQuery();
                edTypeName.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnAddType.Enabled = true;
                UpdateTypes();
            }
        }

        private void btnDeleteType_Click(object sender, EventArgs e)
        {
            btnDeleteType.Enabled = false;
            int id = (int)dgvTypes.SelectedRows[0].Cells[0].Value;
            string sql = "delete from Types where Id = @id";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            cmd.Parameters.Add(new SqlParameter("@id", id));
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnDeleteType.Enabled = false;
                UpdateTypes();
            }
        }
        ////////////////////

        ////////////////////Manufacturers
        private void UpdateMans()
        {
            dgvMans.DataSource = null;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlSelectMans, sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvMans.DataSource = dt;
        }

        private void btnManAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(edManName.Text))
            {
                MessageBox.Show("Manufacturer's name cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            btnManAdd.Enabled = false;
            string sql = "insert into Manufacturers([Name]) values(@name)";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            cmd.Parameters.Add(new SqlParameter("@name", edManName.Text));
            try
            {
                cmd.ExecuteNonQuery();
                edManName.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnManAdd.Enabled = true;
                UpdateMans();
            }
        }

        private void btnManDelete_Click(object sender, EventArgs e)
        {
            btnManDelete.Enabled = false;
            int id = (int)dgvMans.SelectedRows[0].Cells[0].Value;
            string sql = "delete from Manufacturers where Id = @id";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            cmd.Parameters.Add(new SqlParameter("@id", id));
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnManDelete.Enabled = true;
                UpdateMans();
            }
        }

        private void btnShowProd_Click(object sender, EventArgs e)
        {
            UpdateView();
        }
        ////////////////////
    }
}
