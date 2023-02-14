//ACCEPT PASSENGERS DOB AND DISPLAY AGE 

DateTime[] DOB = new DateTime[5]; 
for (int i = 0; i < 5; i++) 
{ Console.WriteLine("Enter date of births: ");
    DateTime Birthdate = Convert.ToDateTime(Console.ReadLine()); 
    DOB[i] = Birthdate;
}
DateTime today = DateTime.Now; 
for (int i = 0; i < DOB.Length; i++)
{
    var year = DOB[i].Year;
    int age = today.Year - year;
    Console.WriteLine("Your age is " + age);
    switch (age)
    {
        case (> 0 and < 10):
            Console.WriteLine("You are a kid ");
            break;
        case (>= 10 and < 30):
            Console.WriteLine("You are in youth ");
            break;
        case (>= 30 and < 60):
            Console.WriteLine("You are an adult ");
            break;
        case (>= 60):
            Console.WriteLine("You are older ");
            break;
    }
}


