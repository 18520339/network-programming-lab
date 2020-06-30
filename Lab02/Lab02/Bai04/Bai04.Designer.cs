namespace Lab02
{
    partial class Bai04
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Math = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Chemistry = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Physics = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Read = new System.Windows.Forms.Button();
            this.dgv_Result = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Full_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Math = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Physics = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chemistry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Average = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Result)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSSV:";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(13, 30);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(92, 20);
            this.txt_Id.TabIndex = 1;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(111, 30);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 20);
            this.txt_Name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ và tên:";
            // 
            // txt_Math
            // 
            this.txt_Math.Location = new System.Drawing.Point(13, 69);
            this.txt_Math.Name = "txt_Math";
            this.txt_Math.Size = new System.Drawing.Size(62, 20);
            this.txt_Math.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Điểm Toán:";
            // 
            // txt_Chemistry
            // 
            this.txt_Chemistry.Location = new System.Drawing.Point(149, 69);
            this.txt_Chemistry.Name = "txt_Chemistry";
            this.txt_Chemistry.Size = new System.Drawing.Size(62, 20);
            this.txt_Chemistry.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Điểm Hóa:";
            // 
            // txt_Physics
            // 
            this.txt_Physics.Location = new System.Drawing.Point(81, 69);
            this.txt_Physics.Name = "txt_Physics";
            this.txt_Physics.Size = new System.Drawing.Size(62, 20);
            this.txt_Physics.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Điểm Lý:";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(249, 28);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(143, 23);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "Lưu thông tin học viên";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(117, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "DANH SÁCH HỌC VIÊN";
            // 
            // btn_Read
            // 
            this.btn_Read.Location = new System.Drawing.Point(249, 67);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Size = new System.Drawing.Size(143, 23);
            this.btn_Read.TabIndex = 13;
            this.btn_Read.Text = "Hiển thị danh sách";
            this.btn_Read.UseVisualStyleBackColor = true;
            this.btn_Read.Click += new System.EventHandler(this.btn_Read_Click);
            // 
            // dgv_Result
            // 
            this.dgv_Result.AllowUserToAddRows = false;
            this.dgv_Result.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Full_Name,
            this.Math,
            this.Physics,
            this.Chemistry,
            this.Average});
            this.dgv_Result.Location = new System.Drawing.Point(12, 122);
            this.dgv_Result.Name = "dgv_Result";
            this.dgv_Result.RowHeadersVisible = false;
            this.dgv_Result.Size = new System.Drawing.Size(380, 177);
            this.dgv_Result.TabIndex = 14;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "MSSV";
            this.Id.Name = "Id";
            this.Id.Width = 62;
            // 
            // Full_Name
            // 
            this.Full_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Full_Name.HeaderText = "Họ và tên";
            this.Full_Name.Name = "Full_Name";
            this.Full_Name.Width = 79;
            // 
            // Math
            // 
            this.Math.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Math.HeaderText = "Toán";
            this.Math.Name = "Math";
            this.Math.Width = 57;
            // 
            // Physics
            // 
            this.Physics.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Physics.HeaderText = "Lý";
            this.Physics.Name = "Physics";
            this.Physics.Width = 43;
            // 
            // Chemistry
            // 
            this.Chemistry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Chemistry.HeaderText = "Hóa";
            this.Chemistry.Name = "Chemistry";
            this.Chemistry.Width = 52;
            // 
            // Average
            // 
            this.Average.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Average.HeaderText = "Trung bình";
            this.Average.Name = "Average";
            this.Average.Width = 83;
            // 
            // Bai04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 311);
            this.Controls.Add(this.dgv_Result);
            this.Controls.Add(this.btn_Read);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_Physics);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Chemistry);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Math);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Bai04";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai04";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Math;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Chemistry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Physics;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Read;
        private System.Windows.Forms.DataGridView dgv_Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Full_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Math;
        private System.Windows.Forms.DataGridViewTextBoxColumn Physics;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chemistry;
        private System.Windows.Forms.DataGridViewTextBoxColumn Average;
    }
}