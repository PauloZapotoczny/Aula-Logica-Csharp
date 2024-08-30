using System;
using System.Globalization;

namespace SomaImpares;
public class SomaImpares
{
    static void Impares(string[] args)
    {
        //Um programa para somar os numeros impares entre um numero e outro
        Console.WriteLine("Digite dois numeros: ");
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        if (x > y)
        {
            int troca = x;
            x = y;
            y = troca;
        }

        int soma = 0;
        for (int i = x; i < y; i++)
        {
            if (i % 2 != 0)
            {
                soma = soma + i;
            }
        }

        Console.WriteLine("SOMA DOS IMPARES: " + soma);
    }
}