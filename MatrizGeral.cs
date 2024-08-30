using System;
using System.Globalization;

namespace Matrizes7;
public class Matrizes7
{
    static void Main(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        Console.WriteLine("Qual a ordem da matriz? ");
        int N = int.Parse(Console.ReadLine());

        int[,] mat = new int[N, N];

        int soma = 0;
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                mat[i, j] = int.Parse(Console.ReadLine());
                if (mat[i, j] > 0)
                {
                    soma += mat[i, j];
                }
            }
        }
        Console.WriteLine("Soma dos positivos: " + soma);

        Console.Write("Escolha uma linha: ");
        int linha = int.Parse(Console.ReadLine());
        Console.Write("Linha escolhida: ");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (linha == i)
                {
                    Console.Write(mat[i, j] + " ");
                }
            }
        }

        Console.WriteLine();
        Console.Write("Escolha uma coluna: ");
        int coluna = int.Parse(Console.ReadLine());
        Console.Write("Coluna escolhida: ");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (coluna == j)
                {
                    Console.Write(mat[i, j] + " ");
                }
            }
        }

        Console.Write("Diagonal principal: ");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (i == j)
                {
                    Console.Write(mat[i, j].ToString("F1", CI) + " ");
                }
            }
        }

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (mat[i, j] < 0)
                {
                    mat[i, j] = mat[i, j] * mat[i, j];
                }
            }
        }

        Console.Write("Matriz alterada: ");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(mat[i, j] + " ");
            }
            Console.WriteLine();
        }

    }
}