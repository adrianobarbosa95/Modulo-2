using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semana4.M2S4E4
{
    public class ContaBancaria
    {
        private decimal Saldo { get; set; }

        public void deposita(decimal valor)
        {
            if (valor >= 0)
            {

                Saldo += valor;
                Console.WriteLine("Sucesso, saldo atual: " + Saldo);
            }
            else
                Console.WriteLine("Divite valor maior que 0");
        }
        public Boolean saca(decimal valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
