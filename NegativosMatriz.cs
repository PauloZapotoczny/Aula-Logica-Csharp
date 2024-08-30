using System;
using System.Globalization;

namespace Matrizes3;
public class Matrizes3
{
    static void Mat3(string[] args)
    {
        Console.Write("Quantas linhas serão digitados? ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Quantas colunas serão digitadas? ");
        int M = int.Parse(Console.ReadLine());

        int[,] mat = new int[N, M];

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                mat[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Valores negativos: ");
        for (int i = 0; i < N; i++)
        { for (int j = 0;j < M; j++)
            {
                if (mat[i, j] < 0)
                {
                    Console.WriteLine(mat[i,j]);
                }
            }

        }
    }
}