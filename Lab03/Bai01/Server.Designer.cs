namespace Bai01
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.btn_Listen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lsv_Messages = new System.Windows.Forms.ListView();
            this.client_info = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.messages = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(44, 15);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(100, 20);
            this.txt_Port.TabIndex = 1;
            this.txt_Port.Text = "8080";
            // 
            // btn_Listen
            // 
            this.btn_Listen.Location = new System.Drawing.Point(297, 13);
            this.btn_Listen.Name = "btn_Listen";
            this.btn_Listen.Size = new System.Drawing.Size(75, 23);
            this.btn_Listen.TabIndex = 2;
            this.btn_Listen.Text = "Listen";
            this.btn_Listen.UseVisualStyleBackColor = true;
            this.btn_Listen.Click += new System.EventHandler(this.btn_Listen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Received messages";
            // 
            // lsv_Messages
            // 
            this.lsv_Messages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsv_Messages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.client_info,
            this.messages});
            this.lsv_Messages.FullRowSelect = true;
            this.lsv_Messages.GridLines = true;
            this.lsv_Messages.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lsv_Messages.HideSelection = false;
            this.lsv_Messages.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lsv_Messages.Location = new System.Drawing.Point(15, 64);
            this.lsv_Messages.Name = "lsv_Messages";
            this.lsv_Messages.Size = new System.Drawing.Size(357, 185);
            this.lsv_Messages.TabIndex = 4;
            this.lsv_Messages.UseCompatibleStateImageBehavior = false;
            this.lsv_Messages.View = System.Windows.Forms.View.Details;
            // 
            // client_info
            // 
            this.client_info.Text = "Client";
            this.client_info.Width = 120;
            // 
            // messages
            // 
            this.messages.Text = "Messages";
            this.messages.Width = 220;
            // 
            // frm_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.lsv_Messages);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Listen);
            this.Controls.Add(this.txt_Port);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Server_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.Button btn_Listen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lsv_Messages;
        private System.Windows.Forms.ColumnHeader client_info;
        private System.Windows.Forms.ColumnHeader messages;
    }
}