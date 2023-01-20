using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BillingSoftware
{
    class Employee
    {
        public static string inputFilePath = "C:\\MySampleInput\\New folder\\Employee.txt";
        string _EmployeeID;
        string _name;
        string _Password;
        string _category;

        public Employee(string EmployeeID,string name, string Password,string category)
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
                Employee p = new Employee((myprod[0]), myprod[1], myprod[2],myprod[3]);
                
            }

        }
        
    }
    
  
}
