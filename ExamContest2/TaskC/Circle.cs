using System;

public static class Circle
{
    public static double Circumference(double radius)
    {
        return 2 * Math.PI * radius;
        throw new NotImplementedException();
    }

    public static double Square(double radius)
    {
        return Math.PI * radius * radius;
        throw new NotImplementedException();
    }

    public static double Distance(double x1, double y1, double r1, double x2, double y2, double r2)
    {
        double centerDist = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        return Math.Max(0, centerDist - r1 - r2);
        throw new NotImplementedException();
    }
}