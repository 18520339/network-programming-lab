namespace Bai03
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
            this.btn_Listen = new System.Windows.Forms.Button();
            this.lsv_Messages = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_Listen
            // 
            this.btn_Listen.Location = new System.Drawing.Point(297, 13);
            this.btn_Listen.Name = "btn_Listen";
            this.btn_Listen.Size = new System.Drawing.Size(75, 23);
            this.btn_Listen.TabIndex = 0;
            this.btn_Listen.Text = "Listen";
            this.btn_Listen.UseVisualStyleBackColor = true;
            this.btn_Listen.Click += new System.EventHandler(this.btn_Listen_Click);
            // 
            // lsv_Messages
            // 
            this.lsv_Messages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lsv_Messages.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lsv_Messages.HideSelection = false;
            this.lsv_Messages.Location = new System.Drawing.Point(12, 43);
            this.lsv_Messages.Name = "lsv_Messages";
            this.lsv_Messages.Size = new System.Drawing.Size(360, 206);
            this.lsv_Messages.TabIndex = 1;
            this.lsv_Messages.UseCompatibleStateImageBehavior = false;
            this.lsv_Messages.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 330;
            // 
            // frm_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.lsv_Messages);
            this.Controls.Add(this.btn_Listen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Server_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Listen;
        private System.Windows.Forms.ListView lsv_Messages;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}