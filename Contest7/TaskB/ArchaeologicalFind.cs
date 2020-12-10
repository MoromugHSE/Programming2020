using System;
using System.Collections.Generic;
#pragma warning disable

public class ArchaeologicalFind
{
    private int age;
    private int weight;
    private int findNumber;
    private string name;
    private static int alreadyFound = 0;

    private static int findsNumber;

    public ArchaeologicalFind(int age, int weight, string name)
    {
        Age = age;
        Weight = weight;
        Name = name;
    }

    public int Age
    {
        get => age;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Incorrect age");
            }
            age = value;
        }
    }

    public int Weight
    {
        get => weight;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Incorrect weight");
            }
            weight = value;
        }
    }

    public string Name
    {
        get => name;
        private set
        {
            if (value == "?")
            {
                throw new ArgumentException("Undefined name");
            }
            name = value;
        }
    }

    public static int TotalFindsNumber
    {
        get => findsNumber;
        private set
        {
            findsNumber = value;
        }
    }

    /// <summary>
    /// Добавляет находку в список.
    /// </summary>
    /// <param name="finds">Список находок.</param>
    /// <param name="archaeologicalFind">Находка.</param>
    public static void AddFind(ICollection<ArchaeologicalFind> finds, ArchaeologicalFind archaeologicalFind)
    {
        ++TotalFindsNumber;
        foreach (var find in finds)
        {
            if (archaeologicalFind.Equals(find))
            {
                return;
            }
        }
        archaeologicalFind.findNumber = TotalFindsNumber - 1;
        finds.Add(archaeologicalFind);
    }


    public override bool Equals(object obj)
    {
        if (obj is ArchaeologicalFind arch)
        {
            return age == arch.age && weight == arch.weight
                && name == arch.name;
        }
        return false;
    }

    public override string ToString() => $"{findNumber} {name} {age} {weight}";
}