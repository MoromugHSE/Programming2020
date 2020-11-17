using System;

public class Exponent : Function
{
    public override double GetValueInX(double x)
    {
        return Math.Exp(1 / x);
    }
}
