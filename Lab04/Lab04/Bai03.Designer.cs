namespace Lab04
{
    partial class Bai03
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
            this.txt_Url = new System.Windows.Forms.TextBox();
            this.btn_Download = new System.Windows.Forms.Button();
            this.rtxt_HTML = new System.Windows.Forms.RichTextBox();
            this.txt_Path = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Url
            // 
            this.txt_Url.Location = new System.Drawing.Point(13, 14);
            this.txt_Url.Name = "txt_Url";
            this.txt_Url.Size = new System.Drawing.Size(378, 20);
            this.txt_Url.TabIndex = 0;
            this.txt_Url.Text = "https://www.uit.edu.vn/";
            // 
            // btn_Download
            // 
            this.btn_Download.Location = new System.Drawing.Point(397, 13);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(75, 23);
            this.btn_Download.TabIndex = 1;
            this.btn_Download.Text = "Download";
            this.btn_Download.UseVisualStyleBackColor = true;
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // rtxt_HTML
            // 
            this.rtxt_HTML.BackColor = System.Drawing.Color.White;
            this.rtxt_HTML.Location = new System.Drawing.Point(13, 66);
            this.rtxt_HTML.Name = "rtxt_HTML";
            this.rtxt_HTML.ReadOnly = true;
            this.rtxt_HTML.Size = new System.Drawing.Size(459, 283);
            this.rtxt_HTML.TabIndex = 2;
            this.rtxt_HTML.Text = "";
            // 
            // txt_Path
            // 
            this.txt_Path.Location = new System.Drawing.Point(13, 40);
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.Size = new System.Drawing.Size(378, 20);
            this.txt_Path.TabIndex = 3;
            // 
            // Bai03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.txt_Path);
            this.Controls.Add(this.rtxt_HTML);
            this.Controls.Add(this.btn_Download);
            this.Controls.Add(this.txt_Url);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Bai03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai03";
            this.Load += new System.EventHandler(this.Bai03_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Url;
        private System.Windows.Forms.Button btn_Download;
        private System.Windows.Forms.RichTextBox rtxt_HTML;
        private System.Windows.Forms.TextBox txt_Path;
    }
}