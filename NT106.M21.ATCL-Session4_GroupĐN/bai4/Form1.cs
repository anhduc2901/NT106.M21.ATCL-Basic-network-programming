using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Diagnostics;


namespace bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txbURL.Text = "https://www.google.com/";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            //Truy cập vào URL trên textbox
            webBrowser1.Navigate(txbURL.Text);
        }

        private void btnViewSource_Click(object sender, EventArgs e)
        {
            // tên file lưu nguồn của trang web
            String source = ("viewsource.txt");
            //Tạo file với tên ở trên
            StreamWriter writer = File.CreateText(source);
            // Ghi dữ liệu vào file 
            writer.Write(webBrowser1.DocumentText);
            // đóng luồng
            writer.Close();
            //Mở file
            Process.Start("notepad.exe", source);
        }

        private void btnDownLoad_Click(object sender, EventArgs e)
            {
            //Tạo đối tượng "myClient" có kiểu dữ liệu "WebClient"
            var myClient = new WebClient();
            // tạo luồng đọc Source của URL nhập vào        
            Stream response2 = myClient.OpenRead(txbURL.Text);
            // Download source và lưu vào file html
            myClient.DownloadFile(txbURL.Text, @"D:\LẬP TRÌNH MẠNG CĂN BẢN\NT106.M21.ATCL-Session4_GroupĐN\In4_downloaded_of_bai4.html");
            // Đóng luồng 
            response2.Close();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Mở file HTML đã download
            Process.Start(@"D:\LẬP TRÌNH MẠNG CĂN BẢN\NT106.M21.ATCL-Session4_GroupĐN\In4_downloaded_of_bai4.html");
        }
    }
}
