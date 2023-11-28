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
using System.Collections.Generic;
using System.Globalization;

namespace TreeViewGUI
{
    public partial class Form1 : Form
    {
        string path = @"D:\";
        public Form1()
        {
            InitializeComponent();


            // LoadTreeView();


            if (Directory.Exists(path))
            {
                TreeNode root = new TreeNode() { Text = path };
                treeView.Nodes.Add(root);
                LoadExplorer(root);

            }
        }
       
        void LoadTreeView()
        {

            //set up
            treeView.CheckBoxes = true;
            
            //root1
            TreeNode root1 = new TreeNode();
            root1.Text = "Root nè";
            root1.ImageIndex = 0;
            

            // add node1 vào tree1
            TreeNode node1 = new TreeNode() { Text = "Con của root 1 nè " };
            root1.Nodes.Add(node1);
            node1.ImageIndex = 1;


            //root2
            TreeNode root2 = new TreeNode();
            root2.Text = "Root 2 nè";
            root2.ImageIndex = 2;





            treeView.Nodes.Add(root1);
            treeView.Nodes.Add(root2);


        }

        void LoadExplorer(TreeNode root)
        {
            if(root==null)
            {
                return;
            }

            try
            {


                var folderList = new DirectoryInfo(root.Text).GetDirectories();

                if (folderList.Count() == 0)
                {
                    return;
                }

                foreach (DirectoryInfo item in folderList)
                {
                    if (Directory.Exists(item.FullName))
                    {
                        TreeNode node = new TreeNode() { Text = item.FullName };
                        root.Nodes.Add(node);
                        LoadExplorer(node);
                    }

                }
            }
            catch
            {
                return;
            }
        }

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
        }
    }
}
