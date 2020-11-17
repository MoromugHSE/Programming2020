using System;

public static class TemperatureCalculator
{
    public static double FromCelsiusToFahrenheit(double celsiusTemperature)
    {
        if (celsiusTemperature < -273.15)
        {
            throw new ArgumentException("Incorrect input");
        }
        return 1.8 * celsiusTemperature + 32;
    }

    public static double FromCelsiusToKelvin(double celsiusTemperature)
    {
        if (celsiusTemperature < -273.15)
        {
            throw new ArgumentException("Incorrect input");
        }
        return celsiusTemperature + 273.15;
    }

    public static double FromFahrenheitToCelsius(double fahrenheitTemperature)
    {
        if (fahrenheitTemperature < -459.67)
        {
            throw new ArgumentException("Incorrect input");
        }
        return (fahrenheitTemperature - 32) / 1.8;
    }

    public static double FromFahrenheitToKelvin(double fahrenheitTemperature)
    {
        if (fahrenheitTemperature < -459.67)
        {
            throw new ArgumentException("Incorrect input");
        }
        double celciusTemperature = FromFahrenheitToCelsius(fahrenheitTemperature);
        return FromCelsiusToKelvin(celciusTemperature);
    }

    public static double FromKelvinToCelsius(double kelvinTemperature)
    {
        if (kelvinTemperature < 0)
        {
            throw new ArgumentException("Incorrect input");
        }
        return kelvinTemperature - 273.15;
    }

    public static double FromKelvinToFahrenheit(double kelvinTemperature)
    {
        if (kelvinTemperature < 0)
        {
            throw new ArgumentException("Incorrect input");
        }
        double celciusTemperature = FromKelvinToCelsius(kelvinTemperature);
        return FromCelsiusToFahrenheit(celciusTemperature);
    }

}
