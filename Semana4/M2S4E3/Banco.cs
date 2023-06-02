using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semana4.M2S4E3
{
    public class Banco
    {
        private decimal Saldo{ get; set; }
        public void  Depositar(decimal valor){
            Saldo+=valor;
            Console.WriteLine("Deposito de: R$ " +valor+"\n"); 
        }
        public void Sacar(decimal valor){
            Saldo-=valor;
            Console.WriteLine("Saque de: R$ " +valor+"\n");  
        }
       public void toString() { Console.WriteLine("Saldo: R$ "+Saldo+"\n");  }  //

    }
    
}