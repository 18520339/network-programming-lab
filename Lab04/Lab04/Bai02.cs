using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
        }

        private void btn_Get_Click(object sender, EventArgs e)
        {
            string url = txt_Url.Text;
            bool isUri = Uri.IsWellFormedUriString(url, UriKind.Absolute);

            if (string.IsNullOrWhiteSpace(url) || !isUri)
            {
                txt_Url.Focus();
                MessageBox.Show("Url không đúng định dạng");
                return;
            }

            try
            {
                byte[] byteArray = Encoding.UTF8.GetBytes(txt_Data.Text);
                WebRequest request = WebRequest.Create(url);

                request.Method = "POST";
                request.ContentType = "text/plain";
                request.ContentLength = byteArray.Length;

                Stream dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();

                WebResponse response = request.GetResponse();
                using (dataStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(dataStream);
                    rtxt_HTML.Text = JToken.Parse(reader.ReadToEnd()).ToString();
                    // rtxt_HTML.Text = reader.ReadToEnd();
                }
                response.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void txt_Data_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_Get_Click(this, new EventArgs());
        }
    }
}
