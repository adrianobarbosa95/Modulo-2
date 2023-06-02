using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semana4
{
    public class ContaBancarias
    {
        private int NumeroConta { get; set; }
        private decimal Saldo { get; set; }

        public void deposita(decimal valor)
        {
            Saldo += valor;
        }

        public ContaBancarias(int numeroConta)
        {
            NumeroConta = numeroConta;
        }

        public decimal getSaldo()
        {
            return Saldo;
        }

        public void saca(decimal valor)
        {
            if (valor <= Saldo)
                Saldo -= valor;
            else
            {
                Console.WriteLine("Não foi possivel realizar saque, saldo insuficiente!");
            }
        }
    }
}
