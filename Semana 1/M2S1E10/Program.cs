using System.Data;
using System;

namespace M2S1E10
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "0";
           do
           {
            Console.WriteLine("Escola uma opção:\n1-Adição\n2-Subtração\n3-Multiplicação\n4-Divisão\n0-Sair");
            opcao = Console.ReadLine();
            int numero =0, numero2 = 0;
                switch (opcao)
                {
                    case "1":
                    Console.WriteLine("Digite o Primeiro numero");
                     numero = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo numero");
                     numero2 = int.Parse(Console.ReadLine());
                    adicao(numero, numero2);
                        break;
                    case "2":
                    Console.WriteLine("Digite o Primeiro numero");
                     numero = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo numero");
                     numero2 = int.Parse(Console.ReadLine());
                    subtracao(numero, numero2);
                        break;
                    case "3":
                    Console.WriteLine("Digite o Primeiro numero");
                     numero = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo numero");
                     numero2 = int.Parse(Console.ReadLine());
                    multiplicacao(numero, numero2);
                        break;
                    case "4":
                    Console.WriteLine("Digite o Primeiro numero");
                     numero = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo numero");
                     numero2 = int.Parse(Console.ReadLine());
                    divisao(numero, numero2);
                        break;
                    case "0":
                    Console.WriteLine("Obrigado por usar a calculadora!");
                        break;
                    default:
                    Console.WriteLine("Digito invalido!");
                        break;
                }
                
           } while (opcao != "0");
        }

      public static void adicao(int numero, int numero2 ){
        
         Console.WriteLine(numero + numero2);
      }
      public static void subtracao(int numero, int numero2 ){
          Console.WriteLine(numero - numero2);
      }
      public static void multiplicacao(int numero, int numero2 ){
         Console.WriteLine(numero * numero2);
      }
      public static void divisao(int numero, int numero2 ){
        if(numero2 == 0) {Console.WriteLine("Numero não pode ser 0");}
             else{Console.WriteLine(numero / numero2);}
      }
    }
}
