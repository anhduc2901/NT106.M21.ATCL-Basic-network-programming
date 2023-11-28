
namespace ListviewP2
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
            this.lsvShow = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsvShow
            // 
            this.lsvShow.HideSelection = false;
            this.lsvShow.Location = new System.Drawing.Point(65, 28);
            this.lsvShow.Name = "lsvShow";
            this.lsvShow.Size = new System.Drawing.Size(984, 484);
            this.lsvShow.TabIndex = 0;
            this.lsvShow.UseCompatibleStateImageBehavior = false;
            this.lsvShow.SelectedIndexChanged += new System.EventHandler(this.lsvShow_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1101, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 80);
            this.button1.TabIndex = 1;
            this.button1.Text = "Large Icon";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1101, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 73);
            this.button2.TabIndex = 2;
            this.button2.Text = "Small Icon";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1101, 376);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 93);
            this.button3.TabIndex = 3;
            this.button3.Text = "Details";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 715);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lsvShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvShow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

