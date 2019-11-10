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
    public partial class Form2 : Form
    {
        BookManager bm = new BookManager();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.Controls.Add(bm);
            bm.Dock = System.Windows.Forms.DockStyle.Fill;
        }
    }
}
