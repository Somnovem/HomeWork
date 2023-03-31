using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework5_1Client
{
    public partial class MainFormRPS_Client : Form
    {
        private TcpConnection connection;
        private int wins;
        private int losses;
        private int rounds;
        private string[] choices;
        private string choice;
        private bool isPlayerInControl;
        private ManualResetEvent choiceAwaiter;
        public MainFormRPS_Client()
        {
            InitializeComponent();
            connection = null;
            this.FormClosing += MainFormRPS_Client_FormClosing;
            this.Icon = new Icon(@"..\..\icon.ico");
        }

        private void MainFormRPS_Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection?.Disconnect();
        }

        private void UpdateChoices() 
        {
            cbOptions.Items.Clear();
            cbOptions.Items.AddRange(choices);
            cbOptions.SelectedIndex = 0;
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            string mode = "";
            if (rbPlayerPlayer.Checked)
            {
                isPlayerInControl = true;
                mode = "Player";
            }
            else if (rbPlayerPC.Checked)
            {
                isPlayerInControl = true;
                mode = "PC";
            }
            else  
            {
                isPlayerInControl = false;
                mode = "PC";
            }
            lbMessages.Items.Clear();
            connection = new TcpConnection(IPAddress.Parse(edRemoteAddress.Text), (int)edRemotePort.Value);
            bool connected = false;
            gbConnection.Enabled = false;
            while (!connected)
            {
                connection.Connect();
                try
                {
                    await connection.SendMessage(mode);
                }
                catch 
                {
                    Thread.Sleep(500);
                    continue;
                }
                connected = true;
            }

            lblState.Text = "Waiting for an opponent...";
            string initialMessage = await connection.ReceiveMessage(); 
            choiceAwaiter = new ManualResetEvent(false);
            string options = await connection.ReceiveMessage(); 
            choices = options.Split(' ');
            UpdateChoices();
            Task.Run(StartGame);
        }

        private void UpdateStats(bool isFinal = false) 
        {
            InvokeAction(() => 
            {
                lblLosses.Text = losses.ToString();
                lblWins.Text = wins.ToString();
                if(!isFinal)lblRound.Text = rounds.ToString();
            });
        }


        private void InvokeAction(Action a) 
        {
            if (InvokeRequired) Invoke(a);
            else a();
        }

        private async void StartGame()
        {
            wins = 0;
            losses = 0;
            rounds = 1;
            bool tied = false;
            InvokeAction(() => { lblState.Text = "Game in progress..."; gbChoice.Enabled = isPlayerInControl; gbGame.Enabled = true; });
            Thread.Sleep(300);
            Random rng = null;
            if (!isPlayerInControl) 
            {
                rng = new Random();
            }
            while (rounds <=5)
            {
                try
                {
                    UpdateStats();
                    InvokeAction(() => { lblState.Text = "Take your pick..."; });
                    if (isPlayerInControl)
                    {
                        if(btnOfferTie.Enabled == false) InvokeAction(() => { btnOfferTie.Enabled = true; btnLose.Enabled = true; });
                        choiceAwaiter.WaitOne();
                        choiceAwaiter.Reset();
                    }
                    else
                    {
                        Thread.Sleep(1000);
                        choice = choices[rng.Next(0, choices.Length)];
                        InvokeAction(() => { lbMessages.Items.Insert(0, $"me >> {choice}"); });
                        Thread.Sleep(1000);
                    }
                    await connection.SendMessage(choice);
                    InvokeAction(() => { lblState.Text = "Waiting for the opponent to pick..."; });
                    string response = await connection.ReceiveMessage();
                    #region Analyzing response
                    if ("Tie".Equals(response))
                    {
                        tied = true;
                        break;
                    }
                    else if ("Request to tie".Equals(response))
                    {
                        var dialogResult = MessageBox.Show("Opponent requested to tie", "Message", MessageBoxButtons.YesNo);
                        string tieResult = dialogResult == DialogResult.Yes ? "Yes" : "No";
                        await connection.SendMessage(tieResult);
                        string tieResponse = await connection.ReceiveMessage();
                        if (tieResponse == "Tie")
                        {
                            tied = true;
                            break;
                        }
                        else response = tieResponse;
                    }
                    else if ("Request denied".Equals(response))
                    {
                        InvokeAction(() => 
                        {
                            gbChoice.Enabled = true;
                            btnOfferTie.Enabled = false;
                            btnLose.Enabled = false;
                        });
                        choiceAwaiter.WaitOne();
                        choiceAwaiter.Reset();
                        await connection.SendMessage(choice);
                        response = await connection.ReceiveMessage();
                    }
                    else if ("Surrender".Equals(response))
                    {
                        losses = 6;
                        rounds = 5;
                        break;
                    }
                    else if ("Opponent surrendered".Equals(response))
                    {
                        wins = 6;
                        rounds = 5;
                        break;
                    }
                    InvokeAction(() => { lbMessages.Items.Insert(0, $"Server >> {response}"); });
                    string result = response.Split(':')[1];
                    if (result[0] == 'W') wins++;
                    else if (result[0] == 'L') losses++;
                    if (isPlayerInControl) InvokeAction(() => { gbChoice.Enabled = true; });
                    #endregion
                    rounds++;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Opposing player disconnected!");
                    rounds = 5;
                    wins = 6;
                    break;
                }
            }
            UpdateStats(true);
            InvokeAction(() => { lblState.Text = "Game ended..."; });
            EndGame(tied);
        }

        private void EndGame(bool tied) 
        {
            if (tied) MessageBox.Show("Agreeed to a tie");
            else
            {
                if (wins > losses) MessageBox.Show("You won!Congratulations!");
                else if (wins < losses) MessageBox.Show("You lost!Try beter next time!");
                else MessageBox.Show("Tie!");
            }

            InvokeAction(() =>
            {
                gbChoice.Enabled = false;
                gbConnection.Enabled = true;
                gbGame.Enabled = false;
            });
        }

        private void AcceptChoice(string choice)
        {
            this.choice = choice;
            lbMessages.Items.Insert(0, $"me >> {choice}");
            choiceAwaiter.Set();
            gbChoice.Enabled = false;
        } 

        private void btnSend_Click(object sender, EventArgs e)
        {
            AcceptChoice((string)cbOptions.SelectedItem);
        }

        private void btnOfferTie_Click(object sender, EventArgs e)
        {
            AcceptChoice("Tie");
        }

        private void btnLose_Click(object sender, EventArgs e)
        {
            AcceptChoice("Surrender");
        }
    }
}