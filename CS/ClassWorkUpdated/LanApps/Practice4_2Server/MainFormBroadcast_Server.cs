using Chatters;
using Practice4_2Server.Properties;
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

namespace Practice4_2Server
{
    public partial class MainFormBroadcast_Server : Form
    {
        private BroadcastChatter chatter;
        public MainFormBroadcast_Server()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            IPAddress temp;
            if (!IPAddress.TryParse(edAddress.Text, out temp))
            {
                MessageBox.Show("Invalid IP format");
            }
            gbConnection.Enabled = false;
            gbSending.Enabled = true;
            chatter = new BroadcastChatter();
            chatter.ErrorEncountered += Chatter_ErrorEncountered; ;
            chatter.Connect(edAddress.Text, (int)edPort.Value);
            cbType.Items.AddRange(Enum.GetNames(typeof(MessageType)));
            cbType.SelectedIndex = 0;
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
            if (settings[0].ToLower().Equals("exit")) Environment.Exit(0);
            else
            {
                if (settings.Length != 2)
                {
                    MessageBox.Show("Invalid input!");
                    return;
                }
                if (settings[0].Equals("Kick"))
                {
                    IPAddress toKick;
                    if (!IPAddress.TryParse(settings[1], out toKick))
                    {
                        MessageBox.Show("Invalid IP format");
                        return;
                    }
                    chatter.Send(settings[0], settings[1]);
                }
                else chatter.Send(settings[0], settings[1]);
            }
        }

        private void Chatter_ErrorEncountered(string message)
        {
            MessageBox.Show(message);
        }
    }
}
