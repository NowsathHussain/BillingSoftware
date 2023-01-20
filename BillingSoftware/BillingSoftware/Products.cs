
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BillingSoftware
{
    class Products
    {
        static List<Products> m3 = new List<Products>();
        string _productID;
        string _name;
        string _category;
        int _unitPrice;
        public int UnitPrice
        {
            get { return _unitPrice; }
            set { _unitPrice = value; }
        }
        Taxcategory _taxcategory;
        Status _status;
        public static string inputFilePath = "C:\\MySampleInput\\New folder\\Product.txt";
        public Products(string productID,string name, string category,int unitPrice,Taxcategory taxcategory,Status status)
        {
            this._productID = productID;
            this._name = name;
            this._category = category;
            this._unitPrice = unitPrice;
            this._taxcategory = taxcategory;
            this._status = status;
        }
        public static void SplitStore(string inputFilePath)
        {
            string[] details = File.ReadAllLines(inputFilePath);
            foreach (string det in details)
            {
                string[] Detai = det.Split('|');
                Products p = new Products((Detai[0]), Detai[1], Detai[2], Convert.ToInt32(Detai[3]), (Taxcategory)Enum.Parse(typeof(Taxcategory), Detai[4]), (Status)Enum.Parse(typeof(Status), Detai[5]));
                m3.Add(p);
            }
        }


    }
    public enum Status
    {
        active=1,
        Disconnected=0,
    }
    public enum Taxcategory
    {
        low=5,
        mid=10,
        high=15,
        lux=20,
    }
}
