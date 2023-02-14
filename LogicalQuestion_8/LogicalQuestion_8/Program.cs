string[] Destination = new string[3];
decimal[] fareList= new decimal[3];
int i = 3;
for (i = 0;i < 3; i++)
{
    Console.WriteLine("Enter the destination");
    Destination[i] = Console.ReadLine();
    Console.WriteLine("Enter the farelist");
    fareList[i] = Convert.ToDecimal(Console.ReadLine());
}
Console.WriteLine("Enter the nth index: ");
int d = Convert.ToInt32(Console.ReadLine());
if (d > 3)
{
    Console.WriteLine("Invalid index");
}
else
{
    Console.WriteLine("Destination: " + Destination[d]);
    Console.WriteLine("FareList: " + fareList[d]);
}

