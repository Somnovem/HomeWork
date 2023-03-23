using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace LanApp4_1TCPListener
{
    internal class TCPServer
    {
        private TcpListener listener;
        private int port;
        private IPAddress address;
        private List<TcpClientConnection> connectedClients;

        public delegate void StringMessageDelegate(string message);
        public event StringMessageDelegate StringMessage;


        public TCPServer(IPAddress address,int port)
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
            listener = new TcpListener(address,port);//просто port, если буде слушать все интерфейсы
            connectedClients = new List<TcpClientConnection>();
            //запуск прослушки
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
                _ = clientConnection.StartMessagingAsync();
            }
            
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
                    //информировать всех юзеров что сервак останавливаеться, либо что там нам нужно
                    //очистить лист
                    connectedClients.Clear();
                }
                listener.Stop();
                listener = null;
                StringMessage?.Invoke("Server stopped!");
            }
        }
    }
}
