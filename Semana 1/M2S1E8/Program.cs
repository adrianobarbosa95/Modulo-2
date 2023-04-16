using System;

namespace M2S1E8
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] numeros = new int[5];
           int maior=0;
           for (int i = 0; i < 5; i++)
           {
            Console.WriteLine("digite um numero interio");
            numeros[i] = int.Parse(Console.ReadLine());
            //poderia pegar o maior aqui
            if(i==0) maior = numeros[i];
            maior = (numeros[i] > maior) ? numeros[i] : maior;
           }
           Console.WriteLine(maior);        
        }

    }
}
