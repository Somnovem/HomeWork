using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Xml.XPath;
using System.Data.SqlClient;

namespace Ado4_1
{
    public partial class MainForm : Form
    {
        DbConnection conn;
        DbProviderFactory factory;
        string connStr = "";
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGetProvider_Click(object sender, EventArgs e)
        {
           DataTable dt = DbProviderFactories.GetFactoryClasses();
            dgvView.DataSource = dt;
            cmbProviderList.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                cmbProviderList.Items.Add(row["InvariantName"].ToString());
            }
            cmbProviderList.SelectedIndex = 0;
            cmbProviderList.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = connStr;
            conn.Open();
            DbDataAdapter adapter = factory.CreateDataAdapter();

            //vers 1.0
            //adapter.SelectCommand = factory.CreateCommand();
            //adapter.SelectCommand.Connection = conn;

            //vers 2.0
            adapter.SelectCommand = conn.CreateCommand();


            adapter.SelectCommand.CommandText = edSqlQuery.Text;

            dgvView.DataSource = null;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvView.DataSource = dt;
            
        }

        private void cmbProviderList_SelectedIndexChanged(object sender, EventArgs e)
        {
            factory = DbProviderFactories.GetFactory(cmbProviderList.SelectedItem.ToString());
            conn = factory.CreateConnection();
            connStr = GetConnectionString(cmbProviderList.SelectedItem.ToString());
            if (!string.IsNullOrEmpty(connStr))
            {
                edConStr.Text = connStr;
                edSqlQuery.Enabled = true;
            }
            else
            {
                edConStr.Text = "Connection string not found!";
                edSqlQuery.Enabled = false;
            }
        }
        private string GetConnectionString(string provider)
        {
            string result = null;
            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;
            if (settings != null)
            {
                foreach (ConnectionStringSettings css in settings)
                {
                    if (css.ProviderName.Equals(provider))
                    {
                        result = css.ConnectionString;
                        break;
                    }
                }
            }
            return result;
        }

        private void edSqlQuery_TextChanged(object sender, EventArgs e)
        {
            if(edSqlQuery.Text.Length > 5)
                btnExec.Enabled = true;
        }

        private async void btnAsyncExecute_Click(object sender, EventArgs e)
        {
            btnExec.Enabled = false;
            btnAsyncExecute.Enabled = false;
            DbCommand cmd = conn.CreateCommand();
            cmd.CommandText = edSqlQuery.Text;
            try
            {
                await cmd.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnExec.Enabled = true;
                btnAsyncExecute.Enabled = true;
            }
        }
    }
}
