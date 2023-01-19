
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

    }
}
