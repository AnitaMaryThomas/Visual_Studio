using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Class1
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
        //public string ExamName { get; set; }
        //public string Subject { get; set; }
        //public int MarkScored { get; set; }
        //public int Maxmark { get; set; }
    }
}
