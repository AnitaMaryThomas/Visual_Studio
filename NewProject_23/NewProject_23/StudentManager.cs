using NewProject_23.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject_23
{
   internal class StudentManager
    {
        private List<Student> _students;
        // Create a  Constructor - ctor
        public StudentManager()
        {
            _students = new List<Student>()
            {
                new Student() { Name = "Student 1", RegisterNumber = "s1" },
                new Student() { Name = "Student 2", RegisterNumber = "s2" },
                new Student() { Name = "Student 3", RegisterNumber = "s3" },
                new Student() { Name = "Student 4", RegisterNumber = "s4" },
                new Student() { Name = "Student 5", RegisterNumber = "s5" }
            };        
        }        
        public void Add(Student student)
        {
            Student existingStudent = FindOne(student.RegisterNumber);
            if(existingStudent != null)
            {
                Console.WriteLine("Student already exists");
                return;
            }
            _students.Add(student);       
        }        
        public Student? FindOne(string registerNumber) 
        {
            foreach (var item in _students)
            {
                if(item.RegisterNumber == registerNumber)
                    return item;
            }
            return default;
        }         public void Update(Student student) 
        {
            Student existingStudent = FindOne(student.RegisterNumber);
            if (existingStudent == null)
            {
                Console.WriteLine("Student not found");
                return;
            }
            existingStudent.Name= student.Name;
        }         public void Delete(string registerNumber) 
        { 
            Student student = FindOne(registerNumber);
            if (student == null)
            {
                Console.WriteLine("Student not found");
                return;
            }
            _students.Remove(student);       
        }
    }
    public void AddMark()
    {
       
    }
}
