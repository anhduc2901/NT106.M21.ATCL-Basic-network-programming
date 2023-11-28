
namespace Server
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPort = new System.Windows.Forms.Label();
            this.txbPort = new System.Windows.Forms.TextBox();
            this.btnListen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(64, 225);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(847, 255);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Received Message";
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(61, 23);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(34, 17);
            this.lbPort.TabIndex = 8;
            this.lbPort.Text = "Port";
            // 
            // txbPort
            // 
            this.txbPort.Location = new System.Drawing.Point(64, 82);
            this.txbPort.Name = "txbPort";
            this.txbPort.Size = new System.Drawing.Size(70, 22);
            this.txbPort.TabIndex = 7;
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(1018, 76);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(211, 83);
            this.btnListen.TabIndex = 12;
            this.btnListen.Text = "LISTEN";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 699);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPort);
            this.Controls.Add(this.txbPort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.TextBox txbPort;
        private System.Windows.Forms.Button btnListen;
    }
}

