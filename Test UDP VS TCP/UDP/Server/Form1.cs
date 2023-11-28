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

namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            int port = Convert.ToInt32(txbPort.Text);
            UdpClient udpClient = new UdpClient(port);

            while (true)
            {
                //Nhận dữ liệu từ all
                IPEndPoint IpEnd = new IPEndPoint(IPAddress.Any, 0);

                //Đón nhận và đẩy dữ liệu nhận được vào mảng Byte
                Byte[] recvBytes = udpClient.Receive(ref IpEnd);
                string Data = Encoding.UTF8.GetString(recvBytes);
                string mess = IpEnd.Address.ToString() + ":" +
                IpEnd.Port.ToString() + ": " + Data.ToString();
                // Gọi hàm hiển thị thông điệp nhận được lên màn hình
                InfoMessage(mess);
            }
        }

        private void InfoMessage(string mess)
        {
            richTextBox1.Text = mess;
        }
    }
}
