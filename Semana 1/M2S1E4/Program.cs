 
using System;
// Faça um programa que leia a Marca, Modelo e  km rodados e mostre as informações do 
// carro e se a KM for acima 10 mil, apresentar a mensagem que precisa ser feito uma revisão.
namespace M2S1E4
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Digite a marca do carro:");
        string marca = Console.ReadLine();
        Console.WriteLine("Digite o Modelo do carro:");
        string modelo = Console.ReadLine();
        Console.WriteLine("Digite o km rodados do carro:");
        float km = float.Parse(Console.ReadLine());
        Console.WriteLine($"O carro da {marca}, modelo {modelo} tem {km}km rodados!");
        if(km > 10000) Console.WriteLine("Precisa ser feito uma revisão");
        }
    }
}
