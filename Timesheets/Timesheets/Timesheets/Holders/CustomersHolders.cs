using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timesheets.Model;

namespace Timesheets.Holders
{
    public class CustomersHolders
    {
        private List<clCustomers> _listCustomers { get; set; }

        public CustomersHolders()
        {
            List<clCustomers> _listContracts = new List<clCustomers>();
        }

        public bool Create(clCustomers newCustomers)
        {
            _listCustomers.Add(newCustomers);
            return true;
        }

        public void DeleteAll()
        {
            _listCustomers.Clear();
        }

        public bool DeleteById(int id)
        {
            var customers = GetById(id)!;
            if (customers != null)
            {
                _listCustomers.Remove(customers);
                return true;
            }
            return false;
        }

        public IEnumerable<clCustomers> GetAll() => _listCustomers;

        public clCustomers GetById(int id) => _listCustomers.Find(c => c.Id == id);

        public bool Update(clCustomers newCustomers)
        {
            var t = _listCustomers.Find(x => x.Id == newCustomers.Id);
            if (t != null)
            {
                _listCustomers[_listCustomers.IndexOf(t)] = newCustomers;
                return true;
            }
            return false;
        }
    }
}
