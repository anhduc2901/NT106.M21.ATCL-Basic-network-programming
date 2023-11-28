
namespace bai2
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
            this.txbURL = new System.Windows.Forms.TextBox();
            this.txbMessage = new System.Windows.Forms.TextBox();
            this.btnPOST = new System.Windows.Forms.Button();
            this.txbReceived = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbURL
            // 
            this.txbURL.Location = new System.Drawing.Point(74, 19);
            this.txbURL.Name = "txbURL";
            this.txbURL.Size = new System.Drawing.Size(421, 22);
            this.txbURL.TabIndex = 0;
            this.txbURL.TextChanged += new System.EventHandler(this.txbURL_TextChanged);
            // 
            // txbMessage
            // 
            this.txbMessage.Location = new System.Drawing.Point(74, 78);
            this.txbMessage.Name = "txbMessage";
            this.txbMessage.Size = new System.Drawing.Size(421, 22);
            this.txbMessage.TabIndex = 1;
            this.txbMessage.TextChanged += new System.EventHandler(this.txbMessage_TextChanged);
            // 
            // btnPOST
            // 
            this.btnPOST.Location = new System.Drawing.Point(580, 19);
            this.btnPOST.Name = "btnPOST";
            this.btnPOST.Size = new System.Drawing.Size(176, 80);
            this.btnPOST.TabIndex = 2;
            this.btnPOST.Text = "POST";
            this.btnPOST.UseVisualStyleBackColor = true;
            this.btnPOST.Click += new System.EventHandler(this.btnPOST_Click);
            // 
            // txbReceived
            // 
            this.txbReceived.Location = new System.Drawing.Point(74, 123);
            this.txbReceived.Multiline = true;
            this.txbReceived.Name = "txbReceived";
            this.txbReceived.Size = new System.Drawing.Size(682, 288);
            this.txbReceived.TabIndex = 3;
            this.txbReceived.TextChanged += new System.EventHandler(this.txbReceived_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "URL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Message";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbReceived);
            this.Controls.Add(this.btnPOST);
            this.Controls.Add(this.txbMessage);
            this.Controls.Add(this.txbURL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbURL;
        private System.Windows.Forms.TextBox txbMessage;
        private System.Windows.Forms.Button btnPOST;
        private System.Windows.Forms.TextBox txbReceived;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

