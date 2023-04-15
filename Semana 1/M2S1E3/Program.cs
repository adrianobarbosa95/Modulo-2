using System;

namespace M2S1E3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do paciente:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a idade do paciente:");
            int idade = int.Parse(Console.ReadLine());
            if(idade > 0 && idade < 18){
 Console.WriteLine($"{nome} É MENOR DE IDADE");
} else if(idade >= 18 && idade < 60){
 Console.WriteLine($"{nome} É ADULTO");
}else if(idade>64){
 Console.WriteLine($"{nome} É IDOSO");
}
       
        }
    }
}
