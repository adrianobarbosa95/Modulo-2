using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semana4.M2S4E3
{
    public class ContaBancaria
    {
        private int Numero { get;}
         private Cliente cliente;
         private Banco banco;
         public ContaBancaria(int numero, Cliente client){
            Numero = numero;
            cliente = client;
            banco = new Banco();
         }
         public string ExibirDados(){
            // Console.WriteLine($"Numero da conta: {Numero}\nNome do Cliente: {cliente.ToString()}");
            return $"Numero da conta: {Numero}\n{cliente.ToString()}";
         }
         public new void ToString(){
             Console.WriteLine(ExibirDados());
             banco.toString();
         }
         public void Depositar(decimal valor){
            banco.Depositar(valor);
         }
         public void Sacar(decimal valor){
            banco.Sacar(valor);
         }
    }
}