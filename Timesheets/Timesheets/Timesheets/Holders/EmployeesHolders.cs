using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timesheets.Model;

namespace Timesheets.Holders
{
    public class EmployeesHolders
    {
        private List<clEmployees> _listEmployees { get; set; }

        public EmployeesHolders()
        {
            List<clEmployees> _listEmployees = new List<clEmployees>();
        }

        public bool Create(clEmployees newEmployees)
        {
            _listEmployees.Add(newEmployees);
            return true;
        }

        public void DeleteAll()
        {
            _listEmployees.Clear();
        }

        public bool DeleteById(int id)
        {
            var customers = GetById(id)!;
            if (customers != null)
            {
                _listEmployees.Remove(customers);
                return true;
            }
            return false;
        }

        public IEnumerable<clEmployees> GetAll() => _listEmployees;

        public clEmployees GetById(int id) => _listEmployees.Find(c => c.Id == id);

        public bool Update(clEmployees newEmployees)
        {
            var t = _listEmployees.Find(x => x.Id == newEmployees.Id);
            if (t != null)
            {
                _listEmployees[_listEmployees.IndexOf(t)] = newEmployees;
                return true;
            }
            return false;
        }
    }
}
