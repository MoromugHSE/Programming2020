using System;

class Program
{
    public static void Main(string[] args)
    {
        short a, b, c;
        bool ok1 = short.TryParse(Console.ReadLine(), out a);
        bool ok2 = short.TryParse(Console.ReadLine(), out b);
        if (!ok1 || !ok2)
        {
            Console.WriteLine("Incorrect input");
            return;
        }
        c = (short)(a ^ b);
        Console.WriteLine(c);
    }
}