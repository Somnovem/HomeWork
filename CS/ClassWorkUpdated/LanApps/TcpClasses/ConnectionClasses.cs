using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace TcpClasses
{
    public class TcpClientConnection
    {

        private static int clientConnectionCount = 0;
        private int clientId;
        public int ClientId { get => clientId; }
        private TcpClient client;
        public IPEndPoint Adress { get; private set; }
        private bool isComputerHandled = false;
        public string Response;
        public ManualResetEvent eventHandled = new ManualResetEvent(false);
        private static List<string> generatedResponses;

        public delegate void MessageDelegate(TcpClientConnection clientConnection, string message);
        public delegate void ConnectionStateChangedDelegate(TcpClientConnection clientConnection, bool isConnected);
        public delegate void ResponseTextRequiredDelegate(TcpClientConnection clientConnection);

        public event MessageDelegate MessageText;
        public event ResponseTextRequiredDelegate ResponseRequested;
        public event ConnectionStateChangedDelegate ConnectionStateChanged;

        public TcpClientConnection(TcpClient client)
        {
            if (client == null)
                throw new ArgumentNullException("client has to be initialized");
            this.client = client;
            clientId = ++clientConnectionCount;
            Adress = client.Client.RemoteEndPoint as IPEndPoint;
            if (generatedResponses == null) GenerateResponses();
            ConnectionStateChanged?.Invoke(this, true);
        }

        private static void GenerateResponses()
        {
            generatedResponses = new List<string>();
            generatedResponses.Add("Yes");
            generatedResponses.Add("No");
            generatedResponses.Add("Certainly");
            generatedResponses.Add("Maybe");
            generatedResponses.Add("Maybe later");
            generatedResponses.Add("Perhaps yes");
            generatedResponses.Add("Perhaps no");
        }

        public async void StartMessaging()
        {
            NetworkStream ns = client.GetStream();
            string parameter = await ReceiveString(ns);
            isComputerHandled = bool.Parse(parameter);
            MessageText?.Invoke(this,$"Server is computer handled: {isComputerHandled}");
            while (true)
            {
                string query = await ReceiveString(ns);
                MessageText?.Invoke(this, query);
                if (query.ToLower().Equals("bye"))
                {
                    await SendString(ns, "Goodbye!");
                    break;
                }
                string answer = "";
                if (isComputerHandled)
                {
                    answer = generatedResponses[new Random().Next(0,generatedResponses.Count)];
                    MessageText?.Invoke(this,$"Server responded: {answer}");
                }
                else
                {
                    ResponseRequested?.Invoke(this);
                    eventHandled.WaitOne();
                    eventHandled.Reset();
                    answer = Response;
                    if (answer.ToLower().Equals("bye"))
                    {
                        await SendString(ns, "Goodbye!");
                        break;
                    }
                }
                await SendString(ns, answer);
            }
            client.Close();
            ConnectionStateChanged?.Invoke(this, false);
        }
        public Task StartMessagingAsync() => Task.Run(StartMessaging);

        private async Task SendString(NetworkStream stream, string message)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            await stream.WriteAsync(data, 0, data.Length);
        }

        public async Task<string> ReceiveString(NetworkStream stream)
        {
            StringBuilder builder = new StringBuilder();
            int bytes = 0;
            byte[] data = new byte[256];
            try
            {
                do
                {
                    bytes = await stream.ReadAsync(data, 0, data.Length);
                    builder.Append(Encoding.UTF8.GetString(data, 0, bytes));
                } while (stream.DataAvailable);
                return builder.ToString();
            }
            catch (Exception ex)
            {
                return $"Encountered error: {ex.Message}";
            }

        }
    }



    public class TCPServer
    {
        private TcpListener listener;
        private int port;
        private IPAddress address;
        private List<TcpClientConnection> connectedClients;

        public delegate void StringMessageDelegate(string message);
        public event StringMessageDelegate StringMessage;

        public delegate void ResponseRequestedDelegate(TcpClientConnection client);
        public event ResponseRequestedDelegate RequestedResponse;
        public TCPServer(IPAddress address, int port)
        {
            this.listener = null;
            this.port = port;
            this.address = address;
            connectedClients = null;
        }
        public Task StartListenAsync() => Task.Run(StartListen);
        public async void StartListen()
        {
            if (listener != null)
            {
                return;
            }
            listener = new TcpListener(address, port);
            connectedClients = new List<TcpClientConnection>();
            listener.Start();
            StringMessage?.Invoke("Server started! Accepting connections...");

            while (true)
            {
                TcpClient client = await listener.AcceptTcpClientAsync();


                StringMessage?.Invoke($"Accepted: {client.Client.RemoteEndPoint}");

                TcpClientConnection clientConnection = new TcpClientConnection(client);
                connectedClients.Add(clientConnection);
                clientConnection.MessageText += ClientConnection_MessageText;
                clientConnection.ConnectionStateChanged += ClientConnection_ConnectionStateChanged;
                clientConnection.ResponseRequested += ClientConnection_ResponseRequested;
                _ = clientConnection.StartMessagingAsync();
            }

        }

        private void ClientConnection_ResponseRequested(TcpClientConnection clientConnection)
        {
            RequestedResponse?.Invoke(clientConnection);
        }

        private void ClientConnection_ConnectionStateChanged(TcpClientConnection clientConnection, bool isConnected)
        {
            if (isConnected)
                StringMessage?.Invoke($"Client {clientConnection.Adress} is connected!");
            else
            {
                StringMessage?.Invoke($"Client {clientConnection.Adress} is disconnected!");
                connectedClients.Remove(clientConnection);
            }
        }

        private void ClientConnection_MessageText(TcpClientConnection clientConnection, string message)
        {
            StringMessage?.Invoke($"{clientConnection.Adress} >> {message}");
        }

        public void StopListen()
        {
            if (listener != null)
            {
                if (connectedClients != null)
                {
                    connectedClients.Clear();
                }
                listener.Stop();
                listener = null;
                StringMessage?.Invoke("Server stopped!");
            }
        }
    }

    public class TcpConnection
    {
        private readonly TcpClient client;
        private IPAddress address;
        private int port;
        public delegate void ErrorEncounteredDelegate(string errorMessage);
        public event ErrorEncounteredDelegate ErrorEncountered;
        public TcpConnection(IPAddress address, int port)
        {
            client = new TcpClient();
            this.address = address;
            this.port = port;
        }

        public void Connect()
        {
            try
            {
                client.Connect(address, port);
            }
            catch (Exception ex)
            {
                ErrorEncountered?.Invoke($"Encountered error: {ex.Message}");
            }
        }

        public void Disconnect()
        {
            try
            {
                SendMessage("exit");
                Thread.Sleep(1000);
                client.Close();
            }
            catch (Exception ex)
            {
                ErrorEncountered?.Invoke($"Encountered error: {ex.Message}");
            }
        }

        public async void SendMessage(string message)
        {
            await SendString(client.GetStream(), message);
        }
        public async Task<string> ReceiveMessage()
        {
            return await ReceiveString(client.GetStream());
        }
        private async Task SendString(NetworkStream stream, string message)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            try
            {
                await stream.WriteAsync(data, 0, data.Length);
            }
            catch 
            {
                Disconnect();
            }
            
        }

        private async Task<string> ReceiveString(NetworkStream stream)
        {
            StringBuilder builder = new StringBuilder();
            int bytes = 0;
            byte[] data = new byte[256];
            do
            {
                try
                {
                    bytes = await stream.ReadAsync(data, 0, data.Length);
                }
                catch
                {

                }
                builder.Append(Encoding.UTF8.GetString(data, 0, bytes));
            } while (stream.DataAvailable);
            return builder.ToString();
        }
    }
}
