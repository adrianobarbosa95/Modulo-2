using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semana4.M2S4E3
{
    public class Cliente
    {
       private string Nome{ get;}
       private string Cpf{ get;}
         
         public Cliente(string nome, string cpf){
            Nome = nome;
            Cpf = cpf;
         }
         public override string ToString(){
            return $"Nome do Cliente: {Nome}\nCpf: {Cpf}";
         }
    }
}