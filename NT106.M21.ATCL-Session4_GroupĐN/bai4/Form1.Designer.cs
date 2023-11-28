
namespace bai4
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
            this.btnGo = new System.Windows.Forms.Button();
            this.btnViewSource = new System.Windows.Forms.Button();
            this.btnDownLoad = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbURL
            // 
            this.txbURL.Location = new System.Drawing.Point(66, 27);
            this.txbURL.Name = "txbURL";
            this.txbURL.Size = new System.Drawing.Size(486, 22);
            this.txbURL.TabIndex = 0;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(658, 27);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(164, 22);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go to this URL";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnViewSource
            // 
            this.btnViewSource.Location = new System.Drawing.Point(913, 27);
            this.btnViewSource.Name = "btnViewSource";
            this.btnViewSource.Size = new System.Drawing.Size(164, 22);
            this.btnViewSource.TabIndex = 2;
            this.btnViewSource.Text = "View Source";
            this.btnViewSource.UseVisualStyleBackColor = true;
            this.btnViewSource.Click += new System.EventHandler(this.btnViewSource_Click);
            // 
            // btnDownLoad
            // 
            this.btnDownLoad.Location = new System.Drawing.Point(1124, 27);
            this.btnDownLoad.Name = "btnDownLoad";
            this.btnDownLoad.Size = new System.Drawing.Size(134, 22);
            this.btnDownLoad.TabIndex = 3;
            this.btnDownLoad.Text = "Down Load HTML ";
            this.btnDownLoad.UseVisualStyleBackColor = true;
            this.btnDownLoad.Click += new System.EventHandler(this.btnDownLoad_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(66, 83);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1378, 564);
            this.webBrowser1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(582, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "<-----------";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(1282, 27);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(134, 22);
            this.btnOpen.TabIndex = 7;
            this.btnOpen.Text = "Open HTML file";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 691);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnDownLoad);
            this.Controls.Add(this.btnViewSource);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txbURL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbURL;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnViewSource;
        private System.Windows.Forms.Button btnDownLoad;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpen;
    }
}

