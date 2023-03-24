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
using TcpClasses;
namespace Homework2_3Server
{
    public partial class MainFormTcpDialogServer : Form
    {
        private TCPServer server;
        private bool sendRequested = false;
        public MainFormTcpDialogServer()
        {
            InitializeComponent();
            server = new TCPServer(IPAddress.Any, 1000);
            server.StringMessage += Server_StringMessage;
            server.RequestedResponse += Server_RequestedResponse;
        }

        private void Server_RequestedResponse(TcpClientConnection client)
        {
           InvokeAction(() => { gbSending.Enabled = true; });
           while (true)
           {
               if (sendRequested)
               {
                   client.Response = edMessage.Text;
                   sendRequested = false;
                   client.eventHandled.Set();
                   break;
               }
           }
           InvokeAction(() => { gbSending.Enabled = false; });
        }

        private void InvokeAction(Action action) 
        {
            if (InvokeRequired) Invoke(action);
            else action();
        }

        private void Server_StringMessage(string message)
        {
            Action a = () => 
            {
                lbMessages.Items.Insert(0,message);
            };
            if (InvokeRequired) Invoke(a);
            else a();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _ = server.StartListenAsync();
            btnStart.Enabled = false;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            sendRequested = true;
            lbMessages.Items.Insert(0,$"server >> {edMessage.Text}");
        }
    }
}
