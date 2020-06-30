using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Bai01
{
    public partial class frm_Server : Form
    {
        public frm_Server()
        {
            InitializeComponent();
        }

        int connecting_port = -1;
        static IDictionary<int, Thread> list_threads = new Dictionary<int, Thread>();
        static IDictionary<int, Tuple<UdpClient, Thread>> udpClient_connected = 
            new Dictionary<int, Tuple<UdpClient, Thread>>();

        private void serverThread()
        {
            try
            {
                UdpClient udpClient = new UdpClient(connecting_port);
                udpClient_connected.Add(connecting_port, new Tuple<UdpClient, Thread>(
                    udpClient, list_threads[connecting_port]
                ));

                while (true)
                {
                    IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                    byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);

                    string returnData = Encoding.UTF8.GetString(receiveBytes);
                    string client_ip = RemoteIpEndPoint.Address.ToString();
                    string client_port = ((IPEndPoint)udpClient.Client.LocalEndPoint).Port.ToString();

                    lsv_Messages.Items.Add(new ListViewItem(new[] {
                        client_ip + ":" + client_port,
                        returnData.ToString()
                    }));
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btn_Listen_Click(object sender, EventArgs e)
        {
            try
            {
                CheckForIllegalCrossThreadCalls = false;
                if (string.IsNullOrWhiteSpace(txt_Port.Text))
                {
                    MessageBox.Show("Port không được để trống");
                    return;
                }

                int current_port = Int32.Parse(txt_Port.Text);
                if (connecting_port == current_port) return;
                else connecting_port = current_port;

                Thread thdUDPServer = new Thread(serverThread);
                list_threads.Add(connecting_port, thdUDPServer);

                thdUDPServer.IsBackground = true;
                thdUDPServer.Start();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Ngắt kết nối các ports
            foreach (KeyValuePair<int, Tuple<UdpClient, Thread >> item in udpClient_connected)
            {
                item.Value.Item1.Close();
                item.Value.Item2.Abort();
            }
            list_threads.Clear();
            udpClient_connected.Clear();
        }
    }
}
