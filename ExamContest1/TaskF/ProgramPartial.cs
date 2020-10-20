using System;
using System.Collections.Generic;
using System.Text;

partial class Program
{
    static int Count(int[] arr, int k)
    {
        long result = 0;
        Dictionary<int, int> dict = new Dictionary<int, int>();
        Array.Sort(arr);
        foreach (int x in arr)
        {
            if (!dict.TryGetValue(x, out int value))
            {
                dict.Add(x, 1);
            }
            else
            {
                ++dict[x];
            }
        }
        foreach (int x in arr)
        {
            if (x == k-x)
            {
                result += dict[x] - 1;
            }
            else
            {
                int val;
                if (dict.TryGetValue(k-x, out val))
                {
                    result += val;
                }
            }
        }
        result >>= 1;
        return (int)result;
    }
}
