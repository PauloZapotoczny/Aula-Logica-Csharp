using System;
using System.Globalization;

namespace Matrizes6;
public class Matrizes6
{
    static void Mat6(string[] args)
    { 
        Console.Write("Qual a ordem da matriz? ");
        int N = int.Parse(Console.ReadLine());

        int[,] mat = new int[N, N];

        int soma = 0;
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                mat[i, j] = int.Parse(Console.ReadLine());
                if (i < j)
                {
                    soma += mat[i, j];
                }
            }
        }
        Console.WriteLine("Soma dos elementos acima da diagonal principal: " + soma);
    }
}