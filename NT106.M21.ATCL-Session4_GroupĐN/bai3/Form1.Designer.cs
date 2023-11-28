
namespace bai3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbReceived = new System.Windows.Forms.TextBox();
            this.btndownload = new System.Windows.Forms.Button();
            this.txbFile = new System.Windows.Forms.TextBox();
            this.txbURL = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "FileToSave";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "URL";
            // 
            // txbReceived
            // 
            this.txbReceived.Location = new System.Drawing.Point(95, 133);
            this.txbReceived.Multiline = true;
            this.txbReceived.Name = "txbReceived";
            this.txbReceived.Size = new System.Drawing.Size(682, 288);
            this.txbReceived.TabIndex = 9;
            // 
            // btndownload
            // 
            this.btndownload.Location = new System.Drawing.Point(534, 29);
            this.btndownload.Name = "btndownload";
            this.btndownload.Size = new System.Drawing.Size(105, 80);
            this.btndownload.TabIndex = 8;
            this.btndownload.Text = "DownLoad";
            this.btndownload.UseVisualStyleBackColor = true;
            this.btndownload.Click += new System.EventHandler(this.btnPOST_Click);
            // 
            // txbFile
            // 
            this.txbFile.Location = new System.Drawing.Point(95, 88);
            this.txbFile.Name = "txbFile";
            this.txbFile.Size = new System.Drawing.Size(421, 22);
            this.txbFile.TabIndex = 7;
            // 
            // txbURL
            // 
            this.txbURL.Location = new System.Drawing.Point(95, 29);
            this.txbURL.Name = "txbURL";
            this.txbURL.Size = new System.Drawing.Size(421, 22);
            this.txbURL.TabIndex = 6;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(672, 29);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(105, 79);
            this.btnOpen.TabIndex = 12;
            this.btnOpen.Text = "Open HTML file";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbReceived);
            this.Controls.Add(this.btndownload);
            this.Controls.Add(this.txbFile);
            this.Controls.Add(this.txbURL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbReceived;
        private System.Windows.Forms.Button btndownload;
        private System.Windows.Forms.TextBox txbFile;
        private System.Windows.Forms.TextBox txbURL;
        private System.Windows.Forms.Button btnOpen;
    }
}

