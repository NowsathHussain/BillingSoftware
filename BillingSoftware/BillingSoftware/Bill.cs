using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSoftware
{
    class Bill
    {
        int _billnumber;

        public int Billnumber
        {
            get { return _billnumber; }
            set { _billnumber = value; }
        }
        string _date;

        public string Date
        {
            get { return _date; }
            set { _date = value; }
        }
        int _CustomerID;

        public int CustomerID
        {
            get { return _CustomerID; }
            set { _CustomerID = value; }
        }
        int _employeeID;

        public int EmployeeID
        {
            get { return _employeeID; }
            set { _employeeID = value; }
        }
        string _StoreDetails;
        int _gSTNumber;

        public int GSTNumber
        {
            get { return _gSTNumber; }
            set { _gSTNumber = value; }
        }
    }
}
