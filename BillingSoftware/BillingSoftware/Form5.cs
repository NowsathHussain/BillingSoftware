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
            int temp = 0;
            Employee fg = new Employee();
            foreach(Employee l in Employee.m2)
            {
               temp= l.EmployeeID+1;
            }
            StreamWriter writter = new StreamWriter(Employee.inputFilePath, true);
            writter.WriteLine(temp+"|"+textBox2.Text+"|"+textBox3.Text+"|"+textBox4.Text);
            MessageBox.Show("Employee added successfully");
            writter.Close();
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
