using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    internal class Employees
    {
        public string name { get; set; }
        private int _age;



        public int Age
        {
            get { return _age; }
            set
            {
                if (value >= 0 && value <= 100)
                    _age = value;
            }
        }
    }

}
