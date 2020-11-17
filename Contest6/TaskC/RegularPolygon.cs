using System;

public class RegularPolygon : Polygon
{
    private double side;
    private int numberOfSides;

    public RegularPolygon(double side, int numberOfSides)
    {
        if (!(side > 0))
        {
            throw new ArgumentException("Side length value should be greater than zero.");
        }
        this.side = side;
        if (numberOfSides < 3)
        {
            throw new ArgumentException("Number of sides value should be greater than 3.");
        }
        this.numberOfSides = numberOfSides;
    }

    public override double Perimeter => side * numberOfSides;

    public override double Area => numberOfSides*side*side/
        Math.Tan(Math.PI/numberOfSides)/4;

    public override string ToString()
    {
        return $"side: {side}; numberOfSides: {numberOfSides}; " + base.ToString();
    }

}