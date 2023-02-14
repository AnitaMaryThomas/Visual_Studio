using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Intrface_28.Entities
{
    internal class SchoolStudent: IStudent
    {
        public string Name { get; set; }
        public int Class { get; set; }
        public void Display()
        {
            Console.WriteLine($"{Name} of class {Class}");
        }
        public void GetData()
        {
            Console.WriteLine("Enter the name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the branch: ");
            Class = int.Parse(Console.ReadLine());

        }
    }
}
