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

namespace cbbox
{
    public partial class Form1 : Form
    {
        List<Food> ListFood;
        List<A_class> ListClass;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ListFood = new List<Food>()
            {
                new Food()  { name=  "Lẩu chay", price="3 tỷ"}  ,
                new Food()  { name = "Hotpot spicey", price = "2 tỷ" }
            };

            ListFood.Add((new Food()
            {
                name = "Lẩu thịt",
                price = "3 tỷ"
            }
                ));

            comboBox1.DataSource = ListFood;  
            comboBox1.DisplayMember = "name";

            
            AddBinding();

        }

        public class Food
        {
            public string name { get; set ; }
            public string price { get; set; }
        }

        void AddBinding()
        {
            textBox1.DataBindings.Add("Text", comboBox1.DataSource, "price");
        }
        
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if(cb.SelectedValue!=null)
            {
                Food f = cb.SelectedValue as Food;
                textBox1.Text = f.price.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListClass = new List<A_class>();

            ListClass.Add(new A_class()
            {
                TenLop = "ATCL",
                List_hs = new List<string>() {"Hà Tiên ","Hồng Loan" }
            }
                ) ;

            ListClass.Add(new A_class()
            {
                TenLop = "MMT",
                List_hs = new List<string>() { "Trúc Nhạn"}
            }
                );


            comboBox2.DataSource = ListClass;
            comboBox2.DisplayMember = "TenLop";

        }

        public class A_class
        {
            public string TenLop { get; set; }
            public List<string> List_hs { get; set; }

        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if(cb.SelectedValue!=null)
            {
                A_class cl = cb.SelectedValue as A_class;
                //comboBox3.DataSource = l_cl.List_hs.ToString();
                comboBox3.DataSource = cl.List_hs;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = "";
            StreamReader sr = new StreamReader(@"D:\LẬP TRÌNH MẠNG CĂN BẢN\Lessons of howkteam\ComboBox- 1 list lựa chọn\cbbox\TextFile1.txt"
            , Encoding.UTF8);
            s = sr.ReadToEnd();
            sr.Close();
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"D:\LẬP TRÌNH MẠNG CĂN BẢN\Lessons of howkteam\ComboBox- 1 list lựa chọn\cbbox\TextFile1.txt"
            , Encoding.UTF8);
            string s = sr.ReadLine();
            textBox2.Text = s;
        }
    }
}
