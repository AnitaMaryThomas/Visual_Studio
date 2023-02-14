//IStudent st = new SchoolStudent(); //Co-variance
//st.Display();
//interface IStudent
//{
//    public void Display();
//}
//class SchoolStudent : IStudent
//{
//    public string Name { get; set; }
//    public void Display() => Console.WriteLine(Name);

//}


//using Intrface_28.Entities;
////using System.Xml.Schema;

//var students = new List<IStudent>();
//while (true)
//{
//    Console.WriteLine("1. Add School student");
//    Console.WriteLine("2. Add College student");
//    Console.WriteLine("3. Display Student");
//    int option = int.Parse(Console.ReadLine());
//    switch (option)
//    {
//        case 1:
//            var ss = new SchoolStudent();
//            ss.GetData();
//            students.Add(ss);
//            break;
//        case 2:
//            var cs = new CollegeStudent();
//            cs.GetData();
//            students.Add(cs);
//            break;
//       case 3:
//            foreach (var student in students)
//            {
//                student.Display();
//            }
//            break;
//            default:
//            break;
//    }

//}


// void Total(IEnumerable<int> numbers)
//{
//    Console.WriteLine(numbers.Sum());

//}
//Total(new int[] {1, 2,3});
//Total(new List<int> {1, 2,3});


//
var p1 = new Person<int>();
p1.Age = 20;
var p2 = new Person<double>();
p2.Age = 22.5;

class Person<T>
{
    public string Name { get; set; }
    public T Age { get; set; }
}