namespace New_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 10;
            Console.WriteLine("Before swaping: a= " + a + " b= " + b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.Write("After swaping: a= " + a + " b= " + b);
        }
    }
}
