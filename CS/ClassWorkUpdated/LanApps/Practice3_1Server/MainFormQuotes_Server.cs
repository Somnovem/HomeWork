using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControls;
namespace Practice3_1Server
{
    public partial class MainFormQuotes_Server : Form
    {
        private TCPServer mainServer;
        private string connectionString = @"Data Source=..\..\credentials.db;Version=3;";
        ListBoxMultiline lbMessages;
        public MainFormQuotes_Server()
        {
            InitializeComponent();
            this.Icon = new Icon(@"..\..\icon.ico");
            this.FormClosing += MainFormQuotes_Server_FormClosing;
            lbMessages = new ListBoxMultiline();
            lbMessages.Size = new Size(509, 310);
            lbMessages.Location = new Point(12, 239);
            tabConnection.Controls.Add(lbMessages);
            UpdateUserView();
        }

        private void MainFormQuotes_Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainServer?.Dispose();
        }

        private void ChangeVisualFromAction(Action action)
        {
            if (InvokeRequired) Invoke(action);
            else action();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            mainServer = new TCPServer(IPAddress.Any, 1000, (int)edMaxClients.Value, (int)edRequestsPerClient.Value,connectionString);
            mainServer.StringMessage += MainServer_StringMessage;
            _ = mainServer.StartListenAsync();
            gbSettings.Enabled = false;
        }

        private void MainServer_StringMessage(string message)
        {
            ChangeVisualFromAction(() => { lbMessages.Items.Insert(0, $"({DateTime.Now.ToLongTimeString()}){message}"); });
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
                var selectCommand = new SQLiteCommand("SELECT Login FROM Users", connection);
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
                    var insertCommand = new SQLiteCommand(
                        "INSERT INTO Users (Login, Password) VALUES (@username, @password)",
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
                var deleteCommand = new SQLiteCommand("DELETE FROM Users WHERE Login = @username", connection);
                deleteCommand.Parameters.AddWithValue("@username", selectedLogin);
                deleteCommand.ExecuteNonQuery();
                UpdateUserView();
            }
        }
    }
}
