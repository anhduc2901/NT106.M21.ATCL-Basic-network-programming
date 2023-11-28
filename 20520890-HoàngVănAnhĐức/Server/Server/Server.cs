using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Threading;


namespace Server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;

            Connect();
        }

        //gửi cho tất cả client
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Socket item in clientList)
            {
                Send(item); // 
            }
            AddMessage(txbMessage.Text);
            txbMessage.Clear();
        }


        IPEndPoint IP;
        Socket server;
        List<Socket> clientList;


        void Connect()
        {
            clientList = new List<Socket>();
            // IP : Địa chỉ của server
            IP = new IPEndPoint(IPAddress.Any, 9999);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            server.Bind(IP);
            Thread listen = new Thread(()=> 
            { 
                try
                {
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();
                        clientList.Add(client);


                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 9999);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
            });
            listen.IsBackground = true;
            listen.Start();
        }
        void Close()
        {
            server.Close();
        }
        void Send(Socket client)
        {
            if (client != null && txbMessage.Text != String.Empty)
            {
                client.Send(Serialize(txbMessage.Text));
            }
        }
        void Receive(object obj)  // Socket client;
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024*5000];
                    client.Receive(data);
                    string message = (string)Deserialize(data);
                    foreach(Socket item in clientList)
                    {
                        if( item != null && item!=client )
                        {
                            item.Send(Serialize(message));

                        }
                    }
                    AddMessage(message);
                }
            }
            catch
            {
                clientList.Remove(client);
                client.Close();
            }
        }

        //add message vào khung chat
        void AddMessage(string s)
        {
            listView1.Items.Add(new ListViewItem() { Text = s });
            txbMessage.Clear();
        }

        //  Phân mảnh
        byte[] Serialize(object obj)
        {

            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
            return stream.ToArray();

        }



        //Gom mảnh lại
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            return formatter.Deserialize(stream);

        }

        //đóng kết nối
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void Server_Load(object sender, EventArgs e)
        {

        }
    }
}
