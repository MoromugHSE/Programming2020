using System;

public class Triangle
{
    private readonly Point a;
    private readonly Point b;
    private readonly Point c;

    private double AB => GetLengthOfSide(a, b);
    private double AC => GetLengthOfSide(a, c);
    private double BC => GetLengthOfSide(b, c);

    public Triangle(Point a, Point b, Point c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public double GetPerimeter()
    {
        return AB + AC + BC;
    }

    public double GetSquare()
    {
        double halfPer = GetPerimeter() / 2;
        return Math.Sqrt(halfPer * (halfPer - AB) * (halfPer - AC) * (halfPer - BC));
    }

    public bool GetAngleBetweenEqualsSides(out double angle)
    {
        if (Math.Abs(AB - AC) < 1e-6)
        {
            angle = 2 * Math.Asin(BC / 2 / AC);
            return true;
        }
        if (Math.Abs(AC - BC) < 1e-6)
        {
            angle = 2 * Math.Asin(AB / 2 / BC);
            return true;
        }
        if (Math.Abs(BC - AB) < 1e-6)
        {
            angle = 2 * Math.Asin(AC / 2 / AB);
            return true;
        }
        angle = double.NaN;
        return false;
    }

    public bool GetHypotenuse(out double hypotenuse)
    {
        double AB = this.AB;
        double AC = this.AC;
        double BC = this.BC;
        if (Math.Abs(AB * AB + AC * AC - BC * BC) < 1e-6)
        {
            hypotenuse = BC;
            return true;
        }
        if (Math.Abs(AC * AC + BC * BC - AB * AB) < 1e-6)
        {
            hypotenuse = AB;
            return true;
        }
        if (Math.Abs(BC * BC + AB * AB - AC * AC) < 1e-6)
        {
            hypotenuse = AC;
            return true;
        }
        hypotenuse = double.NaN;
        return false;
    }


    private static double GetLengthOfSide(Point first, Point second)
    {
        double xCoord = first.GetX() - second.GetX();
        double yCoord = first.GetY() - second.GetY();
        return Math.Sqrt(xCoord * xCoord + yCoord * yCoord);
    }
}