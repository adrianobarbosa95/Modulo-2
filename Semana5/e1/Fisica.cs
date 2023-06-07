using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semana5.e1
{
    public class Fisica:Cliente
    {
       public int cpf {get; set;}
     public Fisica(int numero, double saldo, string endereco){
        NumeroConta = numero;
        Saldo = saldo;
        Endereco = endereco;
         }

    }
}