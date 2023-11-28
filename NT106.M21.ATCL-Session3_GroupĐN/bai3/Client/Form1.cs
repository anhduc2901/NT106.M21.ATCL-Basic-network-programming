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

namespace Client
{
    public partial class Form1 : Form
    {
        //Tạo 1 đối tượng TcpClient
        TcpClient tcpClient = new TcpClient();
        bool connect = false;
        
        public Form1()
        {
            InitializeComponent();           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            Thread thr = new Thread(new ThreadStart(ServerThread));
            thr.Start();
            
        }
        void ServerThread()
        {       
            //Kết nối với server chỉ  1 lần kết nối nhiều lần sẽ bị lỗi
            if(connect==false)
            {
                //2 Kết nối đến Server với 1 địa chỉ Ip và Port xác định
                IPAddress ipAddress = IPAddress.Parse("127.0.0.1");          //Tạo IPadrress 127.0.0.1
                IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 8080);     // Tạo IPEndPoint có ip là IPadrress, port 8080
                tcpClient.Connect(ipEndPoint);                               // Client kết nối đến "IPEndPoint"
                connect = true;
            }
                

            //3 Tạo luồng để đọc và ghi dữ liệu dựa trên NetworkStream 
            NetworkStream ns = tcpClient.GetStream();

            
            //4 Dùng phương thức Write để gửi dữ liệu đến Server 
            Byte[] data = System.Text.Encoding.ASCII.GetBytes("Hello server\n"); // chuyển string thành chuỗi byte để gửi
            ns.Write(data, 0, data.Length);                                      // ghi dữ liệu vào NetworkStream
            
        }
        void Close()
        {

        }
      
    }
}
