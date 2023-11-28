using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Client : Form
    {        
        public Client()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            Connect();
        }
        IPEndPoint IP;
        Socket client;
        void Connect()
        {
            // IP là địa chỉ mà client connect đến
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            //                              CLIENT 
            // AddressFamily.InterNetwork : trả về họ của ip hiện hành cụ thể ở đây là Ipv4 
            // SocketType.Stream          : Kiểu kết nối Socket , ở đây dùng luồng stream để nhận dữ liệu
            // ProtocolType.IP            : kiểu kết nối 
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            //Bắt đầu kết nối
            //Dùng try catch để báo lỗi kết nối
            try
            {
                client.Connect(IP);
            }
            catch 
            {

                MessageBox.Show("Lỗi kết nối", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //tạo luồng lắng nghe server khi vừa kết nối tới
            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();

        }
        void Close()
        {
            client.Close();
        }
        void Receive()
        {
            try
            {
                while (true)
                {
                    //tạo mảng 1 byte để lưu dữ liệu
                    byte[] data = new byte[1024 * 5000];
                    // nhận data từ Socket và lưu vào buffer "data"
                    client.Receive(data);
                    //Gom mảnh data sang dạng string
                    string msg = (string)Deserialize(data);
                    AddMessage(msg);
               }
            }
            catch 
            {
                Close();
            }
          
        }       
        void AddMessage(string s)
        {
            lsvMessage.Items.Add(new ListViewItem() { Text = s });
            txbMessage.Text = "";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Send();
            
        }
        //Gửi dữ liệu
        void Send()
        {
            // txbMessgae khác rỗng ms gửi
            if(txbMessage.Text!=string.Empty)
            {
                client.Send(Serialize(txbName.Text + " : " + txbMessage.Text));
            }
        }
        object Deserialize(byte[] data)
        {
            //Khởi tạo stream để lưu trữ mảng byte
            MemoryStream stream = new MemoryStream(data);
            // Khởi tạo đổi tượng để chuyển đổi
            BinaryFormatter bf = new BinaryFormatter();
            //Chuyển đổi và return lại dữ liệu
            return bf.Deserialize(stream);
        }
        byte[] Serialize(object obj)
        {
            //Khởi tạo stream để lưu các byte phân mảnh
            MemoryStream stream = new MemoryStream();
            //Khởi tạo đổi tượng để phân mảnh
            BinaryFormatter bf = new BinaryFormatter();
            //Phân mảnh 1 object và lưu nó lại dưới 1 mảng byte và lưu vào "stream"
            bf.Serialize(stream, obj); 
            //Trả về kết quả là 1 mảng byte để chuẩn bị gửi đi
            return stream.ToArray();
        }

        private void Client_Load(object sender, EventArgs e)
        {

        }
    }
}
