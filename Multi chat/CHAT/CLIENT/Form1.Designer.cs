namespace CLIENT
{
    partial class frmCLIENT
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
            this.btnSend = new System.Windows.Forms.Button();
            this.lsvMessage = new System.Windows.Forms.ListView();
            this.txbMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(452, 344);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(155, 108);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lsvMessage
            // 
            this.lsvMessage.HideSelection = false;
            this.lsvMessage.Location = new System.Drawing.Point(13, 13);
            this.lsvMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lsvMessage.Name = "lsvMessage";
            this.lsvMessage.Size = new System.Drawing.Size(517, 264);
            this.lsvMessage.TabIndex = 2;
            this.lsvMessage.UseCompatibleStateImageBehavior = false;
            this.lsvMessage.View = System.Windows.Forms.View.List;
            // 
            // txbMessage
            // 
            this.txbMessage.Location = new System.Drawing.Point(11, 426);
            this.txbMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbMessage.Multiline = true;
            this.txbMessage.Name = "txbMessage";
            this.txbMessage.Size = new System.Drawing.Size(391, 26);
            this.txbMessage.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Your name";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(15, 344);
            this.txbName.Margin = new System.Windows.Forms.Padding(4);
            this.txbName.Multiline = true;
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(391, 26);
            this.txbName.TabIndex = 6;
            // 
            // frmCLIENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 472);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbMessage);
            this.Controls.Add(this.lsvMessage);
            this.Controls.Add(this.btnSend);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCLIENT";
            this.Text = "CLIENT";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCLIENT_FormClosed);
            this.Load += new System.EventHandler(this.frmCLIENT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListView lsvMessage;
        private System.Windows.Forms.TextBox txbMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbName;
    }
}

