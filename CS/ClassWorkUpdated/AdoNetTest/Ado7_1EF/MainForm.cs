using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ado7_1EF
{
    public partial class MainForm : Form
    {
        private TeachersDbEntities dbEntities;
        public MainForm()
        {
            InitializeComponent();

            ApplyDataGridSettings();

            //подключаем
            dbEntities = new TeachersDbEntities();


            dgvDepartments.DataSource = dbEntities.Departments.ToList();
            btnDepUpdate_Click(null, null);
            UpdateTeachersList();
        }
        private void UpdateTeachersList() 
        {
            dgvTeachers.DataSource = null;
            dgvTeachers.DataSource = dbEntities.Teachers.ToList();

            colTeacherDepartmentId.DataPropertyName = "DepartmentId";
            colTeacherDepartmentId.DataSource = dbEntities.Departments.ToList();
            colTeacherDepartmentId.DisplayMember = "Name";
            colTeacherDepartmentId.ValueMember = "Id";

            //colTeacherDepartmentId.DataPropertyName = "DepartmentId";
            colTeacherDepartmentId.DataSource = dbEntities.Departments.ToList();
            colTeacherDepartmentId.DisplayMember = "Name";
            colTeacherDepartmentId.ValueMember = "Id";
        }

        private void ApplyDataGridSettings()
        {
            dgvDepartments.AutoGenerateColumns = false;
            dgvTeachers.AutoGenerateColumns = false;

            //если через код
            dgvDepartments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTeachers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDepartments.MultiSelect = false;
            dgvTeachers.MultiSelect = false;
        }

        private async void btnDepAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edDepName.Text) || string.IsNullOrEmpty(edDepPhone.Text))
            {
                MessageBox.Show("Fields cannot be empty!");
                return;
            }
            Departments department = new Departments()
            {
                Name = edDepName.Text,
                Phone = edDepPhone.Text
            };
            dbEntities.Departments.Add(department);
            SaveAllChanges(btnDepAdd);
            btnDepUpdate_Click(null, null);
        }

        private void btnDepUpdate_Click(object sender, EventArgs e)
        {
            dgvDepartments.DataSource = null;
            dgvDepartments.DataSource = dbEntities.Departments.ToList();
        }

        private async void btnDepSave_Click(object sender, EventArgs e)
        {
            if (dgvDepartments.SelectedRows.Count == 0)
                return;
            Departments department = dgvDepartments.SelectedRows[0].DataBoundItem as Departments;
            if (department == null)
                return;
            department.Name = edDepName.Text;
            department.Phone = edDepPhone.Text;
            SaveAllChanges(btnDepSave);
            btnDepUpdate_Click(null, null);
        }

        private async void btnDepDelete_Click(object sender, EventArgs e)
        {
            if (dgvDepartments.SelectedRows.Count == 0)
                return;
            Departments department = dgvDepartments.SelectedRows[0].DataBoundItem as Departments;
            if (department == null)
                return;

            DialogResult result = MessageBox.Show("Delete record?", "Confirm...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            dbEntities.Departments.Remove(department);
            SaveAllChanges(btnDepDelete);
            btnDepUpdate_Click(null, null);
        }

        private void dgvDepartments_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDepartments.SelectedRows.Count == 0)
                return;
            Departments department = dgvDepartments.SelectedRows[0].DataBoundItem as Departments;
            if (department == null)
                return;
            edDepName.Text = department.Name;
            edDepPhone.Text = department.Phone;
        }

        private async void btnTeacherAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edTeacherFirstname.Text) || string.IsNullOrEmpty(edTeacherLastname.Text))
            {
                MessageBox.Show("Fields cannot be empty!");
                return;
            }

            Departments department = cmbTeacherDep.SelectedItem as Departments;
            if (department == null)
                return;

            Teachers teacher = new Teachers()
            {
                FirstName = edTeacherFirstname.Text,
                LastName = edTeacherLastname.Text,
                BirthDate = edTeacherBirth.Value,
                Departments = department
            };

        }
        private async void SaveAllChanges(Button sender)
        {
            sender.Enabled = false;
            try
            {
                await dbEntities.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                sender.Enabled = true;
            }
        }
    }
}
