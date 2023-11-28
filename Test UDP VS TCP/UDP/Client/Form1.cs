using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            UdpClient udp = new UdpClient();

            //Lấy địa chỉ IP từ textbox và chuyển thành kiểu IPAdress
            IPAddress iPAddress = IPAddress.Parse(txbIP.Text);
            //tạo port
            int port = Convert.ToInt32(TXBpORT.Text);
            //tạo IPEndpoint
            IPEndPoint iPEndPoint = new IPEndPoint(iPAddress, port);

            //Chuyển chuỗi dữ liệu sang kiểu byte
            byte[] sendbytes = Encoding.UTF8.GetBytes(richTextBox1.Text);

            //Gởi dữ liệu đến IPEndPoint đã định nghĩa địa chỉ IP và Port
            udp.Send(sendbytes, sendbytes.Length, iPEndPoint);

            //Xóa dữ liệu vừa gửi ở ô nhập
            richTextBox1.Text = "";

        }
    }
}
