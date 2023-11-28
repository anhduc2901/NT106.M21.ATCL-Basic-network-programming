using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txbURL.Text = "https://www.uit.edu.vn/";
            txbFile.Text = @"D:\LẬP TRÌNH MẠNG CĂN BẢN\NT106.M21.ATCL-Session4_GroupĐN\In4_downloaded_of_bai3.html";
        }

        //Sự kiện nhấn nút DownLoad
        private void btnPOST_Click(object sender, EventArgs e)
        {
            // Create a request for the URL.                                |  Tạo request cho URL
            WebRequest request = WebRequest.Create(txbURL.Text);
            // Get the response.                                            |  response khi request
            WebResponse response = request.GetResponse();
            // Get the stream containing content returned by the server.    |   Lấy luồng lưu dữ liệu trả về bởi server
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.        |   Mở luồng bằng StreamReader để dễ truy cập
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.                                            |   tạo 1 string lưu dữ liệu đọc được
            string responseFromServer = reader.ReadToEnd();
            
            // Hiển thị nội dung của URL
            txbReceived.Text = responseFromServer;

            // Close the response.                                          |   Đóng phản hồi
            response.Close();

            var myClient = new WebClient();

            // The stream data is used here.                
            Stream response2 = myClient.OpenRead(txbURL.Text);

            // Tải tài nguyên từ URL xuống tệp
            myClient.DownloadFile(txbURL.Text, txbFile.Text);
            response2.Close();
           

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            // mở file html đã tải xuống
            Process.Start(txbFile.Text);
        }
    }
}
