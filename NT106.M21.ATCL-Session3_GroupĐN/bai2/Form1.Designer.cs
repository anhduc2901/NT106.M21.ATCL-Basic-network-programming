
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
            this.btnListen = new System.Windows.Forms.Button();
            this.lsvMessage = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(279, 96);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(441, 70);
            this.btnListen.TabIndex = 1;
            this.btnListen.Text = "LISTEN";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.button1_Click);
            // 
            // lsvMessage
            // 
            this.lsvMessage.HideSelection = false;
            this.lsvMessage.Location = new System.Drawing.Point(279, 210);
            this.lsvMessage.Name = "lsvMessage";
            this.lsvMessage.Size = new System.Drawing.Size(441, 285);
            this.lsvMessage.TabIndex = 2;
            this.lsvMessage.UseCompatibleStateImageBehavior = false;
            this.lsvMessage.View = System.Windows.Forms.View.List;
            this.lsvMessage.SelectedIndexChanged += new System.EventHandler(this.listViewCommand_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 649);
            this.Controls.Add(this.lsvMessage);
            this.Controls.Add(this.btnListen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.ListView lsvMessage;
    }
}

