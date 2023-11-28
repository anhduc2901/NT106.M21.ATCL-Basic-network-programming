using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Get();
        }
        void Get()
        {
            //Thay đường dẫn ms chạy đc

            DirectoryInfo DI = new DirectoryInfo(@"E:\GENSHIN MEMES");
            FileInfo[] File_Arr = DI.GetFiles();
            foreach (var item in File_Arr)
            {
                //tên file
                ListViewItem newItem = new ListViewItem() { Text = item.Name };
                //kích thước
                newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.Length.ToString() });
                // phần mở rộng
                newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.Extension.ToString() });
                //Ngày tạo
                newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.CreationTime.ToString() });
                listView1.Items.Add(newItem);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        { }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {}
    }
}
