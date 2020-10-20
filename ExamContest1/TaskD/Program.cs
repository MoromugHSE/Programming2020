using System;

class Program
{
    static double BinPow(double x, ulong pow)
    {
        //if (pow == 1)
        //{
        //    return x;
        //}
        //if ((pow&1) == 0)
        //{
        //    return BinPow(x, pow >> 1) * BinPow(x, pow >> 1);
        //}
        //return BinPow(x, pow - 1) * x;
        double dopMnozh = 1;
        while (pow > 1)
        {
            if ((pow&1) == 0)
            {
                x *= x;
                pow >>= 1;
            }
            else
            {
                --pow;
                dopMnozh *= x;
            }
        }
        return x * dopMnozh;
    }
    static void Main(string[] args)
    {
        double x;
        bool ok = double.TryParse(Console.ReadLine(), out x);
        ulong k;
        ok &= ulong.TryParse(Console.ReadLine(), out k);
        if (!ok)
        {
            Console.WriteLine("Incorrect input");
            return;
        }
        if (k == 0)
        {
            Console.WriteLine(1);
            return;
        }
        Console.WriteLine(BinPow(x, k));
    }
}