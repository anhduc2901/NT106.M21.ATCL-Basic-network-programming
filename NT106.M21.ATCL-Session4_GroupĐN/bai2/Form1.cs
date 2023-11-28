using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txbURL.Text = "http://www.contoso.com/PostAccepter.aspx";
        }

        private void btnPOST_Click(object sender, EventArgs e)
        {
            // Create a request using a URL that can receive a post.            | Tạo request đến URL mà mình muốn nó nhận message
            WebRequest request = WebRequest.Create(txbURL.Text);
            // Set the Method property of the request to POST.                  | Đặt thuộc tính request đến URL là "POST"
            request.Method = "POST";

            // Create POST data and convert it to a byte array.                   | Dữ liệu gửi là thông tin chúng ta nhập
            string postData = txbMessage.Text;
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);                 // Chuyển dữ liệu cần gửi sang chuỗi byte

            // Set the ContentType property of the WebRequest.                   // Thiết lập thuộc tính Content Type của WebRequest.
            request.ContentType = "application/x-www-form-urlencoded";
            // Set the ContentLength property of the WebRequest.                 // Thiết lập độ dài của nội dung trả về
            request.ContentLength = byteArray.Length;

            // Get the request stream.                                           // Lưu nội dung muốn POST vào luồng 
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.                             // Gửi luồng đến server 
            dataStream.Write(byteArray, 0, byteArray.Length);
            // Close the Stream object.                                          // Đóng luồng
            dataStream.Close();

            // Get the response.                                                 // Lấy thông tin phản hồi từ server
            WebResponse response = request.GetResponse();
            // Display the status.                                               // Hiển thị trạng thái.
            MessageBox.Show(((HttpWebResponse)response).StatusDescription,"Trạng thái");

            // Get the stream containing content returned by the server.        // Lấy dữ liệu trả về từ server
            // The using block ensures the stream is automatically closed.      // "using" đảm bảo rằng luồng tự động đóng
            using (dataStream = response.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.        // Mở luồng bằng StreamReader để dễ dàng truy cập
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.                                            // Đọc và lưu vào 1 string
                string responseFromServer = reader.ReadToEnd();
                // Display the content.                                         // Hiển thị nội dung phản hồi từ server
                txbReceived.Text = responseFromServer;
            }

            // Close the response.
            response.Close();



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txbReceived_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txbMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbURL_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
