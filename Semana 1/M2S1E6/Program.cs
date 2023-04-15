
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
          
         
             string frase = "A linguagem de programação C# é muito poderosa";
            List<string> palavras = new List<string>(frase.Split(' '));

           foreach (var item in palavras)
           {
            if(item=="poderosa") Console.WriteLine("poderosa");
           }
 
        }
    }
}
