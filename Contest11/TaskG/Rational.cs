using System;

public class Rational
{
    int numerator;
    int denomenator;

    public Rational(int numerator, int denomenator)
    {
        if (denomenator < 0)
        {
            numerator = -numerator;
            denomenator = -denomenator;
        }
        int gcd = FindGcd(Math.Abs(numerator), denomenator);
        numerator /= gcd;
        denomenator /= gcd;
        this.numerator = numerator;
        this.denomenator = denomenator;
    }

    public static int FindGcd(int a, int b)
    {
        while (a != 0 && b != 0)
        {
            b %= a;
            a ^= b;
            b ^= a;
            a ^= b;
        }

        return a + b;
    }

    public static Rational operator +(Rational a, Rational b)
    {
        int denomenator = a.denomenator * b.denomenator;
        int numerator = a.numerator * b.denomenator + b.numerator * a.denomenator;
        return new Rational(numerator, denomenator);
    }

    public static Rational operator -(Rational a, Rational b)
    {
        int denomenator = a.denomenator * b.denomenator;
        int numerator = a.numerator * b.denomenator - b.numerator * a.denomenator;
        return new Rational(numerator, denomenator);
    }

    public static Rational operator *(Rational a, Rational b)
    {
        int denomenator = a.denomenator * b.denomenator;
        int numerator = a.numerator * b.numerator;
        return new Rational(numerator, denomenator);
    }

    public static Rational operator /(Rational a, Rational b)
    {
        int denomenator = a.denomenator * b.numerator;
        int numerator = a.numerator * b.denomenator;
        return new Rational(numerator, denomenator);
    }

    public static Rational Parse(string input)
    {
        Rational rational;
        if (input.Contains('/'))
        {
            var splitted = input.Split('/');
            rational = new Rational(int.Parse(splitted[0]),
                int.Parse(splitted[1]));
        }
        else
        {
            rational = new Rational(int.Parse(input), 1);
        }

        return rational;
    }

    public override string ToString()
    {
        if (denomenator == 1)
            return numerator.ToString();
        return numerator + "/" + denomenator;
    }
}