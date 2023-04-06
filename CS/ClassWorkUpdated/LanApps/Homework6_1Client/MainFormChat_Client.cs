using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using StandartChat;
using System.IO;

namespace Homework6_1Client
{
    public partial class MainFormChat_Client : Form
    {
        private static string settingsPath = @"..\..\Settings.txt";
        private ChatClient chatter;
        private Regex usernameRegex;
        private Regex passwordRegex;
        private bool isBanned;
        private bool isTimedOut;
        private List<string> myTeams;
        private int timeOutRemaining;
        private Timer timeOutTimer;
        private Timer connectionTimer;
        public MainFormChat_Client()
        {
            LoadSettings();
            this.FormClosing += MainFormChat_Client_FormClosing;
            InitializeComponent();
            usernameRegex = new Regex("^(?=.{8,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$");
            passwordRegex = new Regex("^(?=.{8,24}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$");
            FillMessageTypes();
        }

        private void LoadSettings()
        {
            myTeams = new List<string>();
            if (File.Exists(settingsPath))
            {
                string[] lines = File.ReadAllLines(settingsPath);
                try
                {
                    isBanned = bool.Parse(lines[0]);
                }
                catch 
                {
                    isBanned = true;
                }
                try
                {
                    timeOutRemaining = Int32.Parse(lines[1]);
                }
                catch 
                {
                    timeOutRemaining = 3600000;
                }
                for (int i = 2; i < lines.Length; i++)
                {
                    myTeams.Add(lines[i]);
                }
                if (timeOutRemaining > 0)
                {
                    TimeOut(timeOutRemaining);
                }
                else isTimedOut = false;
            }
            else
            {
                isBanned = false;
                timeOutRemaining = 0;
                isTimedOut = false;
            }
        }

        private void MainFormChat_Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(settingsPath))
            {
                writer.WriteLine(isBanned.ToString());
                writer.WriteLine(timeOutRemaining.ToString());
                for (int i = 0; i < myTeams.Count; i++)
                {
                    writer.WriteLine(myTeams[i]);
                }
            }
        }

        private void FillMessageTypes()
        {
            cbType.Items.Add("Broadcast");
            cbType.Items.Add("Whisper");
            cbType.Items.Add("WhisperGroup");
            cbType.Items.Add("CreateRoom");
            cbType.Items.Add("JoinRoom");
            cbType.Items.Add("LeaveRoom");
            cbType.SelectedIndex = 0;
        }


        private bool SetupConnection()
        {
            if (!usernameRegex.IsMatch(edLogin.Text))
            {
                MessageBox.Show("Invalid username format");
                return false;
            }
            if (!passwordRegex.IsMatch(edPassword.Text))
            {
                MessageBox.Show("Invalid password format");
                return false;
            }
            gbConnection.Enabled = false;
            

            connectionTimer = new Timer();
            connectionTimer.Interval = 60000;
            connectionTimer.Tick += ConnectionTimer_Tick;
            connectionTimer.Start();

            SetupChatter();

            chatter.ListenClients();
            return true;
        }

        private void SetupChatter()
        {
            chatter = new ChatClient(edLogin.Text);
            chatter.WhiserMessageReceived += Chatter_WhiserMessageReceived;
            chatter.RoomMessageReceived += Chatter_RoomMessageReceived;
            chatter.BroadcastMessageReceived += Chatter_BroadcastMessageReceived;
            chatter.GotBanned += Chatter_GotBanned;
            chatter.GotTimedOut += Chatter_GotTimedOut;
            chatter.ErrorEncountered += Chatter_ErrorEncountered;
            chatter.LoginResultEvent += Chatter_LoginResultEvent;
            chatter.RoomResultEvent += Chatter_RoomResultEvent;
            chatter.ServerClosed += Chatter_ServerClosed;
        }

        private void Chatter_ServerClosed()
        {
            gbConnection.Enabled = false;
            gbSending.Enabled = false;
            MessageBox.Show("Server was closed");
        }

        private void ConnectionTimer_Tick(object sender, EventArgs e)
        {
            if (!gbSending.Enabled)
            {
                chatter.Dispose();
                gbConnection.Enabled = true;
                MessageBox.Show("Couldn't connect to the server or get response from it");
            }
            connectionTimer = null;
        }

        private void Chatter_LoginResultEvent(bool successful, string message)
        {
            if (successful)
            {
                gbSending.Enabled = true;
            }
            else
            {
                MessageBox.Show(message);
                chatter.Dispose();
                gbConnection.Enabled = true;
            }
            connectionTimer.Stop();
            connectionTimer.Dispose();
            connectionTimer = null;
        }

        private void Chatter_RoomResultEvent(bool successful, string message)
        {
            if (successful)
            {
                if (((string)cbType.SelectedItem).Equals("LeaveRoom"))
                {
                    if (myTeams.Contains(edMessage.Text)) myTeams.Remove(edMessage.Text);
                    MessageBox.Show("You left the requested room!");
                }
                else
                {
                    if (!myTeams.Contains(edMessage.Text)) myTeams.Add(edMessage.Text);
                    MessageBox.Show("You joined the requested room!");
                }

            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private void Chatter_ErrorEncountered(string message)
        {
            MessageBox.Show(message);
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (SetupConnection())
            {
                chatter.Send("Signup", $"{edLogin.Text} {edLogin.Text}");
            }
            
        }

        private void TimeOut(int miliseconds)
        {
            isTimedOut = true;
            gbSending.Enabled = false;
            timeOutTimer = new Timer();
            timeOutTimer.Interval = miliseconds;
            timeOutRemaining = miliseconds;
            timeOutTimer.Tick += TimeOutTimer_Tick;
            timeOutTimer.Start();
        }

        private void Chatter_GotTimedOut(int timeoutSeconds)
        {
            MessageBox.Show($"You were timed out from the server for {timeoutSeconds} seconds!");
            TimeOut(timeoutSeconds * 1000);
        }

        private void TimeOutTimer_Tick(object sender, EventArgs e)
        {
            isTimedOut = false;
            gbSending.Enabled = true;
            timeOutTimer.Dispose();
            timeOutRemaining = 0;
        }

        private void Chatter_GotBanned()
        {
            isBanned = true;
            MessageBox.Show("You were permanently banned from the server!");
        }

        private void Chatter_BroadcastMessageReceived(string message)
        {
            if (connectionTimer == null && !isBanned && !isTimedOut)
            {
                lbMessages.Items.Add(message);
            }
            
        }

        private void Chatter_RoomMessageReceived(string message)
        {
            if (connectionTimer == null && !isBanned && !isTimedOut)
            {
                if (myTeams.Contains(message.Split('/')[1]))
                {
                    lbMessages.Items.Add(message);
                }
            }
        }

        private void Chatter_WhiserMessageReceived(string message)
        {
            if (connectionTimer == null && !isBanned && !isTimedOut)
            {
                lbMessages.Items.Add(message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (SetupConnection())
            {
                chatter.Send("Login", $"{edLogin.Text} {edPassword.Text}");
            }
            
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
            switch (settings[0])
            {
                case "Broadcast":
                    chatter.Send(settings[0], $"{edLogin.Text} >> {settings[1]}");
                    break;
                case "WhisperGroup":
                    string[] whisperRoomInfo = settings[1].Split(' ');
                    if (whisperRoomInfo.Count() < 2)
                    {
                        MessageBox.Show("Invalid whisper message format");
                        return;
                    }
                    chatter.Send(settings[0], $"{edLogin.Text} whispered to room /{whisperRoomInfo[0]}/>> {whisperRoomInfo[1]}");
                    break;
                case "Whisper":
                    string[] whisperInfo = settings[1].Split(' ');
                    if (whisperInfo.Count() < 2)
                    {
                        MessageBox.Show("Invalid whisper message format");
                        return;
                    }
                    chatter.Send(settings[0], $"{edLogin.Text} whispered to /{whisperInfo[0]}/>> {whisperInfo[1]}");
                    break;
                case "CreateRoom":
                case "JoinRoom":
                case "LeaveRoom":
                    if (!settings[1].IsSingleWord())
                    {
                        MessageBox.Show("Invalid room command format");
                        return;
                    }
                    chatter.Send(settings[0], $"{edLogin.Text} {settings[1]}");
                    break;
                default:
                    break;
            }
            
        }
    }
}
