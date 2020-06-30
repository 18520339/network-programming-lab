using System;
using System;
using System.IO;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() != DialogResult.OK) return;

            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            string content = sr.ReadToEnd();
            rtxt_Result.Text = content;
            
            txt_Name.Text = ofd.SafeFileName.ToString();
            txt_Url.Text = fs.Name.ToString();
            txt_Chars.Text = content.Length.ToString();

            content = content.Replace("\r\n", "\r");
            txt_Lines.Text = rtxt_Result.Lines.Length.ToString();
            content = content.Replace('\r', ' ');

            string[] source = content.Split(
                new char[] { '.', '?', '!', ' ', ';', ':', ',' }, 
                StringSplitOptions.RemoveEmptyEntries
            );
            txt_Words.Text = source.Length.ToString();

            fs.Close();
        }
    }
}
