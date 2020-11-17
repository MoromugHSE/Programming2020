using System;

public class Apple
{
    private double weight;
    private string color;
    public double Weight
    {
        get => weight;
        set
        {
            if (!(value > 0) || value > 1000)
            {
                throw new ArgumentException("Incorrect input");
            }
            weight = value;
        }
    }
    public string Color
    {
        get => color;
        set
        {
            if (value[0] >= 'a' && value[0] <= 'z' || value.Length > 5)
            {
                throw new ArgumentException("Incorrect input");
            }
            color = value;
        }
    }

    public override string ToString()
    {
        return $"{color} Apple. Weight = {weight:F2}g.";
    }
}