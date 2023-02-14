Console.WriteLine("Enter the passenger name: ");
string name = Console.ReadLine();
Console.WriteLine("Enter the total miles : ");
double totalmiles = Convert.ToDouble(Console.ReadLine());
//if (totalmiles >= 10000)
//{
//    Console.WriteLine("Award 10 frequent flyer points");
//}
//else if (totalmiles >= 20000)
//{
//    Console.WriteLine("Award 20 frequent flyer points");
//}
//else if (totalmiles >= 50000)
//{
//    Console.WriteLine("Award 30 frequent flyer points");
//}
//else if (totalmiles >= 100000 )
//{
//    Console.WriteLine("Award 50 frequent flyer points");
//}
//else
//{
//    Console.WriteLine("Not valid");
//}
switch (totalmiles)
{
    case (>=10000 and <= 20000):
        Console.WriteLine("Award 10 frequent flyer points");
        break;
    case (>= 20000 and <= 30000):
        Console.WriteLine("Award 20 frequent flyer points");
        break;
    case (>= 50000 and <= 100000):
        Console.WriteLine("Award 30 frequent flyer points");
        break;
    case (>= 100000):
        Console.WriteLine("Award 50 frequent flyer points");
        break;
        default: Console.WriteLine("Not Valid");
        break;
}