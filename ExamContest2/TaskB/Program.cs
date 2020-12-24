using System;

class Program
{
    public static void Main(string[] args)
    {
        string[] unparsed = Console.ReadLine().Split();
        int count = unparsed.Length;
        double sum = 0;
        foreach (var item in unparsed)
        {
            sum += int.Parse(item);
        }
        Console.WriteLine($"{sum / count:F3}");
    }
}