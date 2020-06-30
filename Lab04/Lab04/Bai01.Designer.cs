namespace Lab04
{
    partial class Bai01
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
            this.btn_Get = new System.Windows.Forms.Button();
            this.rtxt_HTML = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txt_Url
            // 
            this.txt_Url.Location = new System.Drawing.Point(13, 14);
            this.txt_Url.Name = "txt_Url";
            this.txt_Url.Size = new System.Drawing.Size(378, 20);
            this.txt_Url.TabIndex = 0;
            this.txt_Url.Text = "https://www.uit.edu.vn/";
            this.txt_Url.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Url_KeyDown);
            // 
            // btn_Get
            // 
            this.btn_Get.Location = new System.Drawing.Point(397, 13);
            this.btn_Get.Name = "btn_Get";
            this.btn_Get.Size = new System.Drawing.Size(75, 23);
            this.btn_Get.TabIndex = 1;
            this.btn_Get.Text = "GET";
            this.btn_Get.UseVisualStyleBackColor = true;
            this.btn_Get.Click += new System.EventHandler(this.btn_Get_Click);
            // 
            // rtxt_HTML
            // 
            this.rtxt_HTML.BackColor = System.Drawing.Color.White;
            this.rtxt_HTML.Location = new System.Drawing.Point(13, 41);
            this.rtxt_HTML.Name = "rtxt_HTML";
            this.rtxt_HTML.ReadOnly = true;
            this.rtxt_HTML.Size = new System.Drawing.Size(459, 308);
            this.rtxt_HTML.TabIndex = 2;
            this.rtxt_HTML.Text = "";
            // 
            // Bai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.rtxt_HTML);
            this.Controls.Add(this.btn_Get);
            this.Controls.Add(this.txt_Url);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Bai01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Url;
        private System.Windows.Forms.Button btn_Get;
        private System.Windows.Forms.RichTextBox rtxt_HTML;
    }
}