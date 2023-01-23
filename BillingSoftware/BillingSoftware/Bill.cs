using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BillingSoftware
{
    public class Bill
    {
        public static string inputfilePath = "C:\\MySampleInput\\New folder\\Employee.txt";
        //public static Dictionary<int, Bill> Products = new Dictionary<int, Bill>();
       public int _billnumber;
        public int Billnumber
        {
            get { return _billnumber; }
            set { _billnumber = value; }
        }
        string _name;

        public string Name
        {
          get { return _name; }
          set { _name = value; }
        }
        string _category;
        int _unitPrice;

        public int UnitPrice
        {
            get { return _unitPrice; }
            set { _unitPrice = value; }
        }
        Taxprecent _taxcategory;
        category _status;

        public Bill(int billnumber,string name,string category,int unitprice,Taxprecent taxcategory,Status status)
        {
            this._billnumber = billnumber;
            this._name = name;
            this._unitPrice = unitprice;
            this._category = category;
            this._taxcategory = taxcategory;
            this._category = category;
            
        }

        //public static void LoadData(string inputfilePath)
        //{
        //    string[] products = File.ReadAllLines(inputfilePath);
        //    foreach (string Prod in products)
        //    {
        //        string[] myprod = Prod.Split('|');
        //        Bill p = new Bill(Convert.ToInt32(myprod[0]), myprod[1], myprod[2], Convert.ToInt32(myprod[3]), (Taxprecent)Enum.Parse(typeof(Taxprecent), myprod[4]), (Status)Enum.Parse(typeof(Status), myprod[5]));
        //        Products.Add(Convert.ToInt32(myprod[0]), p);
        //    }

        //}

    }
    public enum Taxprecent
    {
        low = 5,
        mid = 10,
        high = 15,
        Lux = 22,
    }
    public enum category
    {
        Active = 1,
        disconnected = 0,
    }

}
