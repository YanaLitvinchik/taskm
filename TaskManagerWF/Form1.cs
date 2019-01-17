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

namespace TaskManagerWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Process[] proc;
        public void GetAllProc()
        {
            proc = Process.GetProcesses();
            listBox1.Items.Clear();
            foreach (Process p in proc)
            {
                listBox1.Items.Add(p.ProcessName);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllProc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            proc[listBox1.SelectedIndex].Kill();
            proc[listBox1.SelectedIndex].
        }
    }
}
