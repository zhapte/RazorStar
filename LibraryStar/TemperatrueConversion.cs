using System;

namespace LibraryStar;

public class TemperatrueConversion
{
    public static double CelciusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    public static double FahrenheitToCelcius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
}
