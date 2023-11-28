using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\OS\Desktop\input\test.txt"
                                            , FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();
            textBox1.Text = content;

            //tên file nè
            var path = Path.GetFileName(@"C:\Users\T\Desktop\NT106.M21.ATCL-Session2_GroupĐN\bai2\TextFile1.txt");
            textBox2.Text = path.ToString();

            //Lấy đường dẫn tới file
            textBox3.Text = fs.Name.ToString();

           
            // - đếm số dòng trong file
            content = content.Replace("\r\n", "\r");
            int lineCount = textBox1.Lines.Count();
            content = content.Replace('\r', ' ');
            textBox4.Text = lineCount.ToString();

            


            // Đếm số từ 
            string[] source = content.Split(new char[] { '.', '?', ' ', ';', ':', ',' },
                StringSplitOptions.RemoveEmptyEntries);
            int wordCount = source.Count();
            textBox5.Text = wordCount.ToString();

            // Đếm số kí tự
            int charCount = content.Length;
            textBox6.Text = charCount.ToString();

            
            fs.Close();


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
