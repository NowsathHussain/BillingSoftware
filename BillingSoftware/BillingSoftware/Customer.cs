using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSoftware
{
    class Customer
    {
        int _ID;
        string _name;
        string _mobno;

        public string Mobno
        {
            get { return _mobno; }
            set { _mobno = value; }
        }

    }
}
