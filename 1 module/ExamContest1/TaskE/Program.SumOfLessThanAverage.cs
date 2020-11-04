using System;
using System.Linq;

public partial class Program
{
    static bool IsArrayLengthCorrect(int length)
    {
        return length > 0;
    }

    static bool GenerateArray(int length, out int[] arr)
    {
        arr = new int[length];
        bool ok;
        for (int i = 0; i < length; ++i)
        {
            ok = int.TryParse(Console.ReadLine(), out arr[i]);
            if (!ok)
            {
                return false;
            }
        }
        return true;
    }

    public static double GetArrayAverage(int[] arr)
    {
        double sum = 0;
        int n = arr.Length;
        foreach (var item in arr)
        {
            sum += item;
        }
        return sum / n;
    }

    public static int GetSumOfNumbersLessThanAverage(int[] arr, double average)
    {
        int sum = 0;
        foreach (var item in arr)
        {
            if (item < average)
            {
                sum += item;
            }
        }
        return sum;
    }
}