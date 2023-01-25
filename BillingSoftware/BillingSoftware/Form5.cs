using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BillingSoftware
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
            listBox1.Items.Add(textBox3.Text);
            listBox1.Items.Add(textBox4.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee.SplitInput2(Employee.inputFilePath);
            string M =textBox2.Text ;
            string N =textBox3.Text ;
            string P =textBox4.Text ;
            Employee em = new Employee(0,M,N,P);
            Employee.AddEmployee(em);
            MessageBox.Show("Added sucessfully");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Employee.SplitInput2(Employee.inputFilePath);
        }
    }  
}
