using NewProject_23;
using NewProject_23.Entities;
using NewProject_23.Types;

var manager = new StudentManager();
while (true)
{
    Console.WriteLine($"1. Add");
    Console.WriteLine($"2. Update");
    Console.WriteLine($"3. Delete");
    Console.WriteLine($"4. Find");
    Console.WriteLine($"5. AddMark");
    Console.WriteLine($"6. Find");

    int userOption = int.Parse(Console.ReadLine());     //if (!Enum.IsDefined(typeof(Option), userOption))
    //{
    //    Console.WriteLine("Bad Option");
    //    continue;
    //}     //                 Or  
    if (!(userOption > 0 && userOption <= 4))
    {
        Console.WriteLine("Invalid Option.");
        continue;
    }
    Option option = (Option)userOption;
    // or Option option = Enum.Parse<Option>(userOption.ToString())
    switch (option)
    {
        case Option.Add:
            var s = GetStudentData();
            manager.Add(s);
            break;
        case Option.Update:
            var stud = GetStudentData();
            manager.Update(stud); break;
        case Option.Delete:
            Console.WriteLine("Enter a register number :");
            string regNo = Console.ReadLine();
            manager.Delete(regNo);
            break;
        case Option.Find:
            FindStudent();
            break;
        default:
            break;
    }
}
Student GetStudentData()
{
    var student = new Student(); Console.WriteLine("Enter the name :");
    student.Name = Console.ReadLine(); Console.WriteLine("Enter the register number :");
    student.RegisterNumber = Console.ReadLine(); return student;
}
void FindStudent()
{
    Console.WriteLine("Enter register number :");
    string regNo = Console.ReadLine();
    Student student = manager.FindOne(regNo);
    if (student is null)
    {
        Console.WriteLine("No Student where found .");
        return;
    }
    Console.WriteLine("Student Found");
    Console.WriteLine($"Name: {student.Name}");
}
void AddMark()
{
    var exam = new Exam();
    Console.WriteLine("Enter the register number");
    string registerNumber = Console.ReadLine();
    Console.WriteLine(@"1. MidTerm,
        TermEnd,
        Final,
        ClassTest");
    int type = int.Parse(Console.ReadLine());
    exam.Type = (ExamTypes)type;
    int i = 1;
    foreach (var item in Enum.GetNames<Subject>())
    {
        Console.WriteLine($"{i++}. {item}");
    }
    //Console.WriteLine(@"English,
    //    Malayalam,
    //    Physics,
    //    Chemistry, 
    //    Mathematics,
    //    SocialStudies");
    int subject = int.Parse(Console.ReadLine());
    exam.Subject= (Subject)subject;
    Console.WriteLine("Enter exam mark: ");
    exam.MarkScored = int.Parse(Console.ReadLine());    
    manager.AddMark(registerNumber, exam);

}