using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Remoting.Messaging;

namespace Chatters
{
    public class BroadcastChatter
    {
        private UdpClient receiverUdp;
        private UdpClient senderUdp;

        public delegate void MessageReceivedDelegate(string message);
        public event MessageReceivedDelegate MessageReceived;

        public delegate void ErrorEncounteredDelegate(string message);
        public event ErrorEncounteredDelegate ErrorEncountered;

        public delegate void GotKickedDelegate();
        public event GotKickedDelegate GotKicked;
        private IPEndPoint senderIp;
        public BroadcastChatter()
        {
            receiverUdp = senderUdp = null;
        }
        public void Connect(string address, int port)
        {
            senderIp = new IPEndPoint(IPAddress.Parse(address), port);
            senderUdp = new UdpClient();
        }
        public void Send(string type,string message)
        {
            MessageType temp;
            try
            {
                temp = (MessageType)Enum.Parse(typeof(MessageType), type);
            }
            catch
            {
                temp = MessageType.Standart;
                ErrorEncountered?.Invoke("Invalid type!Type of the message was moved to Standart.");
            }
            MessagePacket packet = new MessagePacket()
            {
                Type = temp,
                Data = message
            };
            byte[] data = packet.ToByteArray();

            senderUdp.Send(data, data.Length, senderIp);
        }
        public async void Start(string address, int port, string[] types)
        {
            MessageType[] userTypes = new MessageType[types.Length];
            for (int i = 0; i < types.Length; i++)
            {
                if (!Enum.TryParse(types[i], out userTypes[i]))
                {
                    MessageReceived?.Invoke("Invalid type chosen!");
                    return;
                }
            }
            try
            {
                receiverUdp = new UdpClient(port);
            }
            catch (Exception ex)
            {
                MessageReceived?.Invoke(ex.Message);
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
                    if (packet.Type == MessageType.Kick)
                    {
                        if (Dns.GetHostAddresses(Dns.GetHostName()).Contains(IPAddress.Parse((string)packet.Data)))
                        {
                            GotKicked?.Invoke();
                            break;
                        }
                    }
                    if(packet.Type == MessageType.Emergency || userTypes.Contains(packet.Type)) MessageReceived?.Invoke($"{packet.Type} >> {packet.Data}");
                }
            }
            catch (Exception ex)
            {
                MessageReceived?.Invoke(ex.Message);
            }
        }
    }
    public enum MessageType { Advertisements, Offers, Announcements, Files, Images, Standart, Emergency, Kick }
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
