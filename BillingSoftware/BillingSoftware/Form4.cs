using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSoftware
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 fg = new Form6();
            fg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 fi = new Form5();
            fi.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 fm = new Form7();
            fm.Show();
        }
    }
}
