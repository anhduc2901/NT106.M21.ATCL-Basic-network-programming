using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Linq;

namespace Bai4_real
{
    public partial class Form1 : Form
    {
        //hocsinh[] hs = new hocsinh[100];
        List<hocsinh> hs1 = new List<hocsinh>();
        public class hocsinh
        {
            public string mssv;
            public string hoten;
            public string dienthoai;
            public float diemtoan;
            public float diemvan;
            public float dtb;
        }
        public string s = null;
        public Form1()
        {
            InitializeComponent();
            
        }

        void Load()
        {
            FileStream fs = new FileStream(@"D:\LẬP TRÌNH MẠNG CĂN BẢN\NT106.M21.ATCL-Session2_GroupĐN\Bai4_real\input.txt"
            , FileMode.Create);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);

            string line = "";
            float dtb = 0;

            while (sr.ReadLine() != null)
            {
                hocsinh hs = new hocsinh();
                line = sr.ReadLine();
                hs.mssv = line;

                line = sr.ReadLine();
                hs.hoten = line;

                line = sr.ReadLine();
                hs.dienthoai = line;

                line = sr.ReadLine();
                hs.diemtoan = float.Parse(line);

                line = sr.ReadLine();
                hs.diemvan = float.Parse(line);

                hs1.Add(hs);
            }
            fs.Close();
            sr.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Load();
            StreamReader sr = new StreamReader(@"D:\LẬP TRÌNH MẠNG CĂN BẢN\NT106.M21.ATCL-Session2_GroupĐN\Bai4_real\input.txt");
            s = sr.ReadToEnd();
            sr.Close();


            //dùng streamwriter để ghi dữ liệu vào file output.txt
            StreamWriter writeFile = new StreamWriter(@"D:\LẬP TRÌNH MẠNG CĂN BẢN\NT106.M21.ATCL-Session2_GroupĐN\Bai4_real\input.txt");

            writeFile.WriteLine(s);          
            writeFile.WriteLine(txtMssv.Text);
            writeFile.WriteLine(txtHoTen.Text);
            writeFile.WriteLine(txtDienThoai.Text);
            writeFile.WriteLine(txtToan.Text);
            writeFile.WriteLine(txtVan.Text);
            /*
            float a = float.Parse(txtToan.Text);
            float b = float.Parse(txtVan.Text);
            txtDTB.Text = ((a + b) / 2).ToString();
            writeFile.WriteLine(txtDTB.Text);
            */

            writeFile.Flush();
            writeFile.Close();
            
            MessageBox.Show("Thành công");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"D:\LẬP TRÌNH MẠNG CĂN BẢN\NT106.M21.ATCL-Session2_GroupĐN\Bai4_real\input.txt");
            s = sr.ReadToEnd();
            string line = null;
            float dtb = 0;
            int i = 1;
            string s1 = null;
            while ((line = sr.ReadLine()) != null)
            {
                string mssv = " ";
                mssv = sr.ReadLine();

                string hoten = " ";
                hoten = sr.ReadLine();

                string dienthoai = null;
                dienthoai = sr.ReadLine();

                string diemtoan = null;
                diemtoan = sr.ReadLine();

                string diemvan = null;
                diemvan = sr.ReadLine();

                // sr.ReadLine();
                float a = float.Parse(diemtoan);
                float b = float.Parse(diemvan);



                dtb = (a + b) / 2;


                label6.Text += mssv.ToString();
                richTextBox1.Text = mssv.ToString();
                StreamReader sr2 = new StreamReader(@"D:\LẬP TRÌNH MẠNG CĂN BẢN\NT106.M21.ATCL-Session2_GroupĐN\Bai4_real\input.txt");

                richTextBox1.Text += dtb.ToString();



                StreamWriter writeFile = new StreamWriter(@"D:\LẬP TRÌNH MẠNG CĂN BẢN\NT106.M21.ATCL-Session2_GroupĐN\Bai4_real\output.txt");
                writeFile.WriteLine(s1);
                writeFile.WriteLine(mssv);
                writeFile.WriteLine(hoten);
                writeFile.WriteLine(dienthoai);
                writeFile.WriteLine(diemtoan);
                writeFile.WriteLine(diemvan);
                writeFile.WriteLine(dtb.ToString());
                writeFile.Flush();
                writeFile.Close();
                i++;

                StreamReader sr1 = new StreamReader(@"D:\LẬP TRÌNH MẠNG CĂN BẢN\NT106.M21.ATCL-Session2_GroupĐN\Bai4_real\output.txt");
                s1 = sr1.ReadToEnd();
                sr1.Close();


            }
            label6.Text += line;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            StreamReader sr = new StreamReader(@"D:\LẬP TRÌNH MẠNG CĂN BẢN\NT106.M21.ATCL-Session2_GroupĐN\Bai4_real\input.txt");
            s = sr.ReadToEnd();
            sr.Close();
            richTextBox1.Text += s;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            StreamReader sr = new StreamReader(@"D:\LẬP TRÌNH MẠNG CĂN BẢN\NT106.M21.ATCL-Session2_GroupĐN\Bai4_real\output.txt");
            s = sr.ReadToEnd();
            sr.Close();
            richTextBox1.Text += s;
        }
    }
}

