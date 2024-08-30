using System;
using System.Globalization;

namespace Matrizes1;
public class Matrizes1
{
    static void Main(string[] args)
    {
        Console.Write("Qual a ordem da matriz? ");
        int N = int.Parse(Console.ReadLine());

        int[ , ] mat = new int[N, N];

        int negativos = 0;
        for (int i = 0; i < N; i++) { 
            for (int j = 0; j < N; j++) {
                Console.Write($"Elemento [{i}, {j}]: ");
                mat[i, j] = int.Parse(Console.ReadLine());
                if (mat[i, j] < 0)
                {
                    negativos++;
                }
            }
        }

        Console.WriteLine("Diagonal principal: ");
        for (int i = 0; i < N; i++)
        { for (int j = 0; j < N; j++)
            {
                if (i == j)
                {
                    Console.Write(mat[i, j] +  " ");
                }
            }
        }

        Console.Write("Quantidade de negativos: " + negativos);
    }
}