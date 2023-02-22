using System.ComponentModel;

namespace MessagerDb
{
    public partial class MainForm : Form
    {
        private MessagerDbContext db;
        public MainForm()
        {
            InitializeComponent();
            db = new MessagerDbContext();

            ApplyDataGridSetting();

            UpdateView(dgvContacts, db.Contacts);
            UpdateView(dgvMessages, db.Messages);
        }

        private void ApplyDataGridSetting()
        {
            dgvContacts.ReadOnly = true;
            dgvContacts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContacts.MultiSelect = false;
            dgvContacts.AutoGenerateColumns = false;

            dgvMessages.ReadOnly = true;
            dgvMessages.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMessages.MultiSelect = false;
            dgvMessages.AutoGenerateColumns = false;
        }

        private void UpdateView(DataGridView dgv,IEnumerable<object> list,bool save = false)
        {
            dgv.DataSource = null;
            if (save) db.SaveChanges();
            dgv.DataSource =list.ToList();
        }

        #region Contacts

        private async void btnContactsSave_Click(object sender, EventArgs e)
        {
            if (dgvContacts.SelectedRows.Count == 0) return;
            Contact contact = dgvContacts.SelectedRows[0].DataBoundItem as Contact;
            if (contact == null) return;
            contact.Firstname = edContactFirstname.Text;
            contact.Lastname = edContactLastname.Text;
            contact.Desctiption = edContactDescr.Text;
            contact.Birthday = edContactBirth.Value;
            contact.Email = edContactEmail.Text;
            UpdateView(dgvContacts,db.Contacts,true);
        }

        private async void btnContactsAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edContactFirstname.Text) || string.IsNullOrEmpty(edContactLastname.Text) || string.IsNullOrEmpty(edContactEmail.Text))
            {
                MessageBox.Show("Some important values were left empty","Error");
                return;
            }
            if (db.Contacts.Where(c => c.Email == edContactEmail.Text).Count() != 0)
            {
                MessageBox.Show("Such e-mail is already in use", "Error");
                return;
            }
            Contact newContact = new Contact()
            {
            Firstname = edContactFirstname.Text,
            Lastname = edContactLastname.Text,
            Email = edContactEmail.Text,
            Birthday = edContactBirth.Value,
            Desctiption = edContactDescr.Text
            };
            btnContactsAdd.Enabled = false;
            try
            {
                await db.Contacts.AddAsync(newContact);
                UpdateView(dgvContacts, db.Contacts, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                btnContactsAdd.Enabled = true;
            }
        }

        private void btnContactsDelete_Click(object sender, EventArgs e)
        {
            if (dgvContacts.SelectedRows.Count == 0) return;
            Contact contact = dgvContacts.SelectedRows[0].DataBoundItem as Contact;
            if (contact == null) return;
            var dialog = MessageBox.Show("Delete contact?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog != DialogResult.Yes) return;
            btnContactsDelete.Enabled = false;
            try
            {
                db.Contacts.Remove(contact);
                UpdateView(dgvContacts, db.Contacts, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                btnContactsDelete.Enabled = true;
            }
        }

        private void btnContactsUpdate_Click(object sender, EventArgs e) => UpdateView(dgvContacts, db.Contacts);

        private void dgvContacts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvContacts.SelectedRows.Count == 0) return;
            Contact contact = dgvContacts.SelectedRows[0].DataBoundItem as Contact;
            if (contact == null) return;
            edContactFirstname.Text = contact.Firstname;
            edContactLastname.Text = contact.Lastname;
            edContactDescr.Text = contact.Desctiption;
            edContactBirth.Value = contact.Birthday;
            edContactEmail.Text = contact.Email;
        }

        #endregion

        #region Messages

        private void dgvMessages_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMessages.SelectedRows.Count == 0) return;
            MessageHistory message = dgvMessages.SelectedRows[0].DataBoundItem as MessageHistory;
            if (message == null) return;
            edMessagesContactId.Value = message.ContactId;
            edMessagesDate.Value = message.DateOf;
            edMessagesText.Text = message.Message;
        }

        private async void btnMessagesAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edMessagesText.Text))
            {
                MessageBox.Show("Some important values were left empty", "Error");
                return;
            }
            MessageHistory message = new MessageHistory() 
            {
            ContactId = (int)edMessagesContactId.Value,
            DateOf = edMessagesDate.Value,
            Message = edMessagesText.Text
            };
            btnMessagesAdd.Enabled = false;
            try
            {
                await db.Messages.AddAsync(message);
                UpdateView(dgvMessages, db.Messages, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                btnMessagesAdd.Enabled = true;
            }
        }

        private void btnMessagesDelete_Click(object sender, EventArgs e)
        {
            if (dgvMessages.SelectedRows.Count == 0) return;
            MessageHistory message = dgvMessages.SelectedRows[0].DataBoundItem as MessageHistory;
            if (message == null) return;
            var dialog = MessageBox.Show("Delete message?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog != DialogResult.Yes) return;
            btnMessagesDelete.Enabled = false;
            try
            {
                db.Messages.Remove(message);
                UpdateView(dgvMessages, db.Messages, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                btnMessagesDelete.Enabled = true;
            }
        }

        private void btnMessagesUpdate_Click(object sender, EventArgs e) => UpdateView(dgvMessages, db.Messages);

        private void btnMessagesSave_Click(object sender, EventArgs e)
        {
            if (dgvMessages.SelectedRows.Count == 0) return;
            MessageHistory message = dgvMessages.SelectedRows[0].DataBoundItem as MessageHistory;
            if (message == null) return;
            message.ContactId = (int)edMessagesContactId.Value;
            message.DateOf = edMessagesDate.Value;
            message.Message = edMessagesText.Text;
            UpdateView(dgvMessages, db.Messages,true);
        }

        #endregion


    }
}