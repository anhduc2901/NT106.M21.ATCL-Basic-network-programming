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
namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            Connect();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Send();
            AddMessage(txbMessage.Text);
        }


        IPEndPoint IP;
        Socket client;


        void Connect()
        {
            // IP : Địa chỉ của server
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            client =new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.IP);
            try
            {
                client.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Không thể kết nối server !","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }
        void Close()
        {
            client.Close();
        }
        void Send()
        {
            if (txbMessage.Text != String.Empty )
            {
                client.Send(Serialize(txbMessage.Text));
            }
        }
        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024*5000];
                    client.Receive(data);
                    string message = (string)Deserialize(data);
                    AddMessage(message);
                }
            }
            catch
            {
                Close();
            }
        }

        //add message vào khung chat
        void AddMessage(string s)
        {
            lsvMessage.Items.Add(new ListViewItem() { Text = s });
            txbMessage.Clear();
        }

        //  Phân mảnh
        byte[] Serialize(object obj)
        {
            
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            // phân mảnh
            formatter.Serialize(stream,obj);
            return stream.ToArray();
            
        }



        //Gom mảnh lại
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            return formatter.Deserialize(stream);
            
        }
        
    }
}
