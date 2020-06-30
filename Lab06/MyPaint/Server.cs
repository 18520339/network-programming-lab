using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;

namespace MyPaint
{
    public partial class frm_Server : Form
    {
        IPEndPoint iep;
        Socket server;
        SocketData data;

        List<Socket> clientList;
        int max_clients = 5;

        public frm_Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }

        private void btn_AddClient_Click(object sender, EventArgs e)
        {
            if (clientList.Count >= max_clients)
            {
                MessageBox.Show("Quá số lượng client cho phép!");
                return;
            }

            frm_Client frm = new frm_Client();
            frm.Show();
        }

        private void frm_Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            Close();
        }

        private void Connect()
        {
            iep = new IPEndPoint(IPAddress.Any, 9999);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            clientList = new List<Socket>();

            server.Bind(iep);
            Thread AcceptClient = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(10); // Đợi kết nối client trong 10s nếu ko có thì bỏ
                        Socket client;
                        
                        try { client = server.Accept(); }
                        catch (Exception err)
                        {
                            MessageBox.Show(err.Message);
                            return;
                        }

                        clientList.Add(client);
                        lbl_NumClients.Text = clientList.Count.ToString();

                        Thread Listen = new Thread(Receive);
                        Listen.IsBackground = true;
                        Listen.Start(client);
                    }
                }
                catch
                {
                    iep = new IPEndPoint(IPAddress.Any, 9999);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                }
            });

            AcceptClient.IsBackground = true; // Để khi chương trình tắt ngang thì Thread cũng tự tắt
            AcceptClient.Start();
        }

        private void Close()
        {
            server.Close();
        }

        private void Send(Socket client)
        {
            if (client == null) return;
            byte[] sendedData = SerializeData(data);
            client.Send(sendedData);
        }

        private void Receive(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] receivedData = new byte[1024]; // 1 lần nhận tin là cỡ bao nhiêu
                    client.Receive(receivedData);
                    data = (SocketData)DeserializeData(receivedData);

                    foreach (Socket item in clientList) 
                        if (item != client) Send(item);
                }
            }
            catch
            {
                clientList.Remove(client);
                lbl_NumClients.Text = clientList.Count.ToString();
                client.Close();
            }
        }

        /// <summary>
        /// Nén đối tượng thành mảng byte[]
        /// </summary>
        public byte[] SerializeData(Object obj)
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, obj);
            return ms.ToArray();
        }

        /// <summary>
        /// Giải nén mảng byte[] thành đối tượng object
        /// </summary>
        public object DeserializeData(byte[] byteArray)
        {
            MemoryStream ms = new MemoryStream(byteArray);
            BinaryFormatter bf = new BinaryFormatter();
            ms.Position = 0;
            return bf.Deserialize(ms);
        }
    }
}
