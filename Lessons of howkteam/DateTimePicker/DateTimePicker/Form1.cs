using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // pop up - false
          //  dateTimePicker1.ShowUpDown = false;
            // chỉnh lên xuống - true
            dateTimePicker1.ShowUpDown = true;
            DateTime time = DateTime.Now;
            dateTimePicker1.Value = time;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
