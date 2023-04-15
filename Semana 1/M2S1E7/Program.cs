
using System.Data;
using System.Collections.Generic;
using System.Collections;
using System;
// Declare uma variável do tipo string chamada "frase" e atribua a ela a seguinte frase: "A linguagem de programação C# é muito poderosa".

// Em seguida,  crie uma lista de string chamada palavras e separe as palavras em cada posição da lista.

// Depois, exiba apenas a palavra "poderosa" na tela.
namespace M2S1E6
{
    class Program
    {
        static void Main(string[] args)
        {
          
         
             
int numero;
       do
       {
        Console.WriteLine("Digite um numero inteiro maior que zero ");
         numero = int.Parse(Console.ReadLine());
           
       } while (numero<=0);
 for (int i = 0; i <= numero; i+=2)
 {
    Console.WriteLine(i);
 }
        }
    }
}
