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

namespace bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txbURL.Text = "https://student.uit.edu.vn/";
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if(txbURL.Text!="")
            {
                txbReceived.Text = getHTML(txbURL.Text);
            }
            else
            {
                MessageBox.Show("Hãy nhập URL để lấy dữ liệu HTML ! ");
            }
        }
        private string getHTML(string szUrl)
        {
            // Create a request for the URL.                                |  Tạo request cho URL
            WebRequest request = WebRequest.Create(szUrl);

            // Get the response.                                            |  response khi request
            WebResponse response = request.GetResponse();

            // Get the stream containing content returned by the server.    |   Lấy luồng lưu dữ liệu trả về bởi server
            Stream dataStream = response.GetResponseStream();

            // Open the stream using a StreamReader for easy access.        |   Mở luồng bằng StreamReader để dễ truy cập
            StreamReader reader = new StreamReader(dataStream);

            // Read the content.                                            |   tạo 1 string lưu dữ liệu đọc được
            string responseFromServer = reader.ReadToEnd();

            // Close the response.                                          |   Đóng phản hồi
            response.Close();

            return responseFromServer;

        }
    }
}
