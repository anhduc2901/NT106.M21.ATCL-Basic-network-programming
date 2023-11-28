using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Tạo kết nối UDP
            UdpClient udpClient = new UdpClient();

            string msg = txbMessage.Text;

            //Do ý đồ muốn gởi dữ liệu là "Hello World?" sang bên nhận. Nên cần chuyển chuỗi Hello World sang kiểu byte
            Byte[] sendBytes = Encoding.ASCII.GetBytes(msg);

            // tạo port đc nhập từ textBox1"
            string port = txbPort.Text;

            //Gởi dữ liệu mà không cần thiết lập kết nối với Server
            udpClient.Send(sendBytes, sendBytes.Length, txbHost.Text, Convert.ToInt32(port));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
