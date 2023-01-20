using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BillingSoftware
{
    class Store
    {
        static List<Store> m2 = new List<Store>();
        public static string inputFilePath = "C:\\MySampleInput\\New folder\\Store.txt";
        string _name;
        string _address;
        int _GSTNumber;
        string _PhoneNumber;
        string _EmailID;

        public Store(string name,string address,int GSTNumber,string PhoneNumber,string EmailID)
        {
            this._name = name;
            this._address = address;
            this._GSTNumber = GSTNumber;
            this._PhoneNumber = PhoneNumber;
            this._EmailID = EmailID;
        }
        public static void SplitStore(string inputFilePath)
        {
            string[] details = File.ReadAllLines(inputFilePath);
            foreach(string det in details)
            {
                string[] Detai = det.Split('|');
                Store p= new Store((Detai[0]),Detai[1],Convert.ToInt32(Detai[2]),Detai[3],Detai[4]);
                m2.Add(p);
            }
        }

    }
}
