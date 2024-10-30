using System.Security.Cryptography.X509Certificates;

public static class ConversorTemperatura
{
    public static double CelsiusParaFahrenheint(double celsius)
    {
        return(celsius * 9/5) + 32;
    }

    public static double FahrenheintParaCelsius(double fahrenheint)
    {
        return (fahrenheint - 32) * 5/9;
    }
}