using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Diagnostics;
using System.Threading;

namespace LanApp2_1
{
    internal class ProgrammServer
    {
        static void Main(string[] args)
        {
            Console.Title = "Test TCP server";
            MyServer server = new MyServer(IPAddress.Parse("127.0.0.1"),1000);//Any -для любого,Loopback - если сам для себя, лиюо парс если юзер вводит
                                                                              //нельзя поставить 2 одинаковых порта
            Thread thread = new Thread(server.StartServer);
            thread.IsBackground = true;
            thread.Start();
            Console.WriteLine("Press enter to stop the server");
            Console.ReadLine();
            thread.Abort();
        }
    }
    internal class MyServer
    {
        private int port;
        private IPAddress ip;
        private Socket server;
        public MyServer(IPAddress iPAddress, int port)
        {
            this.ip = iPAddress;
            this.port = port;
        }
        public Task StartServerAsync()
        {
            return Task.Run(StartServer);
        }
        public void StartServer() 
        {
            //прием и обработка подключений
            if (server != null)
            {
                return;
            }

            //создание сокета
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); //Датаграмма не контролирует доставку - UDP

            //конечная точка для получения подключений
            IPEndPoint localEndPoint = new IPEndPoint(ip, port);

            string answerText = "Your message has been delivered";
            byte[] answerData = Encoding.UTF8.GetBytes(answerText);
            try
            {
                //привязуем сокет к точке
                server.Bind(localEndPoint);

                //начинаем послушивать подключения
                server.Listen(10); //максимальное количество ожидающих подключений, следующие будут кинуты в отказ
                Console.WriteLine("Server started and is ready for connections!");
                while (true)
                {
                    Socket client = server.Accept(); //принимаем подлкючение из очереди и записываем себе кто именно подключился
                    Console.WriteLine($"Accepted: {client.RemoteEndPoint.ToString()}");


                    //строковый буфер для получения сообщений
                    StringBuilder stringBuilder = new StringBuilder();
                    int len = 0;//кол-во прочитанных байт
                    byte[] buffer = new byte[256]; //буфферный массив
                    
                    do
                    {
                       len = client.Receive(buffer);
                        stringBuilder.Append(Encoding.Unicode.GetString(buffer,0,len));//из байт массива делает строку, конкретно нашего пакета
                    } while (client.Available > 0); //если сообщение было мультипакетным, и естьь еще данные для чтения, читаем дальше
                    Console.WriteLine($"Incoming at ({DateTime.Now.ToLongTimeString()})>> {stringBuilder.ToString()}");
                    Console.ReadLine();

                    //отправка ответа клиенту
                    client.Send(answerData);

                    //отключить сокет
                    client.Shutdown(SocketShutdown.Both);

                    //закрыть сокет
                    client.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Encountered error: " + ex.Message);
                throw;
            }
            
        }
    }
}
