using System;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai01 frm = new Bai01();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai02 frm = new Bai02();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bai03 frm = new Bai03();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bai04 frm = new Bai04();
            frm.ShowDialog();
        }
    }
}
