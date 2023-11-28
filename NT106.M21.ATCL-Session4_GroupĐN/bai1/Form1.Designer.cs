
namespace bai1
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
            this.btnGet = new System.Windows.Forms.Button();
            this.txbReceived = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbURL
            // 
            this.txbURL.Location = new System.Drawing.Point(63, 29);
            this.txbURL.Name = "txbURL";
            this.txbURL.Size = new System.Drawing.Size(325, 22);
            this.txbURL.TabIndex = 0;
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(510, 29);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(172, 70);
            this.btnGet.TabIndex = 2;
            this.btnGet.Text = "GET";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // txbReceived
            // 
            this.txbReceived.Location = new System.Drawing.Point(63, 105);
            this.txbReceived.Name = "txbReceived";
            this.txbReceived.Size = new System.Drawing.Size(619, 243);
            this.txbReceived.TabIndex = 3;
            this.txbReceived.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "URL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 456);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbReceived);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.txbURL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbURL;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.RichTextBox txbReceived;
        private System.Windows.Forms.Label label1;
    }
}

