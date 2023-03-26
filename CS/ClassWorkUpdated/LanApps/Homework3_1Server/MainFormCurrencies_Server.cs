using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
namespace Homework3_1Server
{
    public partial class MainFormCurrencies_Server : Form
    {
        private TCPServer mainServer;
        string connectionString = @"Data Source=..\..\credentials.db;Version=3;";
        public MainFormCurrencies_Server()
        {
            InitializeComponent();
            this.FormClosing += MainFormCurrencies_Server_FormClosing;
            UpdateUserView();

        }

        private void MainFormCurrencies_Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainServer?.Dispose();
        }

        private void ChangeVisualFromAction(Action action) 
        {
            if (InvokeRequired) Invoke(action);
            else action();
        }

        private void Server_StringMessage(string message)
        {
            string datedMessage = $"({DateTime.Now.ToLongTimeString()}){message}";
            ChangeVisualFromAction(() => { lbMessages.Items.Insert(0, datedMessage); });
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            mainServer = new TCPServer(IPAddress.Any, 1000, (int)edMaxClients.Value, (int)edRequestsPerClient.Value);
            mainServer.StringMessage += Server_StringMessage;
            _ = mainServer.StartListenAsync();
            gbSettings.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (lbMessages.Items.Count != 0) lbMessages.Items.Clear();
        }

        private void UpdateUserView() 
        {
            lbUsers.Items.Clear();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var selectCommand = new SQLiteCommand("SELECT Login FROM Logins",connection);
                using (var reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lbUsers.Items.Add(reader.GetString(0));
                    }
                }
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edLogin.Text) || string.IsNullOrEmpty(edPassword.Text))
            {
                MessageBox.Show("Login or password was left empty");
                return;
            }
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                try
                {
                    // Insert new login credentials
                    var insertCommand = new SQLiteCommand(
                        "INSERT INTO Logins (Login, Password) VALUES (@username, @password)",
                        connection
                    );
                    insertCommand.Parameters.AddWithValue("@username", edLogin.Text);
                    insertCommand.Parameters.AddWithValue("@password", edPassword.Text);
                    insertCommand.ExecuteNonQuery();
                    UpdateUserView();
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Login already exists");
                }
            }
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            if (lbUsers.SelectedItem == null) return;
            string selectedLogin = (string)lbUsers.SelectedItem;
            if (MessageBox.Show($"Do you acceept deleting {selectedLogin}?", "Warning", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var deleteCommand = new SQLiteCommand("DELETE FROM Logins WHERE Login = @username", connection);
                deleteCommand.Parameters.AddWithValue("@username", selectedLogin);
                deleteCommand.ExecuteNonQuery();
            }

        }
    }
}
