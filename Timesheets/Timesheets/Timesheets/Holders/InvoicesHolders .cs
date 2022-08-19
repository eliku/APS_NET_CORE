using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timesheets.Model;

namespace Timesheets.Holders
{
    public class InvoicesHolders
    {
        private clInvoices _invoice { get; set; }


        public bool Create(clInvoices newInvoices)
        {
            _invoice = newInvoices;
            return true;
        }

        public void DeleteAll()
        {
            _invoice.Number = 0;
        }

        public bool Update(clInvoices newInvoices)
        {
            _invoice = newInvoices;
            return true;
        }
    }
}
