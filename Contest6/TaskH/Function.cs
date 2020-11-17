using System;

public abstract class Function
{
    public static Function GetFunction(string functionName)
    {
        switch (functionName)
        {
            case "Sin":
                {
                    return new Sin();
                }
            case "Exp":
                {
                    return new Exponent();
                }
            case "Parabola":
                {
                    return new Parabola();
                }
            default:
                {
                    throw new ArgumentException("Incorrect input");
                }
        }
    }

    public abstract double GetValueInX(double x);

    public static double SolveIntegral(Function func, double left, double right, double step)
    {
        if (func is Exponent && (Math.Abs(left) < 1e-8 || Math.Abs(right) < 1e-8) 
            || func is Sin && Math.Abs(left/Math.PI - (int)(left/Math.PI)) < 1e-8 
            || Math.Abs(right/Math.PI - (int)(right/Math.PI)) < 1e-8)
        {
            throw new ArgumentException("Function is not defined in point");
        }

        if (left > right)
        {
            throw new ArgumentException("Left border greater than right");
        }

        double result = 0;
        while (left < right)
        {
            double x1 = left;
            double x2 = Math.Min(x1 + step, right);
            double a = func.GetValueInX(x1);
            double b = func.GetValueInX(x2);
            result += (a + b) / 2 * (x2-x1);
            left = x2;
        }

        return result;
    }
}
