using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Bai03
{
    public partial class frm_Server : Form
    {
        public frm_Server()
        {
            InitializeComponent();
        }

        bool isListening = false;
        IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);

        Thread serverThread;
        Socket listenerSocket;

        private void StartUnsafeThread()
        {
            int bytesReceived = 0;
            byte[] recv = new byte[1];

            listenerSocket = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
            );

            listenerSocket.Bind(ipepServer);
            listenerSocket.Listen(-1);

            Socket clientSocket = listenerSocket.Accept();
            lsv_Messages.Items.Add("New client connected");

            while (clientSocket.Connected)
            {
                string text = "";
                do
                {
                    bytesReceived = clientSocket.Receive(recv);
                    text += Encoding.ASCII.GetString(recv);
                }
                while (text[text.Length - 1] != '\n');

                if (!string.IsNullOrWhiteSpace(text))
                    lsv_Messages.Items.Add(text);
            }
            listenerSocket.Close();
        }

        private void btn_Listen_Click(object sender, EventArgs e)
        {
            if (isListening) return;
            isListening = true;
            CheckForIllegalCrossThreadCalls = false;

            serverThread = new Thread(StartUnsafeThread);
            lsv_Messages.Items.Add("Server is running on" + ipepServer.ToString());

            serverThread.IsBackground = true;
            serverThread.Start();
        }

        private void frm_Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listenerSocket != null) listenerSocket.Close();
            if (serverThread != null) serverThread.Abort();
        }
    }
}
