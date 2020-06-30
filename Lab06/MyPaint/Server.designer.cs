namespace MyPaint
{
    partial class frm_Server
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
            this.btn_AddClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_NumClients = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_AddClient
            // 
            this.btn_AddClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddClient.Location = new System.Drawing.Point(157, 12);
            this.btn_AddClient.Name = "btn_AddClient";
            this.btn_AddClient.Size = new System.Drawing.Size(74, 25);
            this.btn_AddClient.TabIndex = 2;
            this.btn_AddClient.Text = "Add Client";
            this.btn_AddClient.UseVisualStyleBackColor = true;
            this.btn_AddClient.Click += new System.EventHandler(this.btn_AddClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of Clients:";
            // 
            // lbl_NumClients
            // 
            this.lbl_NumClients.AutoSize = true;
            this.lbl_NumClients.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumClients.Location = new System.Drawing.Point(117, 17);
            this.lbl_NumClients.Name = "lbl_NumClients";
            this.lbl_NumClients.Size = new System.Drawing.Size(14, 15);
            this.lbl_NumClients.TabIndex = 4;
            this.lbl_NumClients.Text = "0";
            // 
            // frm_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 49);
            this.Controls.Add(this.lbl_NumClients);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AddClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frm_Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Server_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_AddClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_NumClients;
    }
}