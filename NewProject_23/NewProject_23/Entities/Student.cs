using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject_23.Entities
{
    internal class Student
    {
        public String RegisterNumber { get; set; }
        public String Name { get; set; }
        public List<Exam> Exams { get; set; }
        public Student()
        {
            Exams= new List<Exam>();
        }
    }
}