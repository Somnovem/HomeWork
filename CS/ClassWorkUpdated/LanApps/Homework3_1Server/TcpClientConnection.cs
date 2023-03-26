using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Data.SQLite;
using System.Windows.Forms;
using Timer = System.Timers.Timer;
using System.Reflection;

namespace Homework3_1Server
{
    internal class TcpClientConnection
    {
        private static int clientConnectionCount = 0;
        private int clientId;
        public int ClientId { get => clientId; }
        private TcpClient client;
        public IPEndPoint Adress { get; private set; }

        private static Dictionary<string, string> currencyInfo;
        private static string currencies = "";
        private int requestsPerClient;
        private int counter;
        private bool serverOverflow;
        private Timer regainRequestsTimer;

        public delegate void MessageDelegate(TcpClientConnection clientConnection, string message);
        public delegate void ServerResponseDelegate(string message);
        public delegate void ConnectionStateChangedDelegate(TcpClientConnection clientConnection, bool isConnected);

        public event MessageDelegate MessageText;
        public event ConnectionStateChangedDelegate ConnectionStateChanged;
        public event ServerResponseDelegate ServerResponse;


        public TcpClientConnection(TcpClient client, int requestsPerClient, bool serverOverflow)
        {
            if (client == null)
                throw new ArgumentNullException("client has to be initialized");
            this.client = client;
            clientId = ++clientConnectionCount;
            Adress = client.Client.RemoteEndPoint as IPEndPoint;
            ConnectionStateChanged?.Invoke(this, true);
            this.requestsPerClient = requestsPerClient;
            this.serverOverflow = serverOverflow;
        }
        public async void StartMessaging()
        {
            NetworkStream ns = client.GetStream();
            bool connectionCanceled = false;
            string[] credentials = (await ReceiveString(ns)).Split(' ');
            if (serverOverflow) // Server was overflown, deny connection
            {
                await SendString(ns, "Server is overflown. Try again later");
                connectionCanceled = true;
            }
            else //// Check if credentials are valid
            {
                var connectionString = @"Data Source=..\..\credentials.db;Version=3;";
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    var selectCommand = new SQLiteCommand(
                        "SELECT Password FROM Logins WHERE Login = @username",
                        connection
                    );
                    selectCommand.Parameters.AddWithValue("@username", credentials[0]);
                    string response = (string)selectCommand.ExecuteScalar();
                    if (string.IsNullOrEmpty(response))
                    {
                        await SendString(ns, "Access denied.Invalid login or password");
                        connectionCanceled = true;
                    }
                }
            }
            if (!connectionCanceled) // All settings valid, start normal connection
            {
                if (currencyInfo == null)
                {
                    GetCurrencyInfo();
                    foreach (string code in currencyInfo.Keys)
                    {
                        currencies += $"{code} ";
                    }
                }
                await SendString(ns, currencies);
                counter = requestsPerClient;
                while (true)
                {
                    string query = await ReceiveString(ns);
                    if (counter > 0)
                    {
                        MessageText?.Invoke(this, query);
                        if (query.ToLower().Equals("exit"))
                        {
                            break;
                        }
                        string[] codes = query.Split(' ');
                        decimal firstRate = decimal.Parse(currencyInfo[codes[0]]);
                        decimal secondRate = decimal.Parse(currencyInfo[codes[1]]);
                        decimal amplifier = 1 / firstRate;
                        string message = $"For 1 {codes[0]} you get {(secondRate * amplifier).ToString().Substring(0, 8)} {codes[1]}";
                        await SendString(ns, message);
                        ServerResponse?.Invoke(message);
                        counter--;
                    }
                    else if (counter == 0)
                    {
                        await SendString(ns, "You reached your limit.Try again in a minute!");
                        if (regainRequestsTimer == null)
                        {
                            regainRequestsTimer = new Timer();
                            regainRequestsTimer.Interval = 60000;
                            regainRequestsTimer.Elapsed += RegainRequestsTimer_Tick;
                            regainRequestsTimer.Start();
                        }
                    }
                    else
                    {
                        break; // Connection was closed
                    }

                }
            }
            client.Close();
            ConnectionStateChanged?.Invoke(this, false);
        }

        private void RegainRequestsTimer_Tick(object sender, EventArgs e)
        {
            counter = requestsPerClient;
            regainRequestsTimer = null;
        }

        public Task StartMessagingAsync() => Task.Run(StartMessaging);
        
        private void GetCurrencyInfo()
        {
            string jsonString = File.ReadAllText("../../currencies.json");

            // Parse JSON string into JObject
            JObject obj = JObject.Parse(jsonString);

            // Extract currency data into a list of dictionaries
            List<Dictionary<string, string>> currencies = obj.Properties()
                .Select(p => new Dictionary<string, string>
                {
                    { "code", p.Value["code"].ToString() },
                    { "rate", p.Value["rate"].ToString() }
                }).ToList();

            currencyInfo = new Dictionary<string, string>();
            foreach (var currency in currencies)
            {
                currencyInfo.Add(currency["code"], currency["rate"]);
            }
        }

        private async Task SendString(NetworkStream stream, string message)
        {
            try
            {
                byte[] data = Encoding.UTF8.GetBytes(message);
                await stream.WriteAsync(data, 0, data.Length);
            }
            catch (Exception)
            {
                counter = -1; //Signal that server was closed
            }

            
        }

        private async Task<string> ReceiveString(NetworkStream stream)
        {
            StringBuilder builder = new StringBuilder();
            int bytes = 0;
            byte[] data = new byte[256];
            try
            {
                bytes = await stream.ReadAsync(data, 0, data.Length);
                do
                {

                    builder.Append(Encoding.UTF8.GetString(data, 0, bytes));
                } while (stream.DataAvailable);
                
            }
            catch (Exception)
            {

                counter = -1;//Signal that server was closed
            }
            return builder.ToString();
        }
    }
}
