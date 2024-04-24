using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {

        double raio, raioQuadrado, pi, area;

        pi = 3.14159;
        raio= double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        raioQuadrado = (Math.Pow(raio, 2));

        area = pi * raioQuadrado;

        Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));

        Console.Read();
        

    }

}