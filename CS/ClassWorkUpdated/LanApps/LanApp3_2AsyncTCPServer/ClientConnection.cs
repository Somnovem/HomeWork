using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LanApp3_2AsyncTCPServer
{
    internal class ClientConnection
    {
        private Socket client;
        public ClientConnection(Socket client)
        {
            this.client = client;
        }
        public void StartMessaging()
        {
            string answerText = "Your message has been delivered";
            byte[] answerData = Encoding.UTF8.GetBytes(answerText);
            StringBuilder stringBuilder = new StringBuilder();
            int len = 0;
            byte[] buffer = new byte[256];
            try
            {
                while (true)
                {
                    do
                    {
                        len = client.Receive(buffer);
                        stringBuilder.Append(Encoding.Unicode.GetString(buffer, 0, len));//из байт массива делает строку, конкретно нашего пакета
                    } while (client.Available > 0); //если сообщение было мультипакетным, и естьь еще данные для чтения, читаем дальше
                    Console.WriteLine($"Incoming at ({DateTime.Now.ToLongTimeString()})>> {stringBuilder.ToString()}");
                    Console.ReadLine();
                    if ("exit".Equals(stringBuilder.ToString())) 
                    {
                        Console.WriteLine("BYE!");
                        break;
                    }
                    //отправка ответа клиенту
                    client.Send(answerData);
                    stringBuilder.Clear();
                }

                //отключить сокет
                client.Shutdown(SocketShutdown.Both);
                
                //закрыть сокет
                client.Close();
                Console.WriteLine("Client disconnected!");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Encountered error: " + ex.Message);
            }
        }
        public void StartMessagingAsync() => Task.Run(StartMessaging);
    }
}
