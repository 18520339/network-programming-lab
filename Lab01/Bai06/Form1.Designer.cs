namespace Bai06
{
    partial class Form1
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
            this.txt_Input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Classify = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Fail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Min = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Max = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Average = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lsv_Subject = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Input
            // 
            this.txt_Input.Location = new System.Drawing.Point(136, 9);
            this.txt_Input.Name = "txt_Input";
            this.txt_Input.Size = new System.Drawing.Size(118, 20);
            this.txt_Input.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập danh sách điểm:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Classify);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_Fail);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_Pass);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_Min);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_Max);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Average);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lsv_Subject);
            this.groupBox1.Location = new System.Drawing.Point(13, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(242, 345);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết quả";
            // 
            // txt_Classify
            // 
            this.txt_Classify.BackColor = System.Drawing.Color.White;
            this.txt_Classify.Location = new System.Drawing.Point(144, 313);
            this.txt_Classify.Multiline = true;
            this.txt_Classify.Name = "txt_Classify";
            this.txt_Classify.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Classify.Size = new System.Drawing.Size(98, 30);
            this.txt_Classify.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Xếp loại:";
            // 
            // txt_Fail
            // 
            this.txt_Fail.BackColor = System.Drawing.Color.White;
            this.txt_Fail.Location = new System.Drawing.Point(144, 257);
            this.txt_Fail.Multiline = true;
            this.txt_Fail.Name = "txt_Fail";
            this.txt_Fail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Fail.Size = new System.Drawing.Size(98, 30);
            this.txt_Fail.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Số môn không đậu:";
            // 
            // txt_Pass
            // 
            this.txt_Pass.BackColor = System.Drawing.Color.White;
            this.txt_Pass.Location = new System.Drawing.Point(144, 201);
            this.txt_Pass.Multiline = true;
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Pass.Size = new System.Drawing.Size(98, 30);
            this.txt_Pass.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số môn đậu:";
            // 
            // txt_Min
            // 
            this.txt_Min.BackColor = System.Drawing.Color.White;
            this.txt_Min.Location = new System.Drawing.Point(144, 145);
            this.txt_Min.Multiline = true;
            this.txt_Min.Name = "txt_Min";
            this.txt_Min.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Min.Size = new System.Drawing.Size(98, 30);
            this.txt_Min.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Môn thấp nhất:";
            // 
            // txt_Max
            // 
            this.txt_Max.BackColor = System.Drawing.Color.White;
            this.txt_Max.Location = new System.Drawing.Point(144, 89);
            this.txt_Max.Multiline = true;
            this.txt_Max.Name = "txt_Max";
            this.txt_Max.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Max.Size = new System.Drawing.Size(98, 30);
            this.txt_Max.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Môn cao nhất:";
            // 
            // txt_Average
            // 
            this.txt_Average.BackColor = System.Drawing.Color.White;
            this.txt_Average.Location = new System.Drawing.Point(144, 33);
            this.txt_Average.Multiline = true;
            this.txt_Average.Name = "txt_Average";
            this.txt_Average.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Average.Size = new System.Drawing.Size(98, 30);
            this.txt_Average.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Điểm trung bình:";
            // 
            // lsv_Subject
            // 
            this.lsv_Subject.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lsv_Subject.FullRowSelect = true;
            this.lsv_Subject.GridLines = true;
            this.lsv_Subject.HideSelection = false;
            this.lsv_Subject.Location = new System.Drawing.Point(0, 19);
            this.lsv_Subject.Name = "lsv_Subject";
            this.lsv_Subject.Size = new System.Drawing.Size(125, 324);
            this.lsv_Subject.TabIndex = 0;
            this.lsv_Subject.UseCompatibleStateImageBehavior = false;
            this.lsv_Subject.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Môn";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Điểm";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(13, 35);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(119, 23);
            this.btn_Calculate.TabIndex = 5;
            this.btn_Calculate.Text = "Tính";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(136, 35);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(119, 23);
            this.btn_Delete.TabIndex = 6;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 422);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Bai06";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lsv_Subject;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox txt_Classify;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Fail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Min;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Max;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Average;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Button btn_Delete;
    }
}

