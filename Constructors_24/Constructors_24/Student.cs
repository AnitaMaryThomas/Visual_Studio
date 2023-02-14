using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_24
{
    internal class Student
    {
        public string RegisterNumber { get; }
        public string Name { get; set; }

        // Different constructors..........................................

        //public Student(string registerNumber)
        //{
        //    registerNumber = registerNumber;
        //}
        //public Student(string registerNumber, string name)
        //{
        //    registerNumber = registerNumber;
        //    name = name;
        //}

        public int Age { get; set; }
        public static string School { get; set; }
        static Student() // Static constructor to access the static element
        {
            School = "New School";
        }
        public override string ToString()
        {
            return $"Name: {Name}, School: {School}";
        }

    }
}
