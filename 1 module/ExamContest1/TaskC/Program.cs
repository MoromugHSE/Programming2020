using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        double x = double.Parse(Console.ReadLine());
        double aprev, anext, step;
        int n = 0;
        aprev = anext = Math.Pow(x, 4)/24;
        double sum = 0;
        while (Math.Abs(aprev) > double.Epsilon)
        {
            sum += anext;
            aprev = anext;
            step = -Math.Pow(x, 3) / (3 * n + 5) / (3 * n + 6) / (3 * n + 7);
            anext = aprev * step;
            ++n;
        }
        Console.WriteLine(sum);
    }
}