using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timesheets.Model
{
    public class clInvoices
    {
        private int _numder;

        public int Number
        {
            get
            {
                return _numder;
            }
            set
            {
                _numder = value;
            }
        }
    }
}
