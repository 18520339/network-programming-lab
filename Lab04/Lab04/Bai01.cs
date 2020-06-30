using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Bai01 : Form
    {
        public Bai01()
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
                WebRequest request = WebRequest.Create(url);
                WebResponse response = request.GetResponse();

                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);

                rtxt_HTML.Text = reader.ReadToEnd();
                response.Close();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void txt_Url_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_Get_Click(this, new EventArgs());
        }
    }
}
