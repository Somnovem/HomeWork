using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ado8_1EF
{
    public partial class MainForm : Form
    {
        ContactsDbModelContainer contactsDb;
        public MainForm()
        {
            InitializeComponent();

            dgvContacts.AutoGenerateColumns = false;
            dgvPeople.AutoGenerateColumns = false;
            dgvContacts.MultiSelect = false;
            dgvPeople.MultiSelect = false;
            dgvContacts.SelectionMode  = DataGridViewSelectionMode.FullRowSelect;
            dgvPeople.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            contactsDb = new ContactsDbModelContainer();
            UpdateDataGridView();
        }

        private void UpdateDataGridView(bool saveChanges = false)
        {
            int id = -1;
            if (dgvPeople.DataSource != null)
            {
                id = dgvPeople.Rows.IndexOf(dgvPeople.SelectedRows[0]);
            }
            dgvPeople.DataSource = null;
            dgvPeople.DataSource = contactsDb.Persons.ToList();
            if (saveChanges)
                contactsDb.SaveChanges();
            if(id>=0)
                dgvPeople.Rows[id].Selected = true;
        }

        private void dgvPeople_SelectionChanged(object sender, EventArgs e)
        {
            dgvContacts.DataSource = null;
            if (dgvPeople.SelectedRows.Count == 0)
                return;
            Person person = dgvPeople.SelectedRows[0].DataBoundItem as Person;
            if (person == null)
                return;
            dgvContacts.DataSource = person.Contacts.ToList();
        }

        private void btnPersonAdd_Click(object sender, EventArgs e)
        {
            Person person = new Person()
            {
                Firstname = edPersonFirstname.Text,
                Lastname = edPersonLastname.Text,
                Birth = edPersonBirth.Value,
            };
            contactsDb.Persons.Add(person);
            UpdateDataGridView(true);
        }

        private void btnContactAdd_Click(object sender, EventArgs e)
        {
            if (dgvContacts.SelectedRows.Count == 0)
                return;
            Person person = dgvPeople.SelectedRows[0].DataBoundItem as Person;
            if (person == null)
                return;
            Contact contact = new Contact()
            {
            TypeInfo = edContactType.Text,
            Value = edContactValue.Text
            };
            contact.Person = person;
            contactsDb.Contacts.Add(contact);
            UpdateDataGridView(true);
        }
    }
}
