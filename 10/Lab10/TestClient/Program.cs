using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using ClassLibraryRiver.Library;

using Newtonsoft.Json;

namespace TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // Буфер для входящих данных
            byte[] bytes = new byte[10240];

            // Соединяемся с удаленным устройством

            // Устанавливаем удаленную точку для сокета
            IPHostEntry ipHost = Dns.GetHostEntry("localhost");
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 11000);

            Socket sender = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            // Соединяем сокет с удаленной точкой
            sender.Connect(ipEndPoint);

            while (true)
            {
                try
                {
                    RiverRequest request = null;
                    Console.Write("Действие (add, get, remove, update): ");
                    string action = Console.ReadLine();

                    if (action == "add")
                    {
                        string title = Console.ReadLine();
                        int length = Convert.ToInt32(Console.ReadLine());
                        int maxDepth = Convert.ToInt32(Console.ReadLine());
                        request = new RiverRequest
                        {
                            River = new River { Title = title, Length = length, MaxDepth = maxDepth },
                            Key = title,
                            Type = RiverRequestType.Add
                        };
                    }
                    else if (action == "get")
                    {
                        string key = Console.ReadLine();
                        request = new RiverRequest
                        {
                            Key = key,
                            Type = RiverRequestType.Get
                        };
                    }
                    else if (action == "remove")
                    {
                        string key = Console.ReadLine();
                        request = new RiverRequest
                        {
                            Key = key,
                            Type = RiverRequestType.Remove
                        };
                    }
                    else if (action == "update")
                    {
                        string key = Console.ReadLine();
                        int length = Convert.ToInt32(Console.ReadLine());
                        int maxDepth = Convert.ToInt32(Console.ReadLine());
                        request = new RiverRequest
                        {
                            River = new River { Title = key, Length = length, MaxDepth = maxDepth },
                            Key = key,
                            Type = RiverRequestType.Update
                        };
                    }
                    else
                    {
                        continue;
                    }

                    string jsonRequest = JsonConvert.SerializeObject(request);
                    byte[] msg = Encoding.UTF8.GetBytes(jsonRequest);

                    // Отправляем данные через сокет
                    sender.Send(msg);

                    // Получаем ответ от сервера
                    int bytesRec = sender.Receive(bytes);
                    Console.WriteLine("Запрос к серверу: {0}\n\n", jsonRequest);
                    Console.WriteLine("Ответ от сервера: {0}\n\n", Encoding.UTF8.GetString(bytes, 0, bytesRec));
                }
                catch (Exception)
                {
                    break;
                }
            }

            // Освобождаем сокет
            sender.Shutdown(SocketShutdown.Both);
            sender.Close();
        }
    }
}