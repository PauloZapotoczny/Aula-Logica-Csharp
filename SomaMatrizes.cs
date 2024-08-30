using System;
using System.Globalization;

namespace Matrizes5;
public class Matrizes5
{
    static void Mat5(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        Console.Write("Quantas linhas terão cada matriz? ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Quantas colunas terão cada matriz? ");
        int M = int.Parse(Console.ReadLine());

        int[,] mat1 = new int[N, M];
        int[,] mat2 = new int[N, M];
        int[,] matsoma = new int[N, M];

        Console.WriteLine("Digite os valores da matriz A: ");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                mat1[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Digite os valores da matriz B: ");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                mat2[i, j] = int.Parse(Console.ReadLine());
                matsoma[i, j] = mat1[i, j] + mat2[i, j];
            }
        }

        Console.WriteLine("MATRIZ DA SOMA: ");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                Console.Write(matsoma[i,j] + " ");
            }
            Console.WriteLine();
        }

    }
}