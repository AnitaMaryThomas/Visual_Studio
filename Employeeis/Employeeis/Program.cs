//var employees = new List<Dictionary<string, string>>();
//while (true)
//{
//    Console.WriteLine("1. Enter the employee details");
//    Console.WriteLine("2. View the details");
//    Console.WriteLine("3. Exit");

//    String? input = Console.ReadLine();
//    switch(input)
//    {
//        case "1":
//            AddEmployee();
//            break;
//            case "2":
//            DisplayEmployee();
//            break;
//            case "3":
//            Environment.Exit(0);
//            break;
//            default:
//            Console.WriteLine("Invalid Option.");
//            break;
//    }
//}
//void AddEmployee()
//{
//    var employee =new Dictionary<string, string>();
//    Console.WriteLine("Enter the employee name: ");
//    employee["Name"] = Console.ReadLine();
//    Console.WriteLine("Enter the employee email: ");
//    employee["Name"] = Console.ReadLine();

//}
//void DisplayEmployee()
//{
//    foreach (var item in employees)
//    {
//        Console.WriteLine(item["Name"]);
//        Console.WriteLine(item["Email"]);

//    }
//}


using Employeeis;

var e = new Employee()
{
   Name = "Emp 1",
   Email = "emp1@gmail.com"
};
Console.WriteLine(e);
