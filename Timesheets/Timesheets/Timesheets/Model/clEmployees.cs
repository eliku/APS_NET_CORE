using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timesheets.Model
{
    public class clEmployees
    {
        private int _id;
        private string _fio;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string FIO
        { 
            get { return _fio; }
            set { _fio = value; }
        }
    }
}
