using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            lsv_Subject.Items.Clear();
            txt_Average.Clear();
            txt_Max.Clear();
            txt_Min.Clear();
            txt_Pass.Clear();
            txt_Fail.Clear();
            txt_Classify.Clear();

            String[] arrPoints = txt_Input.Text.Trim().Split(',');
            List<double[]> arrResult = new List<double[]>();

            double sumPoints, averagePoint;
            double maxPoint, minPoint, passCount;

            for (int i = 0; i < arrPoints.Length; i++)
            {
                double point;
                bool isNumber = double.TryParse(arrPoints[i], out point);
                
                if (!isNumber)
                {
                    lsv_Subject.Items.Clear();
                    txt_Input.Clear();
                    txt_Input.Focus();
                    MessageBox.Show("Sai định dạng");
                    return;
                }

                if (point < 0 || point > 10)
                {
                    lsv_Subject.Items.Clear();
                    txt_Input.Clear();
                    txt_Input.Focus();
                    MessageBox.Show("Điểm " + point + " không hợp lệ\nĐiểm phải có gái trị từ 0 đến 10");
                    return;
                }

                string[] cols = new string[2];
                cols[0] = "Môn " + (i + 1);
                cols[1] = point.ToString();

                arrResult.Add(new double[] { i + 1, point });
                lsv_Subject.Items.Add(new ListViewItem(cols));
            }

            sumPoints = arrResult.Select(item => item[1]).Sum();
            averagePoint = sumPoints / arrResult.Count();

            maxPoint = arrResult.Select(item => item[1]).Max();
            minPoint = arrResult.Select(item => item[1]).Min();
            passCount = arrResult.FindAll(item => item[1] >= 5).Count();

            txt_Average.Text = averagePoint.ToString();
            txt_Pass.Text = passCount.ToString();
            txt_Fail.Text = (arrResult.Count() - passCount).ToString();

            txt_Max.Text = string.Join(", ", 
                arrResult
                    .FindAll(item => item[1] == maxPoint)
                    .Select(item => "Môn " + item[0])
            );

            txt_Min.Text = string.Join(", ",
                arrResult
                    .FindAll(item => item[1] == minPoint)
                    .Select(item => "Môn " + item[0])
            );

            if (averagePoint >= 8 && arrResult.Find(item => item[1] < 6.5) == null)
                txt_Classify.Text = "Giỏi";
            else if (averagePoint >= 6.5 && arrResult.Find(item => item[1] < 5) == null)
                txt_Classify.Text = "Khá";
            else if (averagePoint >= 5 && arrResult.Find(item => item[1] < 3.5) == null)
                txt_Classify.Text = "Trung bình";
            else if (averagePoint >= 3.5 && arrResult.Find(item => item[1] < 2) == null)
                txt_Classify.Text = "Yếu";
            else
                txt_Classify.Text = "Kém";
        }
    }
}
