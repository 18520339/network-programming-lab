using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MyPaint
{
    public partial class frm_Client : Form
    {
        Point currentPos = new Point();
        Point oldPos = new Point();

        Pen pen = new Pen(Color.Red, 5);
        Pen eraser = new Pen(Color.White, 5);

        Graphics graph;
        Bitmap surface;

        IPEndPoint iep; 
        Socket client;
        SocketData data;

        string fileName = "Picture";
        int index = 0;
        int width;

        public frm_Client()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();

            surface = new Bitmap(panel1.Width, panel1.Height);
            graph = Graphics.FromImage(surface);
            panel1.BackgroundImage = surface;
            panel1.BackgroundImageLayout = ImageLayout.None;

            pen.SetLineCap(
                System.Drawing.Drawing2D.LineCap.Round,
                System.Drawing.Drawing2D.LineCap.Round,
                System.Drawing.Drawing2D.DashCap.Round
            );

            eraser.SetLineCap(
                System.Drawing.Drawing2D.LineCap.Round,
                System.Drawing.Drawing2D.LineCap.Round,
                System.Drawing.Drawing2D.DashCap.Round
            );
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            oldPos = e.Location;
            if (radioButton1.Checked) width = 5;
            else if (radioButton2.Checked) width = 10;
            else if (radioButton3.Checked) width = 15;
            else if (radioButton4.Checked) width = 20;
            else if (radioButton5.Checked) width = 25;

            pen.Width = width;
            eraser.Width = width;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                currentPos = e.Location;
                graph.DrawLine(pen, oldPos, currentPos);

                data = new SocketData(pen.Color, width, oldPos, currentPos);
                Send();

                oldPos = currentPos;
                panel1.Invalidate();
            }
            else if (e.Button == MouseButtons.Right)
            {
                currentPos = e.Location;
                graph.DrawLine(eraser, oldPos, currentPos);

                data = new SocketData(eraser.Color, width, oldPos, currentPos);
                Send();

                oldPos = currentPos;
                panel1.Invalidate();
            }
        }

        private void btn_Color_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                pen.Color = cd.Color;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            index++;
            fileName = "Picture " + index + ".png";
            surface.Save(fileName, ImageFormat.Png);
        }

        private void frm_Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            Close();
        }

        private void Connect()
        {
            iep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try { client.Connect(iep); }
            catch (Exception err) 
            { 
                MessageBox.Show(err.Message);
                return;
            }

            Thread Listen = new Thread(Receive);
            Listen.IsBackground = true;
            Listen.Start();
        }

        private void Close()
        {
            client.Close();
        }

        private void Send()
        {
            if (client == null) return;
            byte[] sendedData = SerializeData(data);
            client.Send(sendedData);
        }

        private void Receive()
        {
            
            try
            {
                while (true)
                {
                    byte[] receivedData = new byte[1024]; // 1 lần nhận tin là cỡ bao nhiêu
                    client.Receive(receivedData);
                    data = (SocketData)DeserializeData(receivedData);

                    graph.DrawLine(new Pen(data.PenColor, data.Width), data.OldPos, data.CurrentPos);
                    panel1.Invalidate();
                }
            }
            catch { Close(); }
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

    public class IPanel : Panel
    {
        public IPanel()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
        }
    }
}
