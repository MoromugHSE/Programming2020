using System.IO;

public static partial class Program
{
    private static int GetCountCapitalLetters(string inputPath)
    {
        int count = 0;
        string text = File.ReadAllText(inputPath);
        foreach (char ch in text)
        {
            if (char.IsUpper(ch))
            {
                ++count;
            }
        }
        return count;
    }

    private static void WriteCount(string outputPath, int count)
    {
        File.WriteAllText(outputPath, count.ToString());
    }
}