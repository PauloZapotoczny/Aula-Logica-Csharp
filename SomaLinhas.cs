using System;
using System.Globalization;

namespace Matrizes2;
public class Matrizes2
{
    static void Mat2(string[] args)
    {
        Console.WriteLine("Qual a quantidade de linhas da matriz? ");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Qual a quantidade de colunas da matriz? ");
        int M = int.Parse(Console.ReadLine());

        double[,] mat = new double[N, M];
        double[] vet = new double[N];

        double soma;
        for (int i = 0; i < N; i++) 
        {
            soma = 0;
            Console.WriteLine($"Digite os elementos da {i + 1}a linha: ");
            for (int j = 0; j < M; j++)
            {
                mat[i,j] = double.Parse(Console.ReadLine());
                soma += mat[i,j];
            }
            vet[i] = soma;
        }

        Console.WriteLine("VETOR GERADO: ");
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine(vet[i]);
        }

    }
}