using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capstone_Book_Main;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        UserControl1 ver_dll = new UserControl1();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Controls.Add(ver_dll);
            ver_dll.Dock = System.Windows.Forms.DockStyle.Fill;
        }

    }
}
