using ConsoleAppCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCore
{
    internal class schoolstudent: Student
    {
        public int Age { get; set; }
        public String RegisterNumber { get;}
        //public readonly registernumber

        public schoolstudent(string registerNumber)
        {
            RegisterNumber = registerNumber;
           
        }
        // only one time readonly remove the set
        public const string schoolname = "school xyz";
    }

}
