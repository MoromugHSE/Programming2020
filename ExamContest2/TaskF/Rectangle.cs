using System;
using System.Collections.Generic;

public sealed class Rectangle : GeometryRef
{
    protected override List<Point> Points
    {
        set
        {
            if (value.Count != 4)
            {
                throw new ArgumentException("Incorrect input");
            }
            points = value;
        }
    }

    public Rectangle(List<Point> points) : base(points)
    {
    }

    protected override double GetPerimeter()
    {
        double maxX = Math.Max(Math.Max(points[0].X, points[1].X),
            Math.Max(points[2].X, points[3].X));
        double minX = Math.Min(Math.Min(points[0].X, points[1].X),
            Math.Min(points[2].X, points[3].X));
        double maxY = Math.Max(Math.Max(points[0].Y, points[1].Y),
            Math.Max(points[2].Y, points[3].Y));
        double minY = Math.Min(Math.Min(points[0].Y, points[1].Y),
            Math.Min(points[2].Y, points[3].Y));
        return 2 * (maxX - minX) + 2 * (maxY - minY);
    }

    public override double GetSquare()
    {
        double maxX = Math.Max(Math.Max(points[0].X, points[1].X),
            Math.Max(points[2].X, points[3].X));
        double minX = Math.Min(Math.Min(points[0].X, points[1].X),
            Math.Min(points[2].X, points[3].X));
        double maxY = Math.Max(Math.Max(points[0].Y, points[1].Y),
            Math.Max(points[2].Y, points[3].Y));
        double minY = Math.Min(Math.Min(points[0].Y, points[1].Y),
            Math.Min(points[2].Y, points[3].Y));
        return (maxX - minX) * (maxY - minY);
    }
}