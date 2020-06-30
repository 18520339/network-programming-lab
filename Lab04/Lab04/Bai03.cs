using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            string url = txt_Url.Text;
            string path = txt_Path.Text;
            bool isUri = Uri.IsWellFormedUriString(url, UriKind.Absolute);

            if (string.IsNullOrWhiteSpace(url) || !isUri)
            {
                txt_Url.Focus();
                MessageBox.Show("Url không đúng định dạng");
                return;
            }

            if (Directory.Exists(path))
            {
                txt_Path.Focus();
                MessageBox.Show("Đường dẫn không đúng định dạng");
                return;
            }

            WebClient myClient = new WebClient();
            Stream dataStream = myClient.OpenRead(url);
            StreamReader reader = new StreamReader(dataStream);

            rtxt_HTML.Text = reader.ReadToEnd();
            myClient.DownloadFile(url, path);
        }

        private void Bai03_Load(object sender, EventArgs e)
        {
            txt_Path.Text = Directory.GetCurrentDirectory() + "\\index.html";
        }
    }
}
