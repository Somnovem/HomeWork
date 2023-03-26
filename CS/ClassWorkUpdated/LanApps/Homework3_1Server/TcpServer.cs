using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QueueLogger = Loggers.QueueLogger;
namespace Homework3_1Server
{
    internal class TCPServer : IDisposable
    {
        private TcpListener listener;
        private int port;
        private IPAddress address;
        private List<TcpClientConnection> connectedClients;
        private int maxConcurrentClients;
        private int requestsPerClient;
        private QueueLogger logger;
        private string connectionString;

        public delegate void StringMessageDelegate(string message);
        public event StringMessageDelegate StringMessage;


        public TCPServer(IPAddress address, int port, int maxConcurrentClients, int requestsPerClient, string connectionString)
        {
            this.listener = null;
            this.port = port;
            this.address = address;
            connectedClients = null;
            this.maxConcurrentClients = maxConcurrentClients;
            this.requestsPerClient = requestsPerClient;
            logger = new QueueLogger();
            this.connectionString = connectionString;
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
            logger.AddToQueue($"{DateTime.Now} Server started! Accepting connections...");
            TcpClient client;
            while (true)
            {
                try
                {
                    client = await listener.AcceptTcpClientAsync();
                }
                catch (Exception)
                {
                    //listener was disposed
                    break;
                }
                


                StringMessage?.Invoke($"Accepted: {client.Client.RemoteEndPoint}");
                logger.AddToQueue($"{DateTime.Now} Accepted: {client.Client.RemoteEndPoint}");
                bool isServerOverflown = connectedClients.Count == maxConcurrentClients;
                TcpClientConnection clientConnection = new TcpClientConnection(client,requestsPerClient, isServerOverflown,connectionString);
                connectedClients.Add(clientConnection);
                clientConnection.MessageText += ClientConnection_MessageText;
                clientConnection.ServerResponse += ClientConnection_ServerResponse;
                clientConnection.ConnectionStateChanged += ClientConnection_ConnectionStateChanged;
                _ = clientConnection.StartMessagingAsync();
            }

        }

        private void ClientConnection_ServerResponse(string message)
        {
            StringMessage?.Invoke($"server >> {message}");
            logger.AddToQueue($"{DateTime.Now} server >> {message}");
        }

        private void ClientConnection_ConnectionStateChanged(TcpClientConnection clientConnection, bool isConnected)
        {
            string connectedStatus = isConnected ? $"Client {clientConnection.Adress} is connected!" : $"Client {clientConnection.Adress} is disconnected!";
            logger.AddToQueue($"{DateTime.Now} {connectedStatus}");
            StringMessage?.Invoke(connectedStatus);
            connectedClients.Remove(clientConnection);
        }

        private void ClientConnection_MessageText(TcpClientConnection clientConnection, string message)
        {
            StringMessage?.Invoke($"{clientConnection.Adress} >> {message}");
        }

        public void StopListen()
        {
            if (listener != null)
            {
                if (connectedClients != null) connectedClients.Clear();
                listener.Stop();
                listener = null;
                StringMessage?.Invoke("Server stopped!");
                logger.AddToQueue($"{DateTime.Now} Server stopped!");
                logger.Log();
            }
        }

        public void Dispose()
        {
            this.StopListen();
        }
    }
}
