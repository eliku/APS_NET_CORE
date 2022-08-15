using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timesheets.Model
{
    public class clCompany
    {
        private string _name;
        private List<clContracts> _listContracts = new List<clContracts>();

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public List<clContracts> ListContracts
        { 
            get { return _listContracts; }
            set { _listContracts = value; }
        }
    }
}
