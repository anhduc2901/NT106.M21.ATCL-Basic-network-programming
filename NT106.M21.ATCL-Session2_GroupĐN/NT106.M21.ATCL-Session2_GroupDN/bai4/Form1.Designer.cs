
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
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.labHoTen = new System.Windows.Forms.Label();
            this.lbMssv = new System.Windows.Forms.Label();
            this.lbDienThoai = new System.Windows.Forms.Label();
            this.lbToan = new System.Windows.Forms.Label();
            this.lbVan = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMssv = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtToan = new System.Windows.Forms.TextBox();
            this.txtVan = new System.Windows.Forms.TextBox();
            this.lbDTB = new System.Windows.Forms.Label();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.btnDeserialize = new System.Windows.Forms.Button();
            this.txtManHinh = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(68, 255);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(273, 51);
            this.btnNhap.TabIndex = 0;
            this.btnNhap.Text = "NHẬP ";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(68, 396);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(273, 51);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // labHoTen
            // 
            this.labHoTen.AutoSize = true;
            this.labHoTen.Location = new System.Drawing.Point(64, 43);
            this.labHoTen.Name = "labHoTen";
            this.labHoTen.Size = new System.Drawing.Size(61, 17);
            this.labHoTen.TabIndex = 2;
            this.labHoTen.Text = "HỌ TÊN";
            // 
            // lbMssv
            // 
            this.lbMssv.AutoSize = true;
            this.lbMssv.Location = new System.Drawing.Point(64, 87);
            this.lbMssv.Name = "lbMssv";
            this.lbMssv.Size = new System.Drawing.Size(46, 17);
            this.lbMssv.TabIndex = 3;
            this.lbMssv.Text = "MSSV";
            // 
            // lbDienThoai
            // 
            this.lbDienThoai.AutoSize = true;
            this.lbDienThoai.Location = new System.Drawing.Point(64, 141);
            this.lbDienThoai.Name = "lbDienThoai";
            this.lbDienThoai.Size = new System.Drawing.Size(86, 17);
            this.lbDienThoai.TabIndex = 4;
            this.lbDienThoai.Text = "ĐIỆN THOẠI";
            // 
            // lbToan
            // 
            this.lbToan.AutoSize = true;
            this.lbToan.Location = new System.Drawing.Point(421, 43);
            this.lbToan.Name = "lbToan";
            this.lbToan.Size = new System.Drawing.Size(84, 17);
            this.lbToan.TabIndex = 5;
            this.lbToan.Text = "ĐIỂM TOÁN";
            // 
            // lbVan
            // 
            this.lbVan.AutoSize = true;
            this.lbVan.Location = new System.Drawing.Point(421, 87);
            this.lbVan.Name = "lbVan";
            this.lbVan.Size = new System.Drawing.Size(73, 17);
            this.lbVan.TabIndex = 6;
            this.lbVan.Text = "ĐIỂM VĂN";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(154, 43);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(187, 22);
            this.txtHoTen.TabIndex = 7;
            // 
            // txtMssv
            // 
            this.txtMssv.Location = new System.Drawing.Point(154, 87);
            this.txtMssv.Name = "txtMssv";
            this.txtMssv.Size = new System.Drawing.Size(187, 22);
            this.txtMssv.TabIndex = 8;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(154, 141);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(187, 22);
            this.txtDienThoai.TabIndex = 9;
            // 
            // txtToan
            // 
            this.txtToan.Location = new System.Drawing.Point(504, 43);
            this.txtToan.Name = "txtToan";
            this.txtToan.Size = new System.Drawing.Size(187, 22);
            this.txtToan.TabIndex = 10;
            // 
            // txtVan
            // 
            this.txtVan.Location = new System.Drawing.Point(504, 87);
            this.txtVan.Name = "txtVan";
            this.txtVan.Size = new System.Drawing.Size(187, 22);
            this.txtVan.TabIndex = 11;
            // 
            // lbDTB
            // 
            this.lbDTB.AutoSize = true;
            this.lbDTB.Location = new System.Drawing.Point(64, 187);
            this.lbDTB.Name = "lbDTB";
            this.lbDTB.Size = new System.Drawing.Size(36, 17);
            this.lbDTB.TabIndex = 13;
            this.lbDTB.Text = "DTB";
            // 
            // txtDTB
            // 
            this.txtDTB.Location = new System.Drawing.Point(154, 187);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.Size = new System.Drawing.Size(187, 22);
            this.txtDTB.TabIndex = 14;
            // 
            // btnDeserialize
            // 
            this.btnDeserialize.Location = new System.Drawing.Point(68, 325);
            this.btnDeserialize.Name = "btnDeserialize";
            this.btnDeserialize.Size = new System.Drawing.Size(273, 52);
            this.btnDeserialize.TabIndex = 15;
            this.btnDeserialize.Text = "SERIALIZE + DESERIALIZE + XUẤT";
            this.btnDeserialize.UseVisualStyleBackColor = true;
            this.btnDeserialize.Click += new System.EventHandler(this.btnDeserialize_Click_1);
            // 
            // txtManHinh
            // 
            this.txtManHinh.Location = new System.Drawing.Point(424, 141);
            this.txtManHinh.Name = "txtManHinh";
            this.txtManHinh.Size = new System.Drawing.Size(267, 278);
            this.txtManHinh.TabIndex = 16;
            this.txtManHinh.Text = "";
            this.txtManHinh.TextChanged += new System.EventHandler(this.txtManHinh_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "CLEAR FILE INPUT VÀ OUTPUT TRƯỚC KHI CHẠY";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtManHinh);
            this.Controls.Add(this.btnDeserialize);
            this.Controls.Add(this.txtDTB);
            this.Controls.Add(this.lbDTB);
            this.Controls.Add(this.txtVan);
            this.Controls.Add(this.txtToan);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtMssv);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lbVan);
            this.Controls.Add(this.lbToan);
            this.Controls.Add(this.lbDienThoai);
            this.Controls.Add(this.lbMssv);
            this.Controls.Add(this.labHoTen);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnNhap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label labHoTen;
        private System.Windows.Forms.Label lbMssv;
        private System.Windows.Forms.Label lbDienThoai;
        private System.Windows.Forms.Label lbToan;
        private System.Windows.Forms.Label lbVan;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMssv;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtToan;
        private System.Windows.Forms.TextBox txtVan;
        private System.Windows.Forms.Label lbDTB;
        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.Button btnDeserialize;
        private System.Windows.Forms.RichTextBox txtManHinh;
        private System.Windows.Forms.Label label1;
    }
}

