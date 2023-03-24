using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleCommand;
using CommandType = ConsoleCommand.CommandType;



//Homework 2
//Task 2
//Client in WinForms
//Server -> Practice2_1Server
namespace Homework2_2Client
{
    public partial class MainFormCommandsWinForms : Form
    {
        public MainFormCommandsWinForms()
        {
            InitializeComponent();
        }
        private Socket socket;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Parse(edRemoteAdress.Text), (int)edRemotePort.Value);
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            bool couldConnect = false;
            try
            {
                socket.Connect(remoteEndPoint);
                couldConnect = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Encountered error: {ex.Message}");
            }
            if (!couldConnect) Environment.Exit(-1);
            MessageBox.Show("Successfully connected to the server");
            gbConnection.Enabled = false;
            gbSending.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (lbMessages.Items.Count != 0) lbMessages.Items.Clear();
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edMessage.Text)) return;
            string request = edMessage.Text;
            byte[] data = null;
            string[] parameters = request.Split(' ').ToArray();
            CommandType currentType = CommandType.date;
            object content = null;
            try
            {
                currentType = (CommandType)Enum.Parse(typeof(CommandType), parameters[0]);
            }
            catch (ArgumentException)
            {
                MessageBox.Show($"{request} is not a recognisable command");
                return;
            }

            switch (currentType)
            {
                case CommandType.date:
                    break;
                case CommandType.time:
                    break;
                case CommandType.datetime:
                    break;
                case CommandType.exec:
                    content = parameters[1];
                    break;
                case CommandType.sort:
                    List<int> arr = new List<int>();
                    foreach (var item in parameters.Skip(1))
                    {
                        arr.Add(int.Parse(item));
                    }
                    content = arr;
                    break;
                case CommandType.numcurthreads:
                    break;
                case CommandType.cpuusage:
                    break;
                case CommandType.numcores:
                    break;
                case CommandType.help:
                    break;
                case CommandType.exit:
                    break;
                default:
                    break;
            }

            var formatter = new BinaryFormatter();
            var memoryStream = new MemoryStream();
            formatter.Serialize(memoryStream, new Command(currentType, content));
            var bytes = memoryStream.ToArray();

            socket.Send(bytes);
            lbMessages.Items.Insert(0, $"me >> {request}");
            StringBuilder stringBuilder = new StringBuilder();
            int len = 0;
            data = new byte[256];
            do
            {
                len = socket.Receive(data);
                stringBuilder.Append(Encoding.UTF8.GetString(data, 0, len));
            } while (socket.Available > 0);
            lbMessages.Items.Insert(0,$"Incoming at ({DateTime.Now.ToLongTimeString()})>> {stringBuilder.ToString()}");
        }
    }
}
