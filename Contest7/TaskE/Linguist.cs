using System;

class Linguist : Editor
{
    private string bannedWord;

    private Linguist(string name, int salary, string bannedWord) : base(name, salary)
    {
        this.bannedWord = bannedWord;
    }

    public new string EditHeader(string header)
    {
        return base.EditHeader(header.Replace(bannedWord, ""));
    }

    public static Linguist Parse(string line)
    {
        string[] unparsed = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        if (unparsed.Length != 3
            || !int.TryParse(unparsed[1], out int salary)
            || salary < 0)
        {
            throw new ArgumentException("Incorrect input");
        }
        return new Linguist(unparsed[0], salary, unparsed[2]);
    }
}