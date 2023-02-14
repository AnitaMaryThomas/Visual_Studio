Console.WriteLine("Enter no of odd numbers");
int odd_no = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter no of even numbers");
int even_no = Convert.ToInt32(Console.ReadLine());
int n = odd_no + even_no;
odd_no = 0;
even_no = 1;
double fare = 0;
double[] fares = new double[n];
Console.WriteLine("Enter the fares :");
for (int i = 0; i < n; i++)
{
    fare = Convert.ToDouble(Console.ReadLine());
    if (fare % 2 == 0)
    {
        fares[even_no] = fare;
        even_no += 2;
    }
    else
    {
        fares[odd_no] = fare;
        odd_no += 2;
    }
}
Console.WriteLine("Entered fares are:");
foreach(int i in fares)
{
    Console.WriteLine(i);
}