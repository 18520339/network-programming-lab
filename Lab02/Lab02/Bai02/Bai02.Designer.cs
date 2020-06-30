namespace Lab02
{
    partial class Bai02
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
            this.btn_Read = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Url = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Lines = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Words = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Chars = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rtxt_Result = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_Read
            // 
            this.btn_Read.Location = new System.Drawing.Point(13, 13);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Size = new System.Drawing.Size(153, 23);
            this.btn_Read.TabIndex = 0;
            this.btn_Read.Text = "ĐỌC FILE";
            this.btn_Read.UseVisualStyleBackColor = true;
            this.btn_Read.Click += new System.EventHandler(this.btn_Read_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên file";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(66, 42);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 20);
            this.txt_Name.TabIndex = 3;
            // 
            // txt_Url
            // 
            this.txt_Url.Location = new System.Drawing.Point(66, 68);
            this.txt_Url.Name = "txt_Url";
            this.txt_Url.Size = new System.Drawing.Size(100, 20);
            this.txt_Url.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Url";
            // 
            // txt_Lines
            // 
            this.txt_Lines.Location = new System.Drawing.Point(66, 94);
            this.txt_Lines.Name = "txt_Lines";
            this.txt_Lines.Size = new System.Drawing.Size(100, 20);
            this.txt_Lines.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số dòng";
            // 
            // txt_Words
            // 
            this.txt_Words.Location = new System.Drawing.Point(66, 120);
            this.txt_Words.Name = "txt_Words";
            this.txt_Words.Size = new System.Drawing.Size(100, 20);
            this.txt_Words.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số từ";
            // 
            // txt_Chars
            // 
            this.txt_Chars.Location = new System.Drawing.Point(66, 146);
            this.txt_Chars.Name = "txt_Chars";
            this.txt_Chars.Size = new System.Drawing.Size(100, 20);
            this.txt_Chars.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Số ký tự";
            // 
            // rtxt_Result
            // 
            this.rtxt_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rtxt_Result.Location = new System.Drawing.Point(173, 13);
            this.rtxt_Result.Name = "rtxt_Result";
            this.rtxt_Result.Size = new System.Drawing.Size(199, 156);
            this.rtxt_Result.TabIndex = 12;
            this.rtxt_Result.Text = "";
            // 
            // Bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 181);
            this.Controls.Add(this.rtxt_Result);
            this.Controls.Add(this.txt_Chars);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Words);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Lines);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Url);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Read);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Bai02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Read;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Url;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Lines;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Words;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Chars;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtxt_Result;
    }
}