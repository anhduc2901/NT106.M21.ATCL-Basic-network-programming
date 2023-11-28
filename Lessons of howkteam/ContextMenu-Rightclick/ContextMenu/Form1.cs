using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContextMenu
{
    public partial class Form1 : Form
    {
        ContextMenuStrip contextMenu;
        public Form1()
        {
            InitializeComponent();
            contextMenu = new ContextMenuStrip(); //cái nhấp chuột phải là hiện ra 
            contextMenu.AutoSize = true;
            var item = new ToolStripComboBox() {Text="Clicked me = hurting me :(( !",AutoSize=true };
            item.Click += Item_Click;


            contextMenu.Items.Add(item);
            
        }

        private void Item_Click(object sender, EventArgs e)
        {
            MessageBox.Show((sender as ToolStripItem).Text);
        }

      

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            contextMenu.Show(this, this.PointToClient(MousePosition));

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
