namespace Semana2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new M2S03E1().soma(3, 5));
            Console.WriteLine(new M2S03E1().soma(3, 5.3));
            Console.WriteLine(new M2S03E1().soma(3, 5, 3.1));

            Proprietario proprietario1 = new Proprietario();
            proprietario1.nome = "Adriano";
            proprietario1.CPF = "04436975896";
            proprietario1.telefone = "071988556654";
            Proprietario proprietario2 = new Proprietario();
            proprietario2.nome = "lucas";
            proprietario2.CPF = "32548599847";
            proprietario2.telefone = "075982055052";
            Proprietario proprietario3 = new Proprietario();
            proprietario3.nome = "Luciana";
            proprietario3.CPF = "302578958554";
            proprietario3.telefone = "07597789851";
            Carro carro1= new Carro("FIAT", "UNO", "PWN8565", "BRANCO", proprietario1 );
            Carro carro2= new Carro("FIAT", "FIESTA", "ORS4588", "BRANCO", proprietario2 );
            Carro carro3= new Carro("FIAT", "STRADA", "SFH4852", "BRANCO", proprietario3 );
            
           
              }
    }
}
