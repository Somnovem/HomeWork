using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FruitsWinForms
{
    public partial class ConnectForm : Form
    {
        DbConnection conn;
        DbProviderFactory factory;
        string connStr = "";
        MainForm mainForm;
        public ConnectForm()
        {
            InitializeComponent();
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

        private void btnUpdateProviders_Click(object sender, EventArgs e)
        {
            DataTable dt = DbProviderFactories.GetFactoryClasses();
            cmbProviders.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                cmbProviders.Items.Add(row["InvariantName"].ToString());
            }
            cmbProviders.SelectedIndex = 0;
        }

        private void cmbProviders_SelectedIndexChanged(object sender, EventArgs e)
        {
            factory = DbProviderFactories.GetFactory(cmbProviders.SelectedItem.ToString());
            conn = factory.CreateConnection();
            connStr = GetConnectionString(cmbProviders.SelectedItem.ToString());
            if (!string.IsNullOrEmpty(connStr))
            {
                edConnectionSrtring.Text = connStr;
            }
            else
            {
                edConnectionSrtring.Text = "Connection string not found!";
            }
        }

        private void edConnectionSrtring_TextChanged(object sender, EventArgs e)
        {
            btnConnect.Enabled = edConnectionSrtring.Text != "Connection string not found!";
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

            btnConnect.Enabled = false;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.ConnectionString = connStr;
                    conn.Open();
                }
                mainForm = new MainForm(conn,factory);
                mainForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning");
            }
            finally
            {
                btnConnect.Enabled = true;
            }
            
            
        }
    }
}
