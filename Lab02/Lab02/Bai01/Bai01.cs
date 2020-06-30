using System;
using System.IO;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }

        private string filePath;

        private void btn_Read_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() != DialogResult.OK) return;
            filePath = Path.GetDirectoryName(ofd.FileName);

            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            string content = sr.ReadToEnd();
            rtxt_Input.Text = content;
            fs.Close();
        }

        private void btn_Write_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtxt_Input.Text))
            {
                MessageBox.Show("Không có gì để ghi !!!");
                return;
            }

            try
            {
                string fileName = Path.Combine(filePath, "output.txt");
                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    rtxt_Output.Text = rtxt_Input.Text.ToUpper();
                    sw.WriteLine(rtxt_Output.Text);
                    MessageBox.Show("Ghi thành công !!!");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return;
            }
        }
    }
}
