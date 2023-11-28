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

namespace bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

       
        void StartUnsafeThread()
        {
            int bytesReceived = 0;

            // Khởi tạo mảng byte nhận dữ liệu
            byte[] recv = new byte[1];

            // Tạo socket bên gởi
            Socket clientSocket;

            // * Tạo socket bên nhận, socket này là socket lắng nghe các kết nối tới nó tại địa chỉ IP của máy
            //và port 8080.Đây là 1 TCP / IP socket.
             
            // Ba tham số của hàm đi với nhau khi ta thực hiện kết nối TCP.
             Socket listenerSocket = new Socket
             (
              //trả về họ địa chỉ của địa chỉ IP hiện hành. Ở đây là địa chỉ Ipv4 nên chọn AddressFamily.InterNetwork
              AddressFamily.InterNetwork,
              //SocketType: kiểu kết nối socket, ở đây dùng luồng Stream để nhận dữ liệu
              SocketType.Stream,
              //ProtocolType: sử dụng giao thức kết nối nào, ở đây sử dụng kết nối TCP
              ProtocolType.Tcp
              );

            //tạo IPEndPoint để client có thể gửi thông tin đến server
            // hay server giao tiếp với client có ip là "127.0.0.1"
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);

            // Gán socket lắng nghe tới địa chỉ IP của máy và port 8080
            listenerSocket.Bind(ipepServer);

            // bắt đầu lắng nghe.Socket.Listen(int backlog)
            // với backlog: là độ dài tối đa của hàng đợi các kết nối đang chờ xử lý
            listenerSocket.Listen(-1);

            //Đồng ý kết nối - create connection
            clientSocket = listenerSocket.Accept();

            //Thông báo client đã kết nối được
            lsvMessage.Items.Add(new ListViewItem("New client connected"));

            //Khi client vẫn đang kết nối tới server 
            while (clientSocket.Connected)
            {
                // tạo 1 string để lưu dữ liệu
                string text = "";
            do
                {
                    // bytesReceived kiểu int
                    // nhận dữ liệu từ socket , lưu vào  buffer "recv"
                    bytesReceived = clientSocket.Receive(recv);
                    // giải mã byte thành string và gán ( text = text + string )
                    text += Encoding.ASCII.GetString(recv);
                } while (text[text.Length - 1] != '\n');  // thực hiện cho đến khi "xuống dòng" ("kí tự tiếp theo" là enter) 
                                                          // Thêm tin nhắn nhận được vào "lsvMessage"
                lsvMessage.Items.Add(new ListViewItem(text+"\n"));              
            }
            // Đóng kết nối socket và giải phóng các tài nguyên liên quan
            listenerSocket.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Xử lý lỗi InvalidOperationException
            Control.CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.Start();
        }

        private void listViewCommand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
