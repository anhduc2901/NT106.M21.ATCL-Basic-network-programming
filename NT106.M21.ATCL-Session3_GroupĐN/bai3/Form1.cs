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

namespace bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lsvMessage.Items.Add("Server running on 127.0.0.1: 8080");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Xử lý lỗi InvalidOperationException
            Control.CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.Start();
        }
        void StartUnsafeThread()
        {   
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

            // tạo IPEndPoint để cho client gửi dữ liệu đến
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);

            // Gán socket lắng nghe tới địa chỉ IP của máy và port 8080
            listenerSocket.Bind(ipepServer);

            // bắt đầu lắng nghe.Socket.Listen(int backlog)
            // với backlog: là độ dài tối đa của hàng đợi các kết nối đang chờ xử lý
            listenerSocket.Listen(-1);

            //Đồng ý kết nối - create connection
            clientSocket = listenerSocket.Accept();

            // add string vào listView1
            AddMessage("New client connected" +'\n');

            //Nhận message từ client đến khi hết kết nối
            while(true)
            {
                // Tạo mảng byte 
                byte[] data = new byte[1024];
                //Lưu dữ liệu vào mảng (nhận từ liệu từ client)
                clientSocket.Receive(data);
                // chuyển sang dạng string
                string str = Encoding.ASCII.GetString(data);
                // add string vào listView1
                AddMessage(str);
            }
        }

        void AddMessage(string s)
        {
            lsvMessage.Items.Add(new ListViewItem() { Text = s });           
        }


        private void listViewCommand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
