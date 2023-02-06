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

namespace Ado3_4
{
    public partial class Form1 : Form
    {
        private string connString = System.Configuration.ConfigurationManager.ConnectionStrings["TeachersDbConnection"].ConnectionString;
        SqlDataAdapter adapter;
        DataTable teachers;
        SqlCommandBuilder cmdb;
        public Form1()
        {
            InitializeComponent();
            adapter = new SqlDataAdapter("select * from Teachers",connString);
            cmdb = new SqlCommandBuilder(adapter);
            teachers = new DataTable("Teachers");
            btnUpdate_Click(null, null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            teachers.Clear();
            adapter.Fill(teachers);
            dgv.DataSource = teachers;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //отправить изменения в таблице в бд
            adapter.Update(teachers);
            //обновить грид
            btnUpdate_Click(null, null);
        }
    }
}
