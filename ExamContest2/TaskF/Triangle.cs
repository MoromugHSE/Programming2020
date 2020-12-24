using System;
using System.Collections.Generic;

public sealed class Triangle : GeometryRef
{
    protected override List<Point> Points
    {
        set
        {
            if (value.Count != 3)
            {
                throw new ArgumentException("Incorrect input");
            }
            points = value;
        }
    }

    public Triangle(List<Point> points) : base(points)
    {
    }

    protected override double GetPerimeter()
    {
        double side1 = Math.Sqrt(Math.Pow(points[0].X - points[1].X, 2)
            + Math.Pow(points[0].Y - points[1].Y, 2));
        double side2 = Math.Sqrt(Math.Pow(points[1].X - points[2].X, 2)
            + Math.Pow(points[1].Y - points[2].Y, 2));
        double side3 = Math.Sqrt(Math.Pow(points[2].X - points[0].X, 2)
            + Math.Pow(points[2].Y - points[0].Y, 2));
        return side1 + side2 + side3;
    }

    public override double GetSquare()
    {
        double dX;
        double dY;
        if (points[0].Y.CompareTo(points[1].Y) == 0)
        {
            dX = Math.Abs(points[0].X - points[1].X);
            dY = Math.Abs(points[0].Y - points[2].Y);
        }
        else if (points[0].Y.CompareTo(points[2].Y) == 0)
        {
            dX = Math.Abs(points[0].X - points[2].X);
            dY = Math.Abs(points[0].Y - points[1].Y);
        }
        else
        {
            dX = Math.Abs(points[1].X - points[2].X);
            dY = Math.Abs(points[0].Y - points[2].Y);
        }
        return dX * dY / 2;
    }
}