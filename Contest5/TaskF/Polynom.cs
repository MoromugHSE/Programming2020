using System;

class Polynom
{

    public static bool TryParsePolynom(string line, out int[] arr)
    {
        string[] unparsedArr = line.Split(new char[0], 
            StringSplitOptions.RemoveEmptyEntries);
        arr = new int[unparsedArr.Length];
        for (int i=0; i < arr.Length; ++i)
        {
            if (!int.TryParse(unparsedArr[i], out arr[i]))
            {
                return false;
            }
        }
        return true;
    }

    public static int[] Sum(int[] a, int[] b)
    {
        int[] result = new int[Math.Max(a.Length, b.Length)];
        for (int i=0; i < result.Length; ++i)
        {
            result[i] = 0;
            if (i < a.Length)
            {
                result[i] += a[i];
            }
            if (i < b.Length)
            {
                result[i] += b[i];
            }
        }
        return result;
    }

    public static int[] Dif(int[] a, int[] b)
    {
        int[] result = new int[Math.Max(a.Length, b.Length)];
        for (int i = 0; i < result.Length; ++i)
        {
            result[i] = 0;
            if (i < a.Length)
            {
                result[i] -= a[i];
            }
            if (i < b.Length)
            {
                result[i] -= b[i];
            }
        }
        return result;
    }

    public static int[] MultiplyByNumber(int[] a, int n)
    {
        int[] result = new int[a.Length];
        for (int i=0; i < result.Length; ++i)
        {
            result[i] = a[i] * n;
        }
        return result;
    }

    public static int[] MultiplyByPolynom(int[] a, int[] b)
    {
        int[] result = new int[a.Length + b.Length - 1];
        Array.Fill(result, 0);
    }

    public static string PolynomToString(int[] polynom)
    {
        throw new NotImplementedException();
    }
}
