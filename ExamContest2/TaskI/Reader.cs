using System;
using System.IO;
using System.Text;

public static class Reader
{
    public static int[] ReadFile(string fileName)
    {
        string[] unparsed = File.ReadAllText(fileName).Split();
        int[] parsed = new int[unparsed.Length];
        for (int i=0; i < parsed.Length; ++i)
        {
            parsed[i] = ParseWord(unparsed[i]);
        }
        return parsed;
    }

    private static int ParseWord(string word)
    {
        StringBuilder sb = new StringBuilder();
        bool isBeforeFirstDigit = true;
        bool isPositive = true;
        foreach (var c in word)
        {
            if (char.IsDigit(c))
            {
                sb.Append(c);
                isBeforeFirstDigit = false;
            }
            else if (isBeforeFirstDigit)
            {
                if (c == '-')
                {
                    isPositive = !isPositive;
                }
            }
        }
        int result = int.Parse(sb.ToString());
        return isPositive ? result : -result;
    }
}