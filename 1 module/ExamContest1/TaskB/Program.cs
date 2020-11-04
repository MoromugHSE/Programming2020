using System;

partial class Program
{
    public static void Main(string[] args)
    {
        uint a, b, c, p;
        bool ok = uint.TryParse(Console.ReadLine(), out a);
        ok &= uint.TryParse(Console.ReadLine(), out b);
        ok &= uint.TryParse(Console.ReadLine(), out c);
        ok &= (a > 0) && (b > 0) && (c > 0);
        if (!ok)
        {
            Console.WriteLine("Incorrect input");
            return;
        }
        if (a < b + c && b < a + c && c < a + b)
        {
            p = a + b + c;
            Console.WriteLine(p);
        }
        else
        {
            Console.WriteLine("Incorrect input");
            return;
        }
    }
}