using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Intrface_28.Entities
{
    internal class CollegeStudent: IStudent
    {
        public string Name { get; set; }
        public string Branch { get; set; }
        public void Display()
        {
            Console.WriteLine($"{Name} of class {Branch}");

        }
        public void GetData()
        {
            Console.WriteLine("Enter the name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the branch: ");
            Branch = Console.ReadLine();

        }
    }
}
