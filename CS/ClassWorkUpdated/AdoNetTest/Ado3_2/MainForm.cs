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

namespace Ado3_2
{
    public partial class MainForm : Form
    {
        private TeachersDb db;
        public MainForm()
        {
            db = new TeachersDb(System.Configuration.ConfigurationManager.ConnectionStrings["TeachersDbConnection"].ConnectionString);
            InitializeComponent();
            db.FillTables();
            cmbTables.DataSource = db.TableNames;
            cmbTables.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv.DataSource = db.TeachersSet.Tables[cmbTables.SelectedIndex];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.FillTables();
        }
    }

}
