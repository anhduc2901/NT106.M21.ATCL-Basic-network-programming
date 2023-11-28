using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            
            FileStream fs = new FileStream(@"C:\Users\T\Desktop\NT106.M21.ATCL-Session2_GroupĐN\Bai1\input.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();
            //richTextBox1.Text = content;
            txtBox1.Text = content; 
            fs.Close();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();            
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
            StreamWriter sw = new StreamWriter(fs);

            string content = txtBox1.Text.ToUpper();

            sw.WriteLine(content);
            sw.Close();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
