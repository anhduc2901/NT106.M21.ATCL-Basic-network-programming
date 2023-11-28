using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            
            FileStream fs = new FileStream(@"C:\Users\T\Desktop\NT106.M21.ATCL-Session2_GroupĐN\Bai3\input.txt"
                                            , FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            
                string s = sr.ReadToEnd();

                richTextBox1.Text = s;

                fs.Close();
            
            

        }
        private void button3_Click(object sender, EventArgs e)
        {
            
            FileStream fs2 = new FileStream(@"C:\Users\T\Desktop\NT106.M21.ATCL-Session2_GroupĐN\Bai3\input.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs2);

            string s1 = " ";
            string s2 = " ";
            string s3 = " ";
            string s4 = " ";
            try
            {

                s1 = sr.ReadLine();
                string[] s11;
                s11 = s1.Split('+');
                float tong = float.Parse(s11[0]) + float.Parse(s11[1]);

                s2 = sr.ReadLine();
                string[] s22;
                s22 = s2.Split('-');
                float hieu = float.Parse(s22[0]) - float.Parse(s22[1]);

                s3 = sr.ReadLine();
                string[] s33;
                s33 = s3.Split('*');
                float tich = float.Parse(s33[0]) * float.Parse(s33[1]);

                s4 = sr.ReadLine();
                string[] s44;
                s44 = s4.Split('/');
                float thuong = float.Parse(s44[0]) / float.Parse(s44[1]);


                //Dùng streamWritter để ghi file
                FileStream fs = new FileStream(@"C:\Users\T\Desktop\NT106.M21.ATCL-Session2_GroupĐN\Bai3\output.txt"
                , FileMode.OpenOrCreate);
                StreamWriter writeFile = new StreamWriter(fs, Encoding.UTF8);


                //Ghi từng dòng vào file output.txt
                writeFile.WriteLine(s1 + "=" + tong.ToString());
                writeFile.WriteLine(s2 + "=" + hieu.ToString());
                writeFile.WriteLine(s3 + "=" + tich.ToString());
                writeFile.WriteLine(s4 + "=" + thuong.ToString());

                writeFile.Close();

                string ss1 = s1 + "=" + tong.ToString();
                string ss2 = s2 + "=" + hieu.ToString();
                string ss3 = s3 + "=" + tich.ToString();
                string ss4 = s4 + "=" + thuong.ToString();

                richTextBox1.Text = ss1 + "\n" + ss2 + "\n" + ss3 + "\n" + ss4;
                
            }
            catch(Exception f)
            {
                MessageBox.Show(f.ToString());
            }
            
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
