using System;
using System.Collections.Generic;

public class Mushroom
{
    string name;
    double weight;
    double diameter;

    public string Name { 
        get => name;
        private set
        {
            name = value;
        }
    }
    public double Weight
    {
        get => weight;
        private set
        {
            if (!(value > 0))
            {
                throw new ArgumentException("Incorrect input");
            }
            weight = value;
        }
    }
    public double Diameter
    {
        get => diameter;
        private set
        {
            if (!(value > 0))
            {
                throw new ArgumentException("Incorrect input");
            }
            diameter = value;
        }
    }

    private Mushroom(string name, double weight, double diameter)
    {
        Name = name;
        Weight = weight;
        Diameter = diameter;
    }

    public static Mushroom Parse(string line)
    {
        string[] unparsed = line.Split();
        double weight;
        double diameter;
        if (unparsed.Length != 3 ||
            !double.TryParse(unparsed[1], out weight) ||
            !double.TryParse(unparsed[2], out diameter))
        {
            throw new ArgumentException("Incorrect input");
        }
        return new Mushroom(unparsed[0], weight, diameter);

    }

    public static double GetAverageDiameter(List<Mushroom> mushrooms, double m)
    {
        int counter = 0;
        double sum = 0;
        foreach (var mushroom in mushrooms)
        {
            if (mushroom.Weight > m)
            {
                ++counter;
                sum += mushroom.Diameter;
            }
        }
        return counter == 0 ? 0 : sum / counter;
    }
}