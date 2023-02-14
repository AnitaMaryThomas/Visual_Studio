namespace Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Strg, rev;
            Strg = "ANITA MARY THOMAS";
            rev = "";
            Console.WriteLine("Value of given String is: {0}", Strg);
            int a;
            a = Strg.Length - 1;
            while (a >= 0)
            {
                rev = rev + Strg[a];
                a--;
            }
            Console.WriteLine("Reversed string is: {0}", rev);
            Console.ReadLine();
        }
    }
}