using System;
using System.Collections.Generic;
using System.Text;

partial class Program
{
    private static string Encrypt(string input)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>(60);
        foreach (char ch in input)
        {
            if (!dict.TryGetValue(ch, out int val))
            {
                dict.Add(ch, 1);
            }
            else
            {
                ++dict[ch];
            }
        }
        char freqChar = input[0], lessChar = input[0];
        int maxFreq = dict[freqChar], minFreq = dict[lessChar];
        foreach (char ch in input)
        {
            if (dict[ch] > maxFreq)
            {
                freqChar = ch;
                maxFreq = dict[ch];
            }
            if (dict[ch] < minFreq)
            {
                lessChar = ch;
                minFreq = dict[ch];
            }
        }
        StringBuilder str = new StringBuilder();
        foreach (char ch in input)
        {
            if (ch == freqChar)
            {
                str.Append(lessChar);
            }
            else if (ch == lessChar)
            {
                str.Append(freqChar);
            }
            else
            {
                str.Append(ch);
            }
        }
        return str.ToString();
    }
}
