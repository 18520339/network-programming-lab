using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MailApp
{
    public partial class frm_Compose : Form
    {
        MailRepository mailRepository;
        List<string> listFiles = new List<string>();

        public frm_Compose(MailRepository mailRepository, string to = "", string cc = "", string bcc = "", string messages = "")
        {
            InitializeComponent();
            this.mailRepository = mailRepository;
            txt_To.Text = to;
            txt_CC.Text = cc;
            txt_BCC.Text = bcc;
        }

        private void btn_Attach_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All files (*.*)|*.*" + "Images (*.JPG;*.JPEG;*.PNG)|*.JPG;*.JPEG;*.PNG|";
            ofd.Multiselect = true;

            if (ofd.ShowDialog() != DialogResult.OK) return;
            foreach (string file in ofd.FileNames) listFiles.Add(file);
            txt_Files.Text = string.Join(", ", listFiles.ToArray());
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            string smtpServer = txt_SMTP.Text;
            int port = Convert.ToInt32(txt_Port.Text);

            mailRepository.ConnectStmpServer(smtpServer, port, chb_SSL.Checked);
            mailRepository.SendMail(txt_Subject.Text, txt_Message.Text, txt_To.Text);
        }
    }
}
