using System;

namespace M2S1E1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro numero inteiro");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero inteiro");
            int numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine(numero1+numero2);
        }
    }
}
