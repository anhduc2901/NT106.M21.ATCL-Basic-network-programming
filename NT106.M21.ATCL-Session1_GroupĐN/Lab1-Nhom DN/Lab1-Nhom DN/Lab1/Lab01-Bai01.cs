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
    public partial class Lab01_Bai01 : Form
    {
        public Lab01_Bai01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int num1, num2;
                long sum = 0;
                num1 = Int32.Parse(textBox1.Text.Trim());
                num2 = Int32.Parse(textBox2.Text.Trim());
                sum = num1 + num2;
                textBox3.Text = sum.ToString();
            }
            catch(Exception f)
            {

                // textBox3.Text = "Vui lòng nhập số nguyên !";
                MessageBox.Show(f.Message);
            }

        }

        private void Lab01_Bai01_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
