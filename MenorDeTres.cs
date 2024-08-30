using System;
using System.Globalization;

namespace MenorDeTres;
public class MenorDeTres
{
    static void Menor(string[] args)
    {
        Console.Write("Primeiro valor: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Segundo valor: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Terceiro valor: ");
        int c = int.Parse(Console.ReadLine());

        int menor;
        if (a < b && a < c) {
            menor = a;
        } else if (b < c) {
            menor = b;
        } else {
            menor = c;
        }

        Console.Write("Menor valor: " + menor);
    }
}
