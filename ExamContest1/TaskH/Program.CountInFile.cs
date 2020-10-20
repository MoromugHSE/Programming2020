using System;
using System.IO;
using System.Text;

partial class Program
{
    private static readonly string[] Separators = {" ", ". ", ", ", "? ", "! ", ": ", "; "};

    private static void CountInFile(string filePath, out int linesCount, out int wordsCount, out int charsCount)
    {
        linesCount = 0;
        wordsCount = 0;
        charsCount = 0;
        foreach (string line in File.ReadLines(filePath, Encoding.UTF8))
        {
            ++linesCount;
            charsCount += line.Length;
            wordsCount += line.Split(Separators, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}