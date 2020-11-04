using System;
using System.Globalization;
using System.Text;

public class ReplacedString
{
    private string replacedString;

    public ReplacedString(string s, string initialSubstring, string finalSubstring)
    {
        string s1 = s.Replace(initialSubstring, finalSubstring);
        while (s1 != s)
        {
            s = s1;
            s1 = s.Replace(initialSubstring, finalSubstring);
        }
        replacedString = s;
    }

    public override string ToString()
    {
        return replacedString;
    }
}