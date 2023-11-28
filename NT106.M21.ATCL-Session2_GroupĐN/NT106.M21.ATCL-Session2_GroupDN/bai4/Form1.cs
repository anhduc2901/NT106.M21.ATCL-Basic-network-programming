using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
namespace bai4
{
    public partial class Form1 : Form
    {
        List<Student> ListStudent = new List<Student>();
        string line = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {

            if (KiemTraNhap() == true)
            {
               
                //Thông tin sinh viên nhập vào
                Student a = new Student();
                a.DiemToan = float.Parse(txtToan.Text.Trim());
                a.DiemVan = float.Parse(txtVan.Text.Trim());
                a.mssv = txtMssv.Text;
                a.Hoten = txtHoTen.Text;
                a.DienThoai = txtDienThoai.Text;

                ListStudent.Add(a);
               
            }
           
        }
        void Serialize()
        {
            for (int j = 0; j < ListStudent.Count(); j++)
            {
                //Serialize
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.OpenWrite(@"C:\Users\T\Desktop\NT106.M21.ATCL-Session2_GroupĐN\bai4\input.txt"
                                       ); // File.Create 
                bf.Serialize(fs, ListStudent[j]);
                fs.Close();
            }
            
        }
        private void btnDeserialize_Click_1(object sender, EventArgs e)
        {
                Serialize();

                //Deserialize
                BinaryFormatter bf2 = new BinaryFormatter();
                FileStream fs2 = File.OpenRead(@"C:\Users\T\Desktop\NT106.M21.ATCL-Session2_GroupĐN\bai4\input.txt");
                Student student = (Student)bf2.Deserialize(fs2);
                fs2.Close();

                //  lưu vào output.txt 


                FileStream fs3 = new FileStream(@"C:\Users\T\Desktop\NT106.M21.ATCL-Session2_GroupĐN\bai4\output.txt"
                                                , FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(fs3);


            // điểm trung bình
                float DTB = (Convert.ToSingle(student.DiemToan) + Convert.ToSingle(student.DiemVan)) / 2;
                txtDTB.Text = DTB.ToString();
                student.DTB = DTB;

                //lưu vào output.txt
                string content2 = student.mssv + "\n" + student.Hoten + "\n" + student.DienThoai + "\n"
                    + student.DiemToan.ToString() + "\n"
                    + student.DiemVan.ToString() + "\n" + (student.DTB).ToString() + "\n";



                sw.WriteLine(content2);
                sw.Close();
            
                

            //Xuất ra màn hình

            StreamReader sr = new StreamReader(@"C:\Users\T\Desktop\NT106.M21.ATCL-Session2_GroupĐN\bai4\output.txt");
            string s = sr.ReadToEnd();
            txtManHinh.Text += s;
            sr.Close();
            
        }
        //
        private void btnDeserialize_Click(object sender, EventArgs e)
        {

        }

        bool KiemTraNhap()
        {
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Hãy nhập họ tên", "Thông báo");
                txtHoTen.Focus();
                return false;
            }

            if (txtMssv.Text == "")
            {
                MessageBox.Show("Hãy nhập mssv", "Thông báo");
                txtMssv.Focus();
                return false;
            }

            if (txtDienThoai.Text == "")
            {
                MessageBox.Show("Hãy nhập số điện thoại", "Thông báo");
                txtDienThoai.Focus();
                return false;
            }
            if (check())
            {
                if (txtToan.Text == "")
                {
                    MessageBox.Show("Hãy nhập điểm toán", "Thông báo");
                    txtToan.Focus();
                    return false;
                }

                if (txtVan.Text == "")
                {
                    MessageBox.Show("Hãy nhập điểm văn", "Thông báo");
                    txtVan.Focus();
                    return false;
                }
            }
           

            return true;
        }

        [Serializable()]
        public class Student
        {
            public string mssv;
            public string Hoten;
            public string DienThoai;
            public float DiemToan;
            public float DiemVan;
            public float DTB;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtManHinh_TextChanged(object sender, EventArgs e)
        {

        }
        public bool check()
        {
            bool value = false;
            if (float.Parse(txtToan.Text) > 10 || float.Parse(txtVan.Text) > 10)
            {
                value = false;
                MessageBox.Show("Vui lòng nhập lại điểm", "Thông báo");
            }
            else MessageBox.Show("Đã nhập và serialized .Hãy nhấn button dưới để deserialize và xuất");
            return value;
        }
    }
}
