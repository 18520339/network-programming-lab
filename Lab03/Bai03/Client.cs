using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Bai03
{
    public partial class frm_Client : Form
    {
        public frm_Client()
        {
            InitializeComponent();
        }

        IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
        TcpClient tcpClient = new TcpClient();
        NetworkStream ns;
        bool isConnected = false;

        private void btn_Send_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isConnected)
                {
                    tcpClient.Connect(ipEndPoint);
                    ns = tcpClient.GetStream();
                    isConnected = true;
                }

                byte[] data = Encoding.ASCII.GetBytes("Hello server\n");
                ns.Write(data, 0, data.Length);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void frm_Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            tcpClient.Close();
            if (ns != null) ns.Close();
        }
    }
}
