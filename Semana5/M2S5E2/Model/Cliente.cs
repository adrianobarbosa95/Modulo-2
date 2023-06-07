using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M2S5E2
{
    public class Cliente
    {
          protected int NumeroConta { get; set; }
        protected double Saldo { get; set; }
        protected string Endereco { get; set; }
        protected int idade { get; set; }
        public void ResumoCliente() {
            Console.WriteLine($"NumeroConta: {NumeroConta}, Saldo: {Saldo}, Endereço: {Endereco}");
         }
    }
}