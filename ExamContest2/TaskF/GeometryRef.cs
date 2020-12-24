using System;
using System.Collections.Generic;

public class GeometryRef
{
    protected List<Point> points;

    protected virtual List<Point> Points
    {
        get => points;
        set
        {
            if (value.Count == 0)
            {
                throw new ArgumentException("Incorrect input");
            }
            points = value;
        }
    }

    protected GeometryRef(List<Point> points)
    {
        Points = points;
    }

    protected virtual double GetPerimeter()
    {
        return 0;
    }

    public virtual double GetSquare()
    {
        return 0;
    }

    public static Point MakePoint(string x, string y)
    {
        double ptX;
        double ptY;
        if (!double.TryParse(x, out ptX) || !double.TryParse(y, out ptY))
        {
            throw new ArgumentException("Incorrect input");
        }
        return new Point(ptX, ptY);
    }

    public static GeometryRef Parse(string line)
    {
        List<Point> points = new List<Point>();
        string[] unparsed = line.Split(new char[] { },
            StringSplitOptions.RemoveEmptyEntries);
        if (unparsed.Length < 1 || unparsed.Length%2 == 0)
        {
            throw new ArgumentException("Incorrect input");
        }
        for (int i=1; i < unparsed.Length; i += 2)
        {
            points.Add(MakePoint(unparsed[i], unparsed[i + 1]));
        }
        switch (unparsed[0])
        {
            case "Triangle":
                {
                    return new Triangle(points);
                }
            case "Rectangle":
                {
                    return new Rectangle(points);
                }
            case "GeometryRef":
                {
                    return new GeometryRef(points);
                }
            default:
                {
                    throw new ArgumentException("Incorrect input");
                }
        }
    }

    public override string ToString()
    {
        return $"{base.ToString()}. P = {GetPerimeter():F2}. S = {GetSquare():F2}.";
    }
}