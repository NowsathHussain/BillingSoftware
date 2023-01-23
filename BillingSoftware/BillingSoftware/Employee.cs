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
    }
    
  
}
