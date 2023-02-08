using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ado5_1
{
    public partial class MainForm : Form
    {
        private const string connectionString = @"Data Source = (local)\sqlexpress;Initial Catalog = Users;Integrated Security = true";
        private DataContext dbContext;
        private Table<User> users;
        public MainForm()
        {
            InitializeComponent();
            dbContext = new DataContext(connectionString);
            users = dbContext.GetTable<User>();
            dgvUsers.DataSource = users;
            dgvUsers.ReadOnly = true;
            dgvUsers.MultiSelect = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edLogin.Text) || string.IsNullOrEmpty(edPassword.Text))
                return;
            User user = new User() {UserLogin = edLogin.Text,Password = edPassword.Text,allow = cbAllow.Checked};
            dbContext.GetTable<User>().InsertOnSubmit(user);
            btnSave_Click(null, null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dbContext.SubmitChanges();
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = dbContext.GetTable<User>().ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count < 1)
                return;
            User user = dgvUsers.SelectedRows[0].DataBoundItem as User;
            if (user == null)
                return;
            dbContext.GetTable<User>().DeleteOnSubmit(user);
            btnSave_Click(null, null);
        }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count < 1)
                return;
            User user = dgvUsers.SelectedRows[0].DataBoundItem as User;
            if (user == null)
                return;
            edDate.Value = user.DateCreated;
            edLogin.Text = user.UserLogin;
            edPassword.Text = user.Password;
            cbAllow.Checked = user.allow;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //if (dgvUsers.SelectedRows.Count < 1)
            //    return;
            //User user = dgvUsers.SelectedRows[0].DataBoundItem as User;
            //if (user == null)
            //    return;
            //User userNew = dbContext.GetTable<User>().Where(u=>u.Id == user.Id).FirstOrDefault();
            //if (userNew != null)
            //{
            //    userNew.Password = edPassword.Text;
            //    userNew.UserLogin = edLogin.Text;
            //    userNew.allow = cbAllow.Checked;
            //    btnSave_Click(null, null);
            //}


            //var users = from u in dbContext.GetTable<User>()
            //            orderby u.UserLogin
            //            select new { Login = u.UserLogin, Date = u.DateCreated }.Take(5);


            //var users = from u in table1
            //            join t in table2 on t equals u.(linking column)
            //            orderby u.UserLogin
            //            select new { Login = u.UserLogin, Date = u.DateCreated }.Take(5);

            dgvUsers.DataSource = dbContext.GetTable<User>()
                .Select(u=>new {Login = u.UserLogin,Date = u.DateCreated})
                .OrderBy(u=>u.Login)
                .Take(5)
                .ToList();
        }
    }
}
