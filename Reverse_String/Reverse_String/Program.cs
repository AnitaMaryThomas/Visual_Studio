namespace Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Str, rev;
            Str = "ANITA MARY THOMAS";
            rev = "";
            Console.WriteLine("Value of given String is: {0}", Str);
            int a;
            a = Str.Length - 1;
            while (a >= 0)
            {
                rev = rev + Str[a];
                a--;
            }
            Console.WriteLine("Reversed string is: {0}", rev);
            Console.ReadLine();
        }
    }
}