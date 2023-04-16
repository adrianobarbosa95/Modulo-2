using System.Collections;
using System.ComponentModel;
using System;

namespace M2S1E9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade");
            int quantidade = int.Parse(Console.ReadLine());

            int[] numeros = new int[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                 Console.WriteLine($"Digite um numero inteiro ({i})");
                  numeros[i] = int.Parse(Console.ReadLine());

            }
            int soma = 0;
            foreach (var item in numeros)
            {

                soma+=item;
            }
            double media = soma/quantidade;
                Console.WriteLine($"A media eh {media}");
        }
    }
}
