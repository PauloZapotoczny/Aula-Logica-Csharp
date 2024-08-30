using System;
using System.Globalization;

namespace SomaVetor;
public class SomaVetor
{
    static void Vetor1(string[] args)
    {
        Console.WriteLine("Quantos numeros você vai digitar? ");
        int N = int.Parse(Console.ReadLine());

        double[] vet = new double[N];

        double soma = 0;
        for (int i = 0; i < N; i++)
        {
            Console.Write("Digite um numero: ");
            vet[i] = double.Parse(Console.ReadLine());
            soma = soma + vet[i];
        }

        Console.Write("Valores: ");
        for (int i = 0; i < N; i++)
        {
            Console.Write(vet[i] + " ");
        }

        Console.Write("Soma: " + soma);

        double media = soma / N;
        Console.WriteLine("Media: " + media);
    }
}