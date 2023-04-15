using System;
// Crie um programa que leia 4 números e faça a ordenação entre eles.
// Passo a passo:
// Declare um array de inteiros chamado "numeros", que vai armazenar os 4 números digitados pelo usuário;
// Com o laço for peça que o usuário digite cada um dos 4 números, armazenando-os no array "numeros" através da posição i;
// Use o método Sort da classe Array para ordenar o array "numeros" em ordem crescente;
// Imprima os números ordenados na tela, usando um novo laço for.
namespace M2S1E5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[4];
            for(int i=0; i<4; i++){
            Console.WriteLine("Digite um numero "+(i+1)+":");
            numeros[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numeros);
            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }
        }
    }
}
