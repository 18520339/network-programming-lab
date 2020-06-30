namespace Lab02
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
            this.btn_Bai01 = new System.Windows.Forms.Button();
            this.btn_Bai02 = new System.Windows.Forms.Button();
            this.btn_Bai04 = new System.Windows.Forms.Button();
            this.btn_Bai03 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Bai01
            // 
            this.btn_Bai01.Location = new System.Drawing.Point(22, 26);
            this.btn_Bai01.Name = "btn_Bai01";
            this.btn_Bai01.Size = new System.Drawing.Size(102, 39);
            this.btn_Bai01.TabIndex = 0;
            this.btn_Bai01.Text = "Bài 01";
            this.btn_Bai01.UseVisualStyleBackColor = true;
            this.btn_Bai01.Click += new System.EventHandler(this.btn_Bai01_Click);
            // 
            // btn_Bai02
            // 
            this.btn_Bai02.Location = new System.Drawing.Point(130, 26);
            this.btn_Bai02.Name = "btn_Bai02";
            this.btn_Bai02.Size = new System.Drawing.Size(102, 39);
            this.btn_Bai02.TabIndex = 3;
            this.btn_Bai02.Text = "Bài 02";
            this.btn_Bai02.UseVisualStyleBackColor = true;
            this.btn_Bai02.Click += new System.EventHandler(this.btn_Bai02_Click);
            // 
            // btn_Bai04
            // 
            this.btn_Bai04.Location = new System.Drawing.Point(130, 71);
            this.btn_Bai04.Name = "btn_Bai04";
            this.btn_Bai04.Size = new System.Drawing.Size(102, 39);
            this.btn_Bai04.TabIndex = 5;
            this.btn_Bai04.Text = "Bài 04";
            this.btn_Bai04.UseVisualStyleBackColor = true;
            this.btn_Bai04.Click += new System.EventHandler(this.btn_Bai04_Click);
            // 
            // btn_Bai03
            // 
            this.btn_Bai03.Location = new System.Drawing.Point(22, 71);
            this.btn_Bai03.Name = "btn_Bai03";
            this.btn_Bai03.Size = new System.Drawing.Size(102, 39);
            this.btn_Bai03.TabIndex = 4;
            this.btn_Bai03.Text = "Bài 03";
            this.btn_Bai03.UseVisualStyleBackColor = true;
            this.btn_Bai03.Click += new System.EventHandler(this.btn_Bai03_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 134);
            this.Controls.Add(this.btn_Bai04);
            this.Controls.Add(this.btn_Bai03);
            this.Controls.Add(this.btn_Bai02);
            this.Controls.Add(this.btn_Bai01);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab02";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Bai01;
        private System.Windows.Forms.Button btn_Bai02;
        private System.Windows.Forms.Button btn_Bai04;
        private System.Windows.Forms.Button btn_Bai03;
    }
}

