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
using Chatters;
namespace Practice4_2Client
{
    public partial class MainFormBroadcast_Client : Form
    {
        private static string defaultTypes = "Advertisements Offers Announcements Files Images Standart";
        public MainFormBroadcast_Client()
        {
            InitializeComponent();
            clbTypes.Items.AddRange(defaultTypes.Split(' '));
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            IPAddress temp;
            if (!IPAddress.TryParse(edAddress.Text,out temp))
            {
                MessageBox.Show("Invalid IP format");
            }
            List<string> types = new List<string>();
            for (int i = 0; i < clbTypes.Items.Count; i++)
            {
                if (clbTypes.GetItemChecked(i))
                {
                    types.Add((string)clbTypes.Items[i]);
                }
            }
            if (types.Count == 0)
            {
                MessageBox.Show("No message type chosen");
                return;
            }
            btnConnect.Enabled = false;
            clbTypes.Enabled = false;
            BroadcastChatter chatter = new BroadcastChatter();
            chatter.MessageReceived += Chatter_MessageReceived; ;
            chatter.GotKicked += Chatter_GotKicked;
            Task.Run(() => chatter.Start(edAddress.Text, (int)edPort.Value, types.ToArray()));
        }

        public void InvokeAction(Action a)
        {
            if (InvokeRequired) Invoke(a);
            else a();
        }

        private void Chatter_GotKicked()
        {
            InvokeAction(() => { lbMessages.Items.Insert(0,"Was kicked from the server"); });
        }

        private void Chatter_MessageReceived(string message)
        {
            InvokeAction(() => { lbMessages.Items.Insert(0, message); });
        }
    }
}
