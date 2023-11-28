
namespace ProcessGUI
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
            this.txblog = new System.Windows.Forms.TextBox();
            this.bntProcess = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHidden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txblog
            // 
            this.txblog.Location = new System.Drawing.Point(103, 12);
            this.txblog.Multiline = true;
            this.txblog.Name = "txblog";
            this.txblog.Size = new System.Drawing.Size(528, 306);
            this.txblog.TabIndex = 0;
            // 
            // bntProcess
            // 
            this.bntProcess.Location = new System.Drawing.Point(694, 12);
            this.bntProcess.Name = "bntProcess";
            this.bntProcess.Size = new System.Drawing.Size(87, 56);
            this.bntProcess.TabIndex = 1;
            this.bntProcess.Text = "Get Process";
            this.bntProcess.UseVisualStyleBackColor = true;
            this.bntProcess.Click += new System.EventHandler(this.bntProcess_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(694, 129);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(87, 56);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start Process";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnHidden
            // 
            this.btnHidden.Location = new System.Drawing.Point(694, 262);
            this.btnHidden.Name = "btnHidden";
            this.btnHidden.Size = new System.Drawing.Size(87, 56);
            this.btnHidden.TabIndex = 3;
            this.btnHidden.Text = "Hidden";
            this.btnHidden.UseVisualStyleBackColor = true;
            this.btnHidden.Click += new System.EventHandler(this.btnHidden_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHidden);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.bntProcess);
            this.Controls.Add(this.txblog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txblog;
        private System.Windows.Forms.Button bntProcess;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnHidden;
    }
}

