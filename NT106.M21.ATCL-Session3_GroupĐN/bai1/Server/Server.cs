using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            
        }
        public void serverThread()
        {
            // Khởi tạo udpClient và liên kết nó đến  "port" được nhập vào từ "textBox2"
            // Dịch vụ mạng UDP
            string port = textBox2.Text;
            UdpClient udpClient = new UdpClient(Int32.Parse(port.Trim()));
            
            // While dế lắng nghe cho đến khi tắt chương trình thì thôi
            while (true)
            {
                            
                // tạo IPEndPoint chấp nhận mọi IP  từ client gửi thông tin qua port mà port này
                // là port đc nhập từ "textBox2" trong form của Server
                IPEndPoint RemotelpEndPoint = new IPEndPoint(IPAddress.Any, Int32.Parse(port));

                // tạo 1 mảng byte lưu dữ liệu từ udpClient
                Byte[] receiveBytes = udpClient.Receive(ref RemotelpEndPoint);

                // chuyển dữ liệu qua kiểu string để xuất ra màn hình
                string returnData = Encoding.ASCII.GetString(receiveBytes);

                // gán dữ liệu và "address của RemotelpEndPoint" vào string mess
                string mess = RemotelpEndPoint.Address.ToString() + ":" +
                       returnData.ToString();

                // Xuất dữ liệu ra màn hình
                listView1.Items.Add(mess);             
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            Thread thr = new Thread(serverThread);
            thr.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
