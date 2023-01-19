
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSoftware
{
    class Products
    {
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
