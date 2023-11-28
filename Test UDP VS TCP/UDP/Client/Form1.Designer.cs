
namespace Client
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
            this.txbIP = new System.Windows.Forms.TextBox();
            this.TXBpORT = new System.Windows.Forms.TextBox();
            this.lbPort = new System.Windows.Forms.Label();
            this.lbHost = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbIP
            // 
            this.txbIP.Location = new System.Drawing.Point(58, 89);
            this.txbIP.Name = "txbIP";
            this.txbIP.Size = new System.Drawing.Size(218, 22);
            this.txbIP.TabIndex = 0;
            // 
            // TXBpORT
            // 
            this.TXBpORT.Location = new System.Drawing.Point(696, 89);
            this.TXBpORT.Name = "TXBpORT";
            this.TXBpORT.Size = new System.Drawing.Size(70, 22);
            this.TXBpORT.TabIndex = 1;
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(693, 30);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(34, 17);
            this.lbPort.TabIndex = 2;
            this.lbPort.Text = "Port";
            // 
            // lbHost
            // 
            this.lbHost.AutoSize = true;
            this.lbHost.Location = new System.Drawing.Point(55, 30);
            this.lbHost.Name = "lbHost";
            this.lbHost.Size = new System.Drawing.Size(101, 17);
            this.lbHost.TabIndex = 3;
            this.lbHost.Text = "IP remote Host";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Message";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(58, 221);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(847, 255);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(462, 492);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(195, 33);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 537);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbHost);
            this.Controls.Add(this.lbPort);
            this.Controls.Add(this.TXBpORT);
            this.Controls.Add(this.txbIP);
            this.Name = "Form1";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbIP;
        private System.Windows.Forms.TextBox TXBpORT;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.Label lbHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSend;
    }
}

