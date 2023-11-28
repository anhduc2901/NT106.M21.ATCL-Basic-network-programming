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
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thr = new Thread(count1);
            thr.IsBackground = true;
            thr.Start();
        }
        void count1()
        {
            for (int i = 0; i <= Convert.ToInt32(textBox1.Text); i++)
            {
                label6.Text = i.ToString();
            }
        }
        void count2()
        {
            for (int i = 0; i <= Convert.ToInt32(textBox1.Text); i=i+2)
            {
                label7.Text = i.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread thr = new Thread(count2);
            thr.IsBackground = true;
            thr.Start();
        }
    }
}
