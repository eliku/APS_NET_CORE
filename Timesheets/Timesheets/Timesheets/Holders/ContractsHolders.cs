using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timesheets.Model;

namespace Timesheets.Holders
{
    public class ContractsHolders
    {
        private List<clContracts> _listContracts { get; set; }

        public ContractsHolders()
        {
            List<clContracts> _listContracts = new List<clContracts>();
        }

        public bool Create(clContracts newContracts)
        {
            _listContracts.Add(newContracts);
            return true;
        }

        public void DeleteAll()
        {
            _listContracts.Clear();
        }

        public bool DeleteById(int id)
        {
            var contract = GetById(id)!;
            if (contract != null)
            {
                _listContracts.Remove(contract);
                return true;
            }
            return false;
        }

        public IEnumerable<clContracts> GetAll() => _listContracts;

        public clContracts GetById(int id) => _listContracts.Find(c => c.Id == id);

        public bool Update(clContracts newContracts)
        {
            var t = _listContracts.Find(x => x.Id == newContracts.Id);
            if (t != null)
            {
                _listContracts[_listContracts.IndexOf(t)] = newContracts;
                return true;
            }
            return false;
        }
    }
}
