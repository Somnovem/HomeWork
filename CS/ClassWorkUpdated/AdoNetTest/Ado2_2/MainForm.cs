using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ado2_2
{
    public partial class MainForm : Form
    {
        
        private SqlConnectionStringBuilder builder;
        public MainForm()
        {
            InitializeComponent();
            builder = new SqlConnectionStringBuilder(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString1"].ConnectionString);
            txtAdress.Text = builder.DataSource;
            cbAsync.Checked = builder.AsynchronousProcessing;
            rbWIndows.Checked = builder.IntegratedSecurity;
            if (!builder.IntegratedSecurity)
            {
                txtLogin.Text = builder.UserID;
                txtPass.Text = builder.Password;
            }
        }

        private void rbWIndows_CheckedChanged(object sender, EventArgs e)
        {
            grSql.Enabled = !rbWIndows.Checked;
            if (rbSql.Checked) 
            {
                txtLogin.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdress.Text)) return;
            builder.DataSource = txtAdress.Text;
            if (rbWIndows.Checked)
                builder.IntegratedSecurity = true;
            else
            {
                builder.UserID = txtLogin.Text;
                builder.Password = txtPass.Text;
            }
            builder.AsynchronousProcessing = cbAsync.Checked;
            SqlConnection sqlConnection = new SqlConnection(builder.ToString());
            try
            {
                sqlConnection.Open();
                DbViewForm dbViewForm = new DbViewForm(sqlConnection);
                dbViewForm.ShowDialog();
            }
            finally { 
                sqlConnection?.Close();
            }
        }
    }
}
