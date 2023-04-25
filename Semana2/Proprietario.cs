namespace Semana2
{
    public class Proprietario
    {
        public string Nome;
        public string CPF;
        public string Telefone;
public Proprietario(){}
    public Proprietario(string nome, string cpf, string telefone)
    {
      Nome = nome;
      CPF = cpf;
      Telefone = telefone;
    }
    override public string ToString(){
       return $"Nome: {Nome} CPf: {CPF} Telefone: {Telefone}";
    }
    
  }
}
