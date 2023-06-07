using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M2S5E2
{
    public class PessoaFisica : Cliente
    {
        protected int cpf { get; set; }
       public bool ehMaior(){
        return idade<18;
       }
    }
}