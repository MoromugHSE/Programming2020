using System;
using System.Globalization;
using System.Text;

public class ReplacedString
{
    private string replacedString;

    private static bool CheckforSubstringInStringBuilder(string sb, string substring)
    {
        string s = substring + '#' + sb;
        int[] prefixFun = new int[s.Length];
        prefixFun[0] = 0;
        for (int i=1; i < prefixFun.Length; ++i)
        {
            int cur = prefixFun[i - 1];
            while (cur > 0 && s[i] != s[cur])
            {
                cur = prefixFun[cur - 1];
            }
            if (s[cur] == s[i])
            {
                ++cur;
            }
            if (cur == substring.Length)
            {
                return true;
            }
            prefixFun[i] = cur;
        }
        return false;
    }

    public ReplacedString(string s, string initialSubstring, string finalSubstring)
    {
        while (CheckforSubstringInStringBuilder(s, initialSubstring))
        {
            s = s.Replace(initialSubstring, finalSubstring);
        }
        replacedString = s;
    }

    public override string ToString()
    {
        return replacedString;
    }
}