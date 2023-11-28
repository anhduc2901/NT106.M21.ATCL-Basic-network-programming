using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBarGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!timer1.Enabled)
            {
                timer1.Start();
                button1.Text = "Stop";
            }
            else
            {
                timer1.Stop();
                button1.Text = "Start";
            }
            // có thể dùng timer1.enabled = !timer1.Enabled ;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // marquee k chạy PerformStep mà nó chạy PerformLayout
            progressBar1.PerformStep();
        }
    }
}
