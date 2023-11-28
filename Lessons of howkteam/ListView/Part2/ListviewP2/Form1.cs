using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListviewP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadListView();
            
        }

        ImageList imgListSmall;
        ImageList imgListLarge;

        void LoadImageList()
        {
            imgListLarge = new ImageList() { ImageSize = new Size(68,68) };
            imgListLarge.Images.Add(new Bitmap(Application.StartupPath+ "\\Images\\Trúc Nhạn.jpg"));
            imgListLarge.Images.Add(new Bitmap(Application.StartupPath + "\\Images\\Trúc Linh.jpg"));
            imgListLarge.Images.Add(new Bitmap(Application.StartupPath + "\\Images\\hatien 2.PNG"));

            imgListSmall = new ImageList() { ImageSize = new Size(16, 16) };
            imgListSmall.Images.Add(new Bitmap(Application.StartupPath + "\\Images\\Trúc Nhạn.jpg"));
            imgListSmall.Images.Add(new Bitmap(Application.StartupPath + "\\Images\\Trúc Linh.jpg"));
            imgListSmall.Images.Add(new Bitmap(Application.StartupPath + "\\Images\\hatien 2.PNG"));

        }
        void LoadListView()
        {
            LoadImageList();
            //set up
            lsvShow.FullRowSelect = true;
            lsvShow.GridLines = true;


            // large vs small image list
            lsvShow.SmallImageList = imgListSmall;
            lsvShow.LargeImageList = imgListLarge;

            

            // add collumns
            lsvShow.Columns.Add("Collumn 1");
            lsvShow.Columns.Add("Collumn 2");
            lsvShow.Columns.Add("Collumn 3");

            // item 1 la List dau tien 
            ListViewItem item1 = new ListViewItem();
            item1.Text = "Item 1";
            //image index
            item1.ImageIndex = 0;
            lsvShow.Items.Add(item1);
            //add subitem
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub item 1" });
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub item 2" });


            ListViewItem item2 = new ListViewItem();
            item2.Text = "Item 2";
            item2.ImageIndex = 1;
            lsvShow.Items.Add(item2);
            item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub item 1" });
            item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub item 2" });




            ListViewItem item3 = new ListViewItem();
            item3.Text = "Item 3";
            item3.ImageIndex = 2;
            lsvShow.Items.Add(item3);
            item3.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub item 1" });
            item3.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub item 2" });

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lsvShow.View = View.LargeIcon;
            lsvShow.CheckBoxes = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lsvShow.View = View.SmallIcon;
            lsvShow.CheckBoxes =false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lsvShow.View = View.Details;
            lsvShow.CheckBoxes = true;
        }

        private void lsvShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lsv = sender as ListView;
            if(lsv.SelectedItems.Count>0)
            {
                foreach (ListViewItem item in lsv.SelectedItems)
                {
                    //ListViewItem item = lsv.SelectedItems[0];
                    item.Text = " iu Anh Đức vcl =]] ";
                    MessageBox.Show(item.Text);
                }

                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
