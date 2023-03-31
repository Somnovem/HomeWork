using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
namespace LanApp6_1ScreenClient
{
    public partial class MainFromScreen_Client : Form
    {
        public MainFromScreen_Client()
        {
            InitializeComponent();
        }

        private void btnGetScreen_Click(object sender, EventArgs e)
        {
            using (TcpClient tcp = new TcpClient())
            {
                tcp.Connect(new IPEndPoint(IPAddress.Parse(edAdress.Text), (int)edPort.Value));
                NetworkStream ns = tcp.GetStream();
                edScreen.Image = Image.FromStream(ns);
            }
        }
    }
}
