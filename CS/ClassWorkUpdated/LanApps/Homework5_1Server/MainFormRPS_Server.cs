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

namespace Homework5_1Server
{
    public partial class MainFormRPS_Server : Form
    {
        private TCPServer mainServer;
        public MainFormRPS_Server()
        {
            InitializeComponent();
            this.FormClosing += MainFormRPS_Server_FormClosing; ;
            this.Icon = new Icon(@"..\..\icon.ico");
        }

        private void MainFormRPS_Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainServer?.Dispose();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            mainServer = new TCPServer(IPAddress.Parse(edAdress.Text), (int)edPort.Value);
            _ = mainServer.StartListenAsync();
            gbSettings.Enabled = false;
        }
    }
}
