using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semana4.M2S4E5
{
    public class Pessoa
    {
        private string Nome { get; set; }
        private int idade;

        public int Idade { 
            get{ return idade; }
            set{idade = value; }
            }
            public void DefinirIdade(int idade)
        {
            if (idade >= 0)
            {
                Idade = idade;
            }
        }
    }
}
