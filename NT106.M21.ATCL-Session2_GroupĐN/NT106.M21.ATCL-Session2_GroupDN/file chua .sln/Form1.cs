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

namespace NT106.M21.ATCL_Session1_GroupĐN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate);
            BinaryWriter bw = new BinaryWriter(fs);

            /*int[] myArr = new int[100];           
            for (int i = 0; i < 100; i++)
            {
                myArr[i] = i;
                bw.Write(myArr[i]);
            }*/
            string[] myStrArr = { " This place is nice but not nice enough to die in  ",
                " Let's win and get out of here " };
            for (int i = 0; i < myStrArr.Length; i++)
            {
                
                bw.Write(myStrArr[i]);
            }
            bw.Close();
        }
    }
}
