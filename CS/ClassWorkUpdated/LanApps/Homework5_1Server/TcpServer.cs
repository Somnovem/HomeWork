using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Threading;
using Timer = System.Windows.Forms.Timer;
namespace Homework5_1Server
{
    internal class TCPServer : IDisposable
    {
        private TcpListener listener;
        private int port;
        private IPAddress address;
        private List<TcpClientConnection> playersLobby;
        public TCPServer(IPAddress address, int port)
        {
            this.listener = null;
            this.port = port;
            this.address = address;
        }
        public Task StartListenAsync() => Task.Run(StartListen);

        public async void StartListen()
        {
            if (listener != null)
            {
                return;
            }
            listener = new TcpListener(address, port);
            playersLobby = new List<TcpClientConnection>();
            listener.Start();
            TcpClient client;
            while (true)
            {
                List<TcpClientConnection> waitingPlayers = playersLobby.Where(x => x.mode == "PC").ToList();
                while (waitingPlayers.Count > 0)
                {
                    TcpClientConnection player = waitingPlayers[0];
                    GameWithComputer game = new GameWithComputer(player);
                    playersLobby.Remove(player);
                    waitingPlayers.Remove(player);
                    Thread thread = new Thread(game.StartGame);
                    thread.Start();
                }

                waitingPlayers = playersLobby.Where(x => x.mode == "Player").ToList();
                Random random = new Random();
                while (waitingPlayers.Count > 0 && waitingPlayers.Count % 2 == 0)
                {
                    int ind = random.Next(1, waitingPlayers.Count);
                    TcpClientConnection player1 = waitingPlayers[0];
                    TcpClientConnection player2 = waitingPlayers[ind];
                    GameWithPlayer game = new GameWithPlayer(player1, player2);
                    playersLobby.Remove(player1);
                    playersLobby.Remove(player2);
                    waitingPlayers.Remove(player1);
                    waitingPlayers.Remove(player2);
                    Thread thread = new Thread(game.StartGame);
                    thread.Start();
                }




                try
                {
                    client = await listener.AcceptTcpClientAsync();
                }
                catch (Exception)
                {
                    break;
                }
                TcpClientConnection clientConnection = new TcpClientConnection(client);
                clientConnection.ConnectionStateChanged += ClientConnection_ConnectionStateChanged;
                _ = clientConnection.StartMessagingAsync();
                playersLobby.Add(clientConnection);
                Thread.Sleep(1000);
            }

        }

        private void ClientConnection_ConnectionStateChanged(TcpClientConnection clientConnection, bool isConnected)
        {
            if (isConnected)
            {
                playersLobby[playersLobby.IndexOf(clientConnection)].mode = "Player";
            }
            else
            {
                playersLobby[playersLobby.IndexOf(clientConnection)].mode = "PC";
            }
        }

        public void StopListen()
        {
            if (listener != null)
            {
                if (playersLobby != null) playersLobby.Clear();
                listener.Stop();
                listener = null;
            }
        }

        public void Dispose()
        {
            this.StopListen();
        }
    }
}
