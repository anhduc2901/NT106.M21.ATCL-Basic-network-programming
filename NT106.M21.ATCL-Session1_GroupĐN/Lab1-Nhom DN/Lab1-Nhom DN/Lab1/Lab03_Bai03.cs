using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_20520890_HoangVanDuc
{
    public partial class Lab03_Bai03 : Form
    {
        public Lab03_Bai03()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int num1 = Int32.Parse(textBox1.Text.Trim());
            string Getnum;
            switch (num1)
            {
                case 0:
                    textBox2.Text = "Không"; break;
                case 1:
                    textBox2.Text = "Một"; break;
                case 2:
                    textBox2.Text = "Hai"; break;
                case 3:
                    textBox2.Text = "Ba"; break;
                case 4:
                    textBox2.Text = "Bốn"; break;
                case 5:
                    textBox2.Text = "Năm"; break;
                case 6:
                    textBox2.Text = "Sáu"; break;
                case 7:
                    textBox2.Text = "Bảy"; break;
                case 8:
                    textBox2.Text = "Tám"; break;
                case 9:
                    textBox2.Text = "Chín"; break;
                default:
                    textBox2.Text = "1 -> 9 thôi "; break;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
