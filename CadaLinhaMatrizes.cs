using System;
using System.Globalization;

namespace Matrizes4;
public class Matrizes4
{
    static void Mat4(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        Console.Write("Qual a ordem da matriz? ");
        int N = int.Parse(Console.ReadLine());

        int[,] mat = new int[N, N];

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                mat[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Maior elemento de cada linha: ");
        for (int i = 0; i < N; i++)
        {
            int maior = mat[i, 0];
            for (int j = 0; j < N; j++)
            {
                if (maior < mat[i, j])
                {
                    maior = mat[i, j];
                }
            }
            Console.WriteLine(maior);
        }
    }
}