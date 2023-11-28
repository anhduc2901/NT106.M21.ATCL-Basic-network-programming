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
    public partial class Lab04_Bai04 : Form
    {
        public Lab04_Bai04()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sotienchuyendoi;
            if (comboBox1.SelectedItem.ToString()=="USD")
            {
                sotienchuyendoi = double.Parse(textBox1.Text.Trim()) * 22272;
                textBox2.Text = sotienchuyendoi.ToString();
                textBox3.Text = "22,272";
            }
            else if(comboBox1.SelectedItem.ToString() == "EUR")
            {
                sotienchuyendoi = double.Parse(textBox1.Text.Trim()) * 28132;
                textBox2.Text = sotienchuyendoi.ToString();
                textBox3.Text = "28,132";
                
            }
            else if(comboBox1.SelectedItem.ToString() == "GBP")
            {
                sotienchuyendoi = double.Parse(textBox1.Text.Trim()) * 31538;
                textBox2.Text = sotienchuyendoi.ToString();
                textBox3.Text = "31,538";
            }
            else if(comboBox1.SelectedItem.ToString() == "SGD")
            {
                sotienchuyendoi = double.Parse(textBox1.Text.Trim()) * 17286;
                textBox2.Text = sotienchuyendoi.ToString();
                textBox3.Text = "17,286";
            }
            else if(comboBox1.SelectedItem.ToString() == "JPY")
            {
                sotienchuyendoi = double.Parse(textBox1.Text.Trim()) * 214;
                textBox2.Text = sotienchuyendoi.ToString();
                textBox3.Text = "214";
            }
            
        }

        private void Lab04_Bai04_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
