using System;

class Program
{
    public static void Main(string[] args)
    {
        string[] unparsed1 = Console.ReadLine().Split();
        string[] unparsed2 = Console.ReadLine().Split();
        int[] parsed1 = new int[unparsed1.Length];
        int[] parsed2 = new int[unparsed2.Length];
        for (int i = 0; i < parsed1.Length; ++i)
        {
            parsed1[i] = int.Parse(unparsed1[i]);
        }
        for (int i = 0; i < parsed2.Length; ++i)
        {
            parsed2[i] = int.Parse(unparsed2[i]);
        }
        // Code is mostly from https://algorithmica.org/tg/knapsack-gis-gcs
        int[,] greatestCommonSubsequence = new int[parsed1.Length + 1, parsed2.Length + 1];
        for (int i = 1; i <= parsed1.Length; ++i)
        {
            for (int j = 1; j <= parsed2.Length; ++j)
            {
                if (parsed1[i - 1] == parsed2[j - 1])
                {
                    greatestCommonSubsequence[i, j] = greatestCommonSubsequence[i - 1, j - 1] + 1;
                }
                else
                {
                    greatestCommonSubsequence[i, j] = Math.Max(greatestCommonSubsequence[i - 1, j], greatestCommonSubsequence[i, j - 1]);
                }
            }
        }
        Console.WriteLine(greatestCommonSubsequence[parsed1.Length, parsed2.Length]);
    }
}