using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ado5_2
{
    public partial class Form1 : Form
    {
        private const string connectionString = @"Data Source = (local)\sqlexpress;Initial Catalog = TeachersDb;Integrated Security = true";
        private TeachersDbDataContext teachersDb;
        public Form1()
        {
            InitializeComponent();
            teachersDb = new TeachersDbDataContext(connectionString);
            //dataGridView1.DataSource = teachersDb.Subjects.ToList();
            var teachers = from d in teachersDb.Departments
                           join t in teachersDb.Teachers on d equals t.Departments
                           orderby t.Firstname, t.Lastname
                           select new
                           {

                               Fullname = $"{t.Firstname},{t.Lastname}",

                               Birth = t.Birthdate,

                               d.Department
                           };
            dataGridView1.DataSource = teachers.ToList();
        }
    }
}
