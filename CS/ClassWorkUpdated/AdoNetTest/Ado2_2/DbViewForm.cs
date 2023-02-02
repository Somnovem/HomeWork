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
    public partial class DbViewForm : Form
    {
        private SqlConnection sqlConnection;
        private const string sqlTeachersSelect = "select * from Teachers";
        private const string sqlGroupsSelect = "select * from Groups";
        public DbViewForm(SqlConnection connection)
        {
            this.sqlConnection = connection;
            InitializeComponent();
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ReadOnly = true;
            UpdateTeachersView();
            btnUpdateGroup_Click(null, null);
        }
        private void UpdateTeachersView()
        {
            dgv.DataSource = null;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlTeachersSelect, sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgv.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateTeachersView();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            string sql = "insert into [Teachers]([Firstname],[Lastname],[Birthdate],[DepartmentId]) values(@firstname,@lastname,@birth,@dep)";
            SqlCommand command = new SqlCommand(sql,sqlConnection);
            try
            {
                command.Parameters.Add(new SqlParameter("@firstname", edFirstname.Text));
                command.Parameters.Add(new SqlParameter("@lastname", edLastname.Text));
                SqlParameter date = new SqlParameter("@birth", SqlDbType.Date);
                SqlParameter dep = new SqlParameter("@dep", SqlDbType.Int);
                dep.Value = (int)edDepartment.Value;
                date.Value = edBirthDate.Value;
                command.Parameters.Add(dep);
                command.Parameters.Add(date);
                await command.ExecuteNonQueryAsync();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnAdd.Enabled = true;
                UpdateTeachersView();
            }
        }

        private void btnUpdateGroup_Click(object sender, EventArgs e)
        {
            dgvGroups.DataSource = null;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlGroupsSelect, sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvGroups.DataSource = dt;
        }

        private async void btnAddGroup_Click(object sender, EventArgs e)
        {
            btnAddGroup.Enabled = false;
            SqlCommand command = new SqlCommand("AddNewGroup", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@groupName", edGroupName.Text));
            command.Parameters.Add(new SqlParameter("@faculty", (int)edFacultyId.Value));
            SqlParameter groupId = new SqlParameter("@groupId", SqlDbType.Int);
            groupId.Direction = ParameterDirection.Output;
            command.Parameters.Add(groupId);
            try
            {
                await command.ExecuteNonQueryAsync();
                MessageBox.Show($"Group id = {groupId.Value}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnAddGroup.Enabled = true;
                btnUpdateGroup_Click(sender, e);
            }
        }
    }
}
