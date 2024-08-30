using System;
using System.Globalization;

namespace Matrizes;
public class Matrizes
{
    static void Mat(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        Console.Write("Quantas linhas serão digitados? ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Quantas colunas serão digitadas? ");
        int M = int.Parse(Console.ReadLine());

        int[,] mat = new int[N,M];

        for (int i = 0; i < N; i++)
        { for (int j = 0; j < M; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                mat[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine();
        Console.WriteLine("NUMEROS DIGITADOS: ");
        for (int i = 0; i < N; i++)
        { for (int j = 0; j < M; j++)
            {
                Console.Write(mat[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}