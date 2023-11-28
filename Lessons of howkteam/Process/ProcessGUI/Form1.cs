using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void GetProcess()
        {
            Process[] processArr = Process.GetProcesses();
            foreach (Process item in processArr)
            {
                txblog.Text = item.ProcessName + "\n"+ txblog.Text;
            }

        }
        private void bntProcess_Click(object sender, EventArgs e)
        {
            GetProcess();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
           // Process.Start(Application.StartupPath + @"E:\Genshin impact");
        }

        private void btnHidden_Click(object sender, EventArgs e)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = Application.StartupPath + "\\ProcessGUI.exe";
            proc.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            proc.Start();
        }
    }
}
