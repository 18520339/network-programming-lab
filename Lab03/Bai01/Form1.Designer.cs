namespace Bai01
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
            this.btn_Server = new System.Windows.Forms.Button();
            this.btn_Client = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Server
            // 
            this.btn_Server.Location = new System.Drawing.Point(12, 14);
            this.btn_Server.Name = "btn_Server";
            this.btn_Server.Size = new System.Drawing.Size(93, 23);
            this.btn_Server.TabIndex = 0;
            this.btn_Server.Text = "UDP Server";
            this.btn_Server.UseVisualStyleBackColor = true;
            this.btn_Server.Click += new System.EventHandler(this.btn_Server_Click);
            // 
            // btn_Client
            // 
            this.btn_Client.Location = new System.Drawing.Point(129, 14);
            this.btn_Client.Name = "btn_Client";
            this.btn_Client.Size = new System.Drawing.Size(93, 23);
            this.btn_Client.TabIndex = 1;
            this.btn_Client.Text = "UDP Client";
            this.btn_Client.UseVisualStyleBackColor = true;
            this.btn_Client.Click += new System.EventHandler(this.btn_Client_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 51);
            this.Controls.Add(this.btn_Client);
            this.Controls.Add(this.btn_Server);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai01";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Server;
        private System.Windows.Forms.Button btn_Client;
    }
}

