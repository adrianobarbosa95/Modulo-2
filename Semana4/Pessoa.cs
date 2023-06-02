using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semana4
{
    public class Pessoa
    {
        private string Nome { get; set; }
        protected int Idade { get; set; }
        private string Endereco { get; }

        public void saudacao()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e eu tenho {Idade} anos");
        }

        public Pessoa(string nome, int idade, string endereco)
        {
            Nome = nome;
            Idade = idade;
            Endereco = endereco;
        }
    }
}
