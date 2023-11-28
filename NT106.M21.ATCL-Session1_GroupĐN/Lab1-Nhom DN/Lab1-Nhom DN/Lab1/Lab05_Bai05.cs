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
    public partial class Lab05_Bai05 : Form
    {
        DataTable dt = new DataTable();
        public Lab05_Bai05()
        {
            InitializeComponent();
        }

        private void Lab05_Bai05_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            long gtb = 1, s1 = 0, s2 = 0;
            double s3 = 0, gta = 1;
            a = Int32.Parse(textBox1.Text.Trim());
            b = Int32.Parse(textBox2.Text.Trim());

            //giai thua
            for (int i = 1; i <= a; i++)
            {
                gta *= i;
            }
            textBox3.Text = gta.ToString();

            for (int i = 1; i <= b; i++)
            {
                gtb *= i;
            }
            textBox4.Text = gtb.ToString();

            //S1
            for (int i = 1; i <= a; i++)
            {
                s1 += i;
            }
            textBox5.Text = s1.ToString();

            //S2
            for (int i = 1; i <= b; i++)
            {
                s2 += i;
            }
            textBox6.Text = s2.ToString();

            //S3
            for (int i = 1; i <= b; i++)
            {

                s3 += Math.Pow(a, i);
            }
            textBox7.Text = s3.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
