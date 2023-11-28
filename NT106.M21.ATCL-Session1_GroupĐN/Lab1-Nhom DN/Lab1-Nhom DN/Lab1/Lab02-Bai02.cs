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
    public partial class Lab02_Bai02 : Form
    {
        public Lab02_Bai02()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2,num3;
            num1 = double.Parse(textBox1.Text.Trim());
            num2 = double.Parse(textBox2.Text.Trim());
            num3 = double.Parse(textBox3.Text.Trim());

            double max = num1;
            if(max<num2)
            {
                max = num2;
            }
             if ( max <num3)
            {
                max = num3;
            }
            textBox4.Text = max.ToString();

            double min = num1;
            if (min > num2)
            {
                min = num2;
            } 
            if (min > num3)
            {
                min = num3;
            }
            textBox5.Text = min.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void Lab02_Bai02_Load(object sender, EventArgs e)
        {

        }
    }
}
