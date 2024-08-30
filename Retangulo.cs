using System;
using System.Globalization;

namespace Retangulo;
public class Retangulo
{
    static void Ret(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        Console.WriteLine("Base do retangulo: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Altura do retangulo: ");
        double a = double.Parse(Console.ReadLine());

        double area = a * b;
        double perimetro = (a * 2) + (b * 2);
        double diagonal = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

        Console.WriteLine("AREA = " + area);
        Console.WriteLine("PERIMETRO = " + perimetro);
        Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CI));

    }
}