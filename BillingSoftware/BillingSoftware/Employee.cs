using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BillingSoftware
{
    public class Employee
    {   
        public static string inputFilePath = "C:\\MySampleInput\\New folder\\Employee.txt";
        public static Dictionary<int,Employee> Prodicts = new Dictionary<int, Employee>();
        public static List<Employee> m2 = new List<Employee>();
        int _EmployeeID;
        public int EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }
        string _name;
        string _Password;
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        string _category;
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }
        public Employee()
        {

        }
        public Employee(int EmployeeID,string name, string Password,string category)
        {
            this._EmployeeID = EmployeeID;
            this._name = name;
            this._Password = Password;
            this._category = category;
        }
        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3}", this._category,this._name,this._Password,this._category);
        }      
        public static void SplitInput(string inputFilePath)
        {
            string[] Employee = File.ReadAllLines(inputFilePath);
            foreach(string Prod in Employee)
            {
                string[] myprod =Prod.Split('|');
                Employee p = new Employee(Convert.ToInt32(myprod[0]), myprod[1], myprod[2],myprod[3]);
                Prodicts.Add(Convert.ToInt32(myprod[0]), p);
            }
        }
        public static void SplitInput2(string inputFilePath)
        {
            string[] Employee = File.ReadAllLines(inputFilePath);
            foreach (string Prod in Employee)
            {
                string[] myprod = Prod.Split('|');
                Employee p = new Employee(Convert.ToInt32(myprod[0]), myprod[1], myprod[2], myprod[3]);
                m2.Add(p);
            }
        }
        public static void AddEmployee(Employee es)
        {
            int temp = 0;
            foreach (Employee l in m2)
            {
                temp = l._EmployeeID;
            }
            StreamWriter writter = new StreamWriter(inputFilePath,append:true);
            writter.WriteLine(temp+1+"|"+es._name+"|"+es._Password+"|"+es._category);
            //MessageBox.Show("Employee added successfully");
            writter.Close();
        }
    }
    
  
}
