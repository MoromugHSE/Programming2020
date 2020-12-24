using System;

class Program
{
    public static void Main(string[] args)
    {
        int firstMax = int.MinValue;
        int secondMax = int.MinValue;
        string input;
        int cur;
        while (int.TryParse(Console.ReadLine(), out cur) && cur != 0)
        {
            if (cur < 100 || cur > 150)
            {
                Console.WriteLine("Incorrect number");
            }
            else
            {
                if (cur >= firstMax)
                {
                    secondMax = firstMax;
                    firstMax = cur;
                }
                else if (cur >= secondMax)
                {
                    secondMax = cur;
                }
            }
        }
        Console.WriteLine(firstMax);
        Console.WriteLine(secondMax);
    }
}