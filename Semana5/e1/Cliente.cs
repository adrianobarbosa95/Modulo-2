using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semana5.e1
{
    public abstract class Cliente
    {
        protected int NumeroConta { get; set; }
        protected double Saldo { get; set; }
        protected string Endereco { get; set; }
        public void ResumoCliente() {
            Console.WriteLine($"NumeroConta: {NumeroConta}, Saldo: {Saldo}, Endereço: {Endereco}");
         }
         public Cliente(int numero, double saldo, string endereco){
                NumeroConta = numero;
                Saldo = saldo;
                Endereco = endereco;
         }
    }
}
