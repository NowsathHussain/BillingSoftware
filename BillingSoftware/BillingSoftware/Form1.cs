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
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Employee.SplitInput(Employee.inputFilePath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            int Username =Convert.ToInt32(textBox1.Text);
            string password = textBox2.Text;
            if(Employee.Prodicts.ContainsKey(Username))
            {
                em = Employee.Prodicts[Username];
            }
            if(Username==em.EmployeeID)
            {
                if(password==em.Password)
                {
                     Form2 fg = new Form2();
                     fg.Show();
                }        
            }
            else
            {
                MessageBox.Show("Invalid username");
            }
            
            
        }

    }
    
}
