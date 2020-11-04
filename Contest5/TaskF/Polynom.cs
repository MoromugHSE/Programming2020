using System;
using System.Text;

class Polynom
{

    public static bool TryParsePolynom(string line, out int[] arr)
    {
        string[] unparsedArr = line.Split();
        arr = new int[unparsedArr.Length];
        for (int i = 0; i < arr.Length; ++i)
        {
            if (!int.TryParse(unparsedArr[i], out arr[i]))
            {
                return false;
            }
        }
        for (int i = 0; i < arr.Length; ++i)
        {
            if (arr[i] != 0)
            {
                return true;
            }
        }
        arr = new int[1] { 0 };
        return true;
    }

    public static int[] Sum(int[] a, int[] b)
    {
        int[] result = new int[a.Length > b.Length ? a.Length : b.Length];
        for (int i = 0; i < result.Length; ++i)
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
        for (int i = 0; i < result.Length; ++i)
        {
            if (result[i] != 0)
            {
                return result;
            }
        }
        return new int[1] { 0 };
    }

    public static int[] Dif(int[] a, int[] b)
    {
        int[] result = new int[a.Length > b.Length ? a.Length : b.Length];
        for (int i = 0; i < result.Length; ++i)
        {
            result[i] = 0;
            if (i < a.Length)
            {
                result[i] += a[i];
            }
            if (i < b.Length)
            {
                result[i] -= b[i];
            }
        }
        for (int i = 0; i < result.Length; ++i)
        {
            if (result[i] != 0)
            {
                return result;
            }
        }
        return new int[1] { 0 };
    }

    public static int[] MultiplyByNumber(int[] a, int n)
    {
        int[] result = new int[a.Length];
        for (int i = 0; i < result.Length; ++i)
        {
            result[i] = a[i] * n;
        }
        for (int i = 0; i < result.Length; ++i)
        {
            if (result[i] != 0)
            {
                return result;
            }
        }
        return new int[1] { 0 };
    }

    public static int[] MultiplyByPolynom(int[] a, int[] b)
    {
        int[] result = new int[a.Length + b.Length];
        for (int i = 0; i < result.Length; ++i) result[i] = 0;
        for (int i = 0; i < a.Length; ++i)
        {
            for (int j = 0; j < b.Length; ++j)
            {
                result[i + j] += a[i] * b[j];
            }
        }
        for (int i = 0; i < result.Length; ++i)
        {
            if (result[i] != 0)
            {
                return result;
            }
        }
        return new int[1] { 0 };
    }

    public static string PolynomToString(int[] polynom)
    {
        if (polynom.Length == 1 && polynom[0] == 0)
        {
            return "0";
        }
        bool isSeparatorNeeded = false;
        StringBuilder sb = new StringBuilder();
        for (int i = polynom.Length - 1; i > 0; --i)
        {
            if (polynom[i] == 0)
            {
                continue;
            }
            if (!isSeparatorNeeded)
            {
                isSeparatorNeeded = true;
                if (polynom[i] == 1)
                {
                    if (i == 1)
                    {
                        sb.Append("x");
                    }
                    else
                    {
                        sb.Append($"x{i}");
                    }
                }
                else
                {
                    if (i == 1)
                    {
                        sb.Append($"{polynom[i]}x");
                    }
                    else
                    {
                        sb.Append($"{polynom[i]}x{i}");
                    }
                }
            }
            else
            {
                sb.Append(" + ");
                if (polynom[i] == 1)
                {
                    if (i == 1)
                    {
                        sb.Append("x");
                    }
                    else
                    {
                        sb.Append($"x{i}");
                    }
                }
                else
                {
                    if (i == 1)
                    {
                        sb.Append($"{polynom[i]}x");
                    }
                    else
                    {
                        sb.Append($"{polynom[i]}x{i}");
                    }
                }
            }
        }
        if (polynom[0] != 0)
        {
            if (!isSeparatorNeeded)
            {
                sb.Append($"{polynom[0]}");
            }
            else
            {
                sb.Append($" + {polynom[0]}");
            }
        }
        return sb.ToString();
    }
}
