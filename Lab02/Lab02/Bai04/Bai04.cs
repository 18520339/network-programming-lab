using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Bai04 : Form
    {
        public Bai04()
        {
            InitializeComponent();
        }

        private static string filePath = Path.Combine(
            Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName,
            "Bai04", 
            "hocvien.txt"
        );

        private void btn_Save_Click(object sender, EventArgs e)
        {
            double math;
            bool mathIsNumber = double.TryParse(txt_Math.Text, out math);

            double physics;
            bool physicsIsNumber = double.TryParse(txt_Physics.Text, out physics);

            double chemistry;
            bool chemistryIsNumber = double.TryParse(txt_Chemistry.Text, out chemistry);

            if (string.IsNullOrWhiteSpace(txt_Id.Text))
            {
                MessageBox.Show("Bạn chưa nhập MSSV");
                txt_Id.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_Name.Text))
            {
                MessageBox.Show("Bạn chưa nhập họ tên");
                txt_Name.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_Math.Text))
            {
                MessageBox.Show("Bạn chưa nhập điểm Toán");
                txt_Math.Focus();
                return;
            }
            else if (!mathIsNumber || float.Parse(txt_Math.Text) < 0 || float.Parse(txt_Math.Text) > 10)
            {
                MessageBox.Show("Điểm Toán phải có giá trị từ 0 đến 10");
                txt_Math.Clear();
                txt_Math.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_Physics.Text))
            {
                MessageBox.Show("Bạn chưa nhập điểm Lý");
                txt_Physics.Focus();
                return;
            }
            else if (!physicsIsNumber || float.Parse(txt_Physics.Text) < 0 || float.Parse(txt_Physics.Text) > 10)
            {
                MessageBox.Show("Điểm Toán phải có giá trị từ 0 đến 10");
                txt_Physics.Clear();
                txt_Physics.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_Chemistry.Text))
            {
                MessageBox.Show("Bạn chưa nhập điểm Hóa");
                txt_Chemistry.Focus();
                return;
            }
            else if (!chemistryIsNumber || float.Parse(txt_Chemistry.Text) < 0 || float.Parse(txt_Chemistry.Text) > 10)
            {
                MessageBox.Show("Điểm Hóa phải có giá trị từ 0 đến 10");
                txt_Chemistry.Clear();
                txt_Chemistry.Focus();
                return;
            }

            HocVien hv = new HocVien();
            hv.Id = txt_Id.Text;
            hv.Name = txt_Name.Text;

            hv.Math = float.Parse(txt_Math.Text);
            hv.Physics = float.Parse(txt_Physics.Text);
            hv.Chemistry = float.Parse(txt_Chemistry.Text);

            FileStream fs = new FileStream(filePath, FileMode.Append);
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            binaryFormatter.Serialize(fs, hv);
            fs.Close();
        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() != DialogResult.OK) return;

            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            dgv_Result.Rows.Clear();

            while (fs.Position != fs.Length)
            {
                int rowIndex = dgv_Result.Rows.Add();
                DataGridViewRow row = dgv_Result.Rows[rowIndex];
                HocVien hv = (HocVien)binaryFormatter.Deserialize(fs);

                row.Cells["Id"].Value = hv.Id;
                row.Cells["Full_Name"].Value = hv.Name;

                row.Cells["Math"].Value = hv.Math;
                row.Cells["Physics"].Value = hv.Physics;
                row.Cells["Chemistry"].Value = hv.Chemistry;
                row.Cells["Average"].Value = hv.CalcAverage();
            }
            fs.Close();
        }
    }
}
