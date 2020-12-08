using System;

public class Student
{
    string name;
    int mark;

    private Student(string name, int mark)
    {
        Name = name;
        Mark = mark;
    }

    public string Name
    {
        get => name;
        private set
        {
            if (value.Length < 3 || value[0] >= 'a' && value[0] <= 'z')
            {
                throw new ArgumentException("Incorrect name");
            }
            name = value;
        }
    }

    public int Mark
    {
        get => mark;
        private set
        {
            if (value < 0 || value > 10)
            {
                throw new ArgumentException("Incorrect mark");
            }
            mark = value;
        }
    }

    public static Student Parse(string line)
    {
        string[] unparsed = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        if (unparsed.Length != 2
            || !int.TryParse(unparsed[1], out int mark))
        {
            throw new ArgumentException("Incorrect input mark");
        }
        return new Student(unparsed[0], mark);
    }

    public override string ToString()
    {
        return $"{name} got a grade of {mark}.";
    }
}