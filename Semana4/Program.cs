using Semana4.M2S4E3;

namespace Semana4
{
class Program
{
  public static void Main(string[] args)
  {
    // new Pessoa("Adriano",28, "Rua Uziel").saudacao();
    // ContaBancarias cb = new ContaBancarias(12345);
    // cb.deposita(200);
    // cb.saca(250);
    // Console.WriteLine($"{cb.getSaldo()}");
 ContaBancaria contabancaria = new ContaBancaria(123, new Cliente("Adriano Barbosa", "04432900000"));

contabancaria.ToString();
contabancaria.Depositar(50);
contabancaria.ToString();
contabancaria.Sacar(30);
contabancaria.ToString();
  }
}
}