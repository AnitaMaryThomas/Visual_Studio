using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Student
    {
        public string name { get; set; }
        public int mark1 { get; set; }
        public int mark2 { get; set; }
        public int total
        {
            get
            {
                return mark1 + mark2;
            }
        }
        //public string name { get; set; }
        //public List<Mark> Marks { get; set; }

    }
    

}
