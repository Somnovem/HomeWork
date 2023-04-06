using System;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;
using StandartChat;


namespace Homework6_1Server
{
    public partial class MainFormChat_Server : Form
    {
        private ChatServer chatter;
        private Regex usernameRegex;
        public MainFormChat_Server()
        {
            InitializeComponent();
            usernameRegex = new Regex("^(?=.{8,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$");
            this.FormClosing += MainFormChat_Server_FormClosing;
        }

        private void MainFormChat_Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            chatter?.Send("ServerClosed", null);
            chatter?.Dispose();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            gbConnection.Enabled = false;
            gbSending.Enabled = true;
            FillMessageTypes();
            chatter = new ChatServer();
            chatter.ErrorEncountered += Chatter_ErrorEncountered;
            chatter.Connect();
            chatter.Start();
        }

        private void FillMessageTypes()
        {
            cbType.Items.Add("Censor");
            cbType.Items.Add("Ban");
            cbType.Items.Add("Timeout");
            cbType.SelectedIndex = 0;
        }

        private void Chatter_ErrorEncountered(string message)
        {
            MessageBox.Show($"Encountered error: {message}");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edMessage.Text))
            {
                MessageBox.Show("Message is empty");
                return;
            }
            string message = $"{(string)cbType.SelectedItem}:{edMessage.Text}";
            string[] settings = message.Split(':');
            if (settings.Length != 2)
            {
                MessageBox.Show("Invalid input!");
                return;
            }
            if (settings[0].Equals("Timeout"))
            {
                string[] timeoutParams = settings[1].Split(' ');
                if (timeoutParams.Length != 2)
                {
                    MessageBox.Show("Invalid command format");
                    return;
                }
                int temp;
                if (!Int32.TryParse(timeoutParams[1], out temp))
                {
                    MessageBox.Show("Invalid timeout format");
                    return;
                }
            }
            else
            {
                if (!usernameRegex.IsMatch(settings[1]))
                {
                    MessageBox.Show("Invalid username format");
                    return;
                }
            }
            chatter.Send(settings[0], settings[1]);
        }
    }
}
