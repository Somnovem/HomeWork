using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Data.SQLite;

namespace StandartChat
{
    public static class Extensions
    {
        public static bool IsSingleWord(this string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (!Char.IsLetter(str[0]))
                {
                    return false;
                }
            }
            return true;
        }
    }


    public class ChatServer : Chat, IDisposable
    {
        private string connectionString = @"Data Source=..\..\credentials.db;Version=3;";
        private string teamsInfopath = @"..\..\Teams.txt";
        protected Dictionary<string, List<string>> existingTeams;
        public delegate void ErrorEncounteredDelegate(string message);
        public event ErrorEncounteredDelegate ErrorEncountered;
        private IPEndPoint senderIp;
        private string address = "224.100.0.1";
        private int clientPort = 8001;
        private UdpClient receiverUdp;
        public ChatServer() : base("Server")
        {
            LoadTeams();
        }

        #region SQLite

        private bool UserExists(string username)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                var selectCommand = new SQLiteCommand(
                    "SELECT Password FROM Users WHERE Login = @username",
                    connection
                );
                selectCommand.Parameters.AddWithValue("@username", username);
                string response = (string)selectCommand.ExecuteScalar();
                return !string.IsNullOrEmpty(response);
            }
        }

        private bool UserLogin(string username, string password)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var selectCommand = new SQLiteCommand(
                    "SELECT Password FROM Users WHERE Login = @username AND Password = @password",
                    connection
                );
                selectCommand.Parameters.AddWithValue("@username", username);
                selectCommand.Parameters.AddWithValue("@password", password);
                string response = (string)selectCommand.ExecuteScalar();
                return !string.IsNullOrEmpty(response);// false - Invalid password or login
            }
        }

        private void AddUser(string username, string password)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var selectCommand = new SQLiteCommand(
                    "Insert INTO Users(Login,Password) VALUES(@username,@password)",
                    connection
                );
                selectCommand.Parameters.AddWithValue("@username", username);
                selectCommand.Parameters.AddWithValue("@password", password);
                string response = (string)selectCommand.ExecuteScalar();

            }
        }

        #endregion

        private void LoadTeams()
        {
            existingTeams = new Dictionary<string, List<string>>();
            if (File.Exists(teamsInfopath))
            {
                using (StreamReader reader = new StreamReader(teamsInfopath))
                {
                    string team = null;
                    string user = null;
                    while (!reader.EndOfStream)
                    {
                        team = reader.ReadLine();
                        existingTeams.Add(team, new List<string>());
                        while (true)
                        {
                            user = reader.ReadLine();
                            if (user.StartsWith("="))
                            {
                                break;
                            }
                            existingTeams[team].Add(user);
                        }
                    }
                }
            }
        }
        public void Connect() //Set destination to client port
        {
            senderIp = new IPEndPoint(IPAddress.Parse(address), clientPort);
            senderUdp = new UdpClient();
        }

        public void Send(string type, string message) //Send message to clients
        {
            MessagePacket packet = new MessagePacket()
            {
                Type = (MessageType)Enum.Parse(typeof(MessageType), type),
                Data = message
            };
            byte[] data = packet.ToByteArray();
            if (packet.Type == MessageType.Censor)
            {
                senderUdp.Send(data, data.Length, new IPEndPoint(IPAddress.Parse("224.100.0.1"), 8000));
            }
            else
            {
                senderUdp.Send(data, data.Length, senderIp);
            }
        }

        private void SendRequestResult(MessageType type,string message)
        {
            MessagePacket loginPacket = new MessagePacket()
            {
                Type = type,
                Data = message
            };
            byte[] data = loginPacket.ToByteArray();
            senderUdp.Send(data, data.Length, senderIp);
        }

        public async void Start()
        {
            try
            {
                receiverUdp = new UdpClient(8000);
            }
            catch (Exception ex)
            {
                ErrorEncountered?.Invoke(ex.Message);
                return;
            }
            receiverUdp.JoinMulticastGroup(IPAddress.Parse(address), 20);
            StringBuilder builder = new StringBuilder();
            try
            {
                MessagePacket packet = null;
                while (true)
                {
                    MemoryStream ms = new MemoryStream();
                    do
                    {
                        var result = await receiverUdp.ReceiveAsync();
                        ms.Write(result.Buffer, 0, result.Buffer.Length);
                    } while (receiverUdp.Available > 0);
                    ms.Position = 0;
                    packet = MessagePacket.FromStream(ms);
                    if (packet.Type == MessageType.Login)//login password
                    {
                        string[] parameters = ((string)packet.Data).Split(' ');
                        if (UserLogin(parameters[0], parameters[1]))
                        {
                            SendRequestResult(MessageType.LoginResult,$"{parameters[0]}:Success");
                        }
                        else
                        {
                            SendRequestResult(MessageType.LoginResult, $"{parameters[0]}:Invalid login or password!");
                        }
                    }
                    else if (packet.Type == MessageType.Signup)//login password
                    {
                        string[] parameters = ((string)packet.Data).Split(' ');
                        if (UserExists(parameters[0]))
                        {
                            SendRequestResult(MessageType.LoginResult, $"{parameters[0]}:Username already taken!");
                        }
                        else
                        {
                            AddUser(parameters[0], parameters[1]);
                            SendRequestResult(MessageType.LoginResult, $"{parameters[0]}:Success");
                        }
                    }
                    else if (packet.Type == MessageType.CreateRoom)
                    {
                        string[] parameters = ((string)packet.Data).Split(' '); //user roomname
                        if (existingTeams.Keys.Contains(parameters[1])) //check if such room already exists
                        {
                            SendRequestResult(MessageType.RoomRequestResult, $"{parameters[0]}:Room with such name already exists!");
                        }
                        else //create such room and add the user to it
                        {
                            existingTeams.Add(parameters[1], new List<string>());
                            existingTeams[parameters[1]].Add(parameters[0]);
                            SendRequestResult(MessageType.RoomRequestResult, $"{parameters[0]}:Success");
                        }
                    }
                    else if (packet.Type == MessageType.JoinRoom)
                    {
                        string[] parameters = ((string)packet.Data).Split(' ');
                        if (!existingTeams.Keys.Contains(parameters[1])) //check if such room already exists
                        {
                            SendRequestResult(MessageType.RoomRequestResult, $"{parameters[0]}:Room with such name doesn't exist!");
                        }
                        else if (existingTeams[parameters[1]].Contains(parameters[0])) //check if the user is already a member
                        {
                            SendRequestResult(MessageType.RoomRequestResult, $"{parameters[0]}:You're already a member of this group!");
                        }
                        else
                        {
                            existingTeams[parameters[1]].Add(parameters[0]); // add the user to the group
                            SendRequestResult(MessageType.RoomRequestResult, $"{parameters[0]}:Success");
                        }
                    }
                    else if (packet.Type == MessageType.LeaveRoom)
                    {
                        string[] parameters = ((string)packet.Data).Split(' ');
                        if (!existingTeams.Keys.Contains(parameters[1]))
                        {
                            SendRequestResult(MessageType.RoomRequestResult, $"{parameters[0]}:Room with such name doesn't exist!");//check if such room already exists
                        }
                        existingTeams[parameters[1]].Remove(parameters[0]); // remove the user from the group
                        SendRequestResult(MessageType.RoomRequestResult, $"{parameters[0]}:Success");
                    }
                    else if (packet.Type == MessageType.Censor) //Censor a word on this server
                    {
                        string bannedWord = (string)packet.Data;
                        if (bannedWords.Contains(bannedWord)) continue;
                        bannedWords.Add(bannedWord);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorEncountered?.Invoke(ex.Message);
            }
        }

        public void Dispose()
        {
            using (StreamWriter writer = new StreamWriter(teamsInfopath))
            {
                foreach (string key in existingTeams.Keys)
                {
                    writer.WriteLine(key);
                    for (int i = 0; i < existingTeams[key].Count; i++)
                    {
                        writer.WriteLine(existingTeams[key][i]);
                    }
                    writer.WriteLine("==================");
                }
            }
        }
    }

    public class Chat
    {
        
        protected UdpClient senderUdp;
        
        protected string login;
        protected static List<string> bannedWords;
        public Chat(string login)
        {
            senderUdp = null;
            if (bannedWords == null) bannedWords = new List<string>();
            this.login = login;
        }
    }

    public class ChatClient : Chat,IDisposable
    {
        #region Delegates and events
        public delegate void MessageReceivedDelegate(string message);
        public event MessageReceivedDelegate BroadcastMessageReceived;
        public event MessageReceivedDelegate WhiserMessageReceived;
        public event MessageReceivedDelegate RoomMessageReceived;

        public delegate void GotKickedDelegate(int timeoutSeconds);
        public event GotKickedDelegate GotTimedOut;

        public delegate void GotBannedDelegate();
        public event GotBannedDelegate GotBanned;

        public delegate void RequestResultDelegate(bool successful,string message);
        public event RequestResultDelegate LoginResultEvent;
        public event RequestResultDelegate RoomResultEvent;

        public delegate void ErrorEncounteredDelegate(string message);
        public event ErrorEncounteredDelegate ErrorEncountered;

        public event Action ServerClosed;
        #endregion
        private IPEndPoint serverEndPoint;
        private IPEndPoint clientEndPoint;


        private bool wasDisposed;
        private UdpClient receiverClient;

        public ChatClient(string login) : base(login)
        { 
            senderUdp = new UdpClient();
            wasDisposed = false; 
            serverEndPoint = new IPEndPoint(IPAddress.Parse("224.100.0.1"), 8000);
            clientEndPoint = new IPEndPoint(IPAddress.Parse("224.100.0.1"), 8001);
        }

        public async void ListenClients()
        {
            try
            {
                receiverClient = new UdpClient(8001);
            }
            catch (Exception ex)
            {
                ErrorEncountered?.Invoke(ex.Message);
                return;
            }
            receiverClient.JoinMulticastGroup(IPAddress.Parse("224.100.0.1"), 20);
            StringBuilder builder = new StringBuilder();
            try
            {
                MessagePacket packet = null;
                while (!wasDisposed)
                {
                    MemoryStream ms = new MemoryStream();
                    do
                    {
                        var result = await receiverClient.ReceiveAsync();
                        ms.Write(result.Buffer, 0, result.Buffer.Length);
                    } while (receiverClient.Available > 0);
                    ms.Position = 0;
                    packet = MessagePacket.FromStream(ms);

                    if (packet.Type == MessageType.Broadcast) //Broadcast message was received
                    {
                        BroadcastMessageReceived?.Invoke((string)packet.Data);//usr msg
                    }
                    else if (packet.Type == MessageType.Whisper) //Personal message was received
                    {
                        if (login.Equals(((string)packet.Data).Split('/')[1]))
                        {
                            WhiserMessageReceived?.Invoke((string)packet.Data);
                        }

                    }
                    else if (packet.Type == MessageType.WhisperGroup) //Message from a room was received
                    {
                        RoomMessageReceived?.Invoke((string)packet.Data);
                    }
                    else if (packet.Type == MessageType.Ban)
                    {
                        if (this.login.Equals((string)packet.Data))
                        {
                            GotBanned?.Invoke();
                        }
                    }
                    else if (packet.Type == MessageType.Timeout)
                    {
                        string[] msg = ((string)packet.Data).Split(' ');
                        if (this.login.Equals(msg[0]))
                        {
                            GotTimedOut?.Invoke(Int32.Parse(msg[1]));
                        }
                    }
                    else if (packet.Type == MessageType.LoginResult)
                    {
                        string[] msg = ((string)packet.Data).Split(':');
                        if (this.login.Equals(msg[0]))
                        {
                            if (msg[1].Equals("Success"))
                                LoginResultEvent?.Invoke(true, null);
                            else
                                LoginResultEvent?.Invoke(false, msg[1]);
                        }
                    }
                    else if (packet.Type == MessageType.RoomRequestResult)
                    {
                        string[] msg = ((string)packet.Data).Split(':');
                        if (this.login.Equals(msg[0]))
                        {
                            if (msg[1].Equals("Success"))
                                RoomResultEvent?.Invoke(true, null);
                            else
                                RoomResultEvent?.Invoke(false, msg[1]);
                        }
                    }
                    else if (packet.Type == MessageType.ServerClosed) ServerClosed?.Invoke();
                }
            }
            catch (Exception ex)
            {
                ErrorEncountered?.Invoke(ex.Message);
            }
        }

        public void Send(string type, string message) 
        {
            if (type.Contains("Room") || type.Equals("Login") || type.Equals("Signup"))
                SendServer(type, message);
            else
                SendClients(type, message);
        }
        private void SendServer(string type, string message)
        {
            MessagePacket packet = new MessagePacket()
            {
                Type = (MessageType)Enum.Parse(typeof(MessageType), type),
                Data = message
            };
            byte[] data = packet.ToByteArray();

            senderUdp.Send(data, data.Length,serverEndPoint);
        }
        private void SendClients(string type, string message)
        {
            for (int i = 0; i < bannedWords.Count; i++)
            {
                if (message.Contains(bannedWords[i])) message = message.Replace(bannedWords[i], "###");
            }
            MessagePacket packet = new MessagePacket()
            {
                Type = (MessageType)Enum.Parse(typeof(MessageType), type),
                Data = message
            };
            byte[] data = packet.ToByteArray();
            senderUdp.Send(data, data.Length, clientEndPoint);
        }

        public void Dispose()
        {
            wasDisposed = true;
            receiverClient.Close();
            receiverClient.Dispose();
        }
    }


    public enum MessageType { Login, Signup,LoginResult, Broadcast, Whisper, WhisperGroup, CreateRoom, JoinRoom, LeaveRoom,RoomRequestResult, Ban, Timeout, Censor,ServerClosed }
    [Serializable]
    public class MessagePacket
    {
        public MessageType Type;
        public object Data;

        private static BinaryFormatter bf = new BinaryFormatter();
        public override string ToString()
        {
            return Data.ToString();
        }
        public static MessagePacket FromByteArray(byte[] data)
        {
            MessagePacket result = null;
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(data, 0, data.Length);
                ms.Position = 0;
                result = (MessagePacket)bf.Deserialize(ms);
            }
            return result;
        }
        public static MessagePacket FromStream(Stream stream)
        {
            return bf.Deserialize(stream) as MessagePacket;
        }

        public byte[] ToByteArray()
        {
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, this);
            ms.Position = 0;
            return ms.ToArray();
        }
    }
}
