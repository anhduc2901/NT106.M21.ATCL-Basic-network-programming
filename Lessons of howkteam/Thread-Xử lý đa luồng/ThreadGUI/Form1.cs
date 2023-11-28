using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadGUI
{
    public partial class Form1 : Form
    {
        int speed = 100;
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls=false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                //ThreadStart ts = new ThreadStart(Demo);
            Thread thr = new Thread(Demo);
            thr.IsBackground = true; 
            thr.Start();
            
        }
        
        void Demo()
        {
            for (int i = 0; i < Convert.ToInt32(textBox1.Text); i++)
            {
                label1.Text = i.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nhấn ít thôi !");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread thr = new Thread(MovePicture);
            thr.IsBackground = true;
            thr.Start();
            
        }

        void MovePicture()
        {
            while (true)
            {
                if(checkBox1.Checked)
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X - 1, pictureBox1.Location.Y);

                }
                else
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X + 1, pictureBox1.Location.Y);

                }
                Thread.Sleep(speed);
                
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox2.Text, out speed);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
