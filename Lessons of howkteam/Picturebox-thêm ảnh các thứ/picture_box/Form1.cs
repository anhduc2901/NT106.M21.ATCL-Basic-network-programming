using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picture_box
{
    public partial class Form1 : Form
    {
        string extention = ".jpg";
        public Form1()
        {
            InitializeComponent();
            LoadImageName();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(Application.StartupPath+ "\\Resources\\Trúc Nhạn.jpg");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void LoadImageName()
        {
            List<string> ListImage = new List<string>() { "klee_ava", "Trúc Nhạn", "zhongli_ava", "hatien 2", 
                "kazuha_chibi2","Hatien","ganyu_chibi","ayaka_chibi","hutao_chibi" };
            comboBox1.DataSource = ListImage;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if(cb.SelectedValue!=null)
            {
                Bitmap bm = new Bitmap(Application.StartupPath + "\\Resources\\" + cb.SelectedValue.ToString() + extention);
                pictureBox1.Image = bm;
            }
            
        }

       
    }
}
