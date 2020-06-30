using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Bai01_Click(object sender, EventArgs e)
        {
            Bai01 frm = new Bai01();
            frm.ShowDialog();
        }

        private void btn_Bai02_Click(object sender, EventArgs e)
        {
            Bai02 frm = new Bai02();
            frm.ShowDialog();
        }

        private void btn_Bai03_Click(object sender, EventArgs e)
        {
            Bai03 frm = new Bai03();
            frm.ShowDialog();
        }

        private void btn_Bai04_Click(object sender, EventArgs e)
        {
            Bai04 frm = new Bai04();
            frm.ShowDialog();
        }

        private void btn_Bai02_Click_1(object sender, EventArgs e)
        {

        }
    }
}
