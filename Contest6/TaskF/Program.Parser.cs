using System;


public partial class Program
{
    static Sheep ParseSheep(string line)
    {
        string[] unparsed = line.Split();
        return new Sheep(int.Parse(unparsed[4]), unparsed[1], unparsed[6]);
    }
}
