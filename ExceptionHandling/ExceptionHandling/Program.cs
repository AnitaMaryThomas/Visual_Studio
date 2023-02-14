//try
//{
//    Console.WriteLine("Enter number 1: ");
//    int num1 = int.Parse(Console.ReadLine());

//    Console.WriteLine("Enter number 2: ");
//    int num2 = int.Parse(Console.ReadLine());

//    Console.WriteLine(num1 / num2);
//}
//catch
//{
//    Console.WriteLine("An error occured");
//}

// try and catch by using exception...........................................................
try
{
    Console.WriteLine("Enter number 1: ");
    int num1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter number 2: ");
    int num2 = int.Parse(Console.ReadLine());
    if (num2 == 0)
    {
        throw new DivideByZeroException("Second number should not be zero.");
    }
    Console.WriteLine(num1 + num2);
    Console.WriteLine(num1 * num2);
    Console.WriteLine(num1 - num2);
    Console.WriteLine(num1 / num2);
}
//catch (DivideByZeroException)
//{
//    Console.WriteLine("Second number should not be zero.");
//}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

