using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using ClassLibraryRiver.Library;
using Newtonsoft.Json;

namespace Client
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            // Буфер для входящих данных
            byte[] bytes = new byte[10240];

            // Соединяемся с удаленным устройством

            // Устанавливаем удаленную точку для сокета
            IPHostEntry ipHost = Dns.GetHostEntry("localhost");
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 11000);

            Socket sSender = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            // Соединяем сокет с удаленной точкой
            sSender.Connect(ipEndPoint);

            try
            {
                RiverRequest request = null;

                if (comboBoxRequestType.Text == "Добавить")
                {
                    string title = textBoxTitle.Text;
                    int area = Convert.ToInt32(numericUpDownArea.Value);
                    int maxDepth = Convert.ToInt32(numericUpDownMaxDepth.Value);
                    request = new RiverRequest
                    {
                        River = new River { Title = title, Length = area, MaxDepth = maxDepth },
                        Key = title,
                        Type = RiverRequestType.Add
                    };
                }
                else if (comboBoxRequestType.Text == "Получить")
                {
                    string key = textBoxTitle.Text;
                    request = new RiverRequest
                    {
                        Key = key,
                        Type = RiverRequestType.Get
                    };
                }
                else if (comboBoxRequestType.Text == "Удалить")
                {
                    string key = textBoxTitle.Text;
                    request = new RiverRequest
                    {
                        Key = key,
                        Type = RiverRequestType.Remove
                    };
                }
                else if (comboBoxRequestType.Text == "Обновить")
                {
                    string key = textBoxTitle.Text;
                    int length = Convert.ToInt32(numericUpDownArea.Value);
                    int maxDepth = Convert.ToInt32(numericUpDownMaxDepth.Value);
                    request = new RiverRequest
                    {
                        River = new River { Title = key, Length = length, MaxDepth = maxDepth },
                        Key = key,
                        Type = RiverRequestType.Update
                    };
                }
                else
                {
                    // Освобождаем сокет
                    sSender.Shutdown(SocketShutdown.Both);
                    sSender.Close();
                    return;
                }

                string jsonRequest = JsonConvert.SerializeObject(request);
                byte[] msg = Encoding.UTF8.GetBytes(jsonRequest);

                // Отправляем данные через сокет
                sSender.Send(msg);

                // Получаем ответ от сервера
                int bytesRec = sSender.Receive(bytes);
                string jsonResponse = Encoding.UTF8.GetString(bytes, 0, bytesRec);
                RiverResponse response = JsonConvert.DeserializeObject<RiverResponse>(jsonResponse);

                if (response.IsSuccess)
                {
                    toolStripStatusLabelJson.Text = "";
                }
                else
                {
                    toolStripStatusLabelJson.Text = response.ErrorMessage;
                }

                if (response.River != null)
                {
                    textBoxTitle.Text = response.River.Title;
                    numericUpDownArea.Value = response.River.Length;
                    numericUpDownMaxDepth.Value = response.River.MaxDepth;
                }
            }
            catch (Exception)
            {
                // Освобождаем сокет
                sSender.Shutdown(SocketShutdown.Both);
                sSender.Close();
                return;
            }

            // Освобождаем сокет
            sSender.Shutdown(SocketShutdown.Both);
            sSender.Close();
        }
    }
}
