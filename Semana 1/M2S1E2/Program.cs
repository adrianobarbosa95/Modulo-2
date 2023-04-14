using System;

namespace M2S1E2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero inteiro");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine((numero % 2 == 0) ? "É par" : "é impar");
        }
    }
}
