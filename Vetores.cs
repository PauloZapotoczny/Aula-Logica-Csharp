using System;
using System.Globalization;

namespace Vetores;
public class Vetores
{
    static void Vet(string[] args)
    {
        Console.Write("Quantos numeros serão digitados? ");
        int N = int.Parse(Console.ReadLine());

        int[] vet = new int[N];

        for (int i = 0; i < N; i++)
        {
            Console.Write("Digite um número: ");
            vet[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        Console.WriteLine("NUMEROS DIGITADOS: ");
        for (int i = 0; i < N; i++)
        {
            Console.Write(vet[i] + " ");
        }
    }
}