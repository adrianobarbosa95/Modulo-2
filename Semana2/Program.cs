namespace Semana2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Carro> carros = new List<Carro>();
            // Console.WriteLine(new M2S03E1().soma(3, 5));
            // Console.WriteLine(new M2S03E1().soma(3, 5.3));
            // Console.WriteLine(new M2S03E1().soma(3, 5, 3.1));

            // Proprietario proprietario1 = new Proprietario();
            // proprietario1.Nome = "Adriano";
            // proprietario1.CPF = "04436975896";
            // proprietario1.Telefone = "071988556654";
            // Proprietario proprietario2 = new Proprietario();
            // proprietario2.Nome = "lucas";
            // proprietario2.CPF = "32548599847";
            // proprietario2.Telefone = "075982055052";
            // Proprietario proprietario3 = new Proprietario();
            // proprietario3.Nome = "Luciana";
            // proprietario3.CPF = "302578958554";
            // proprietario3.Telefone = "07597789851";
            // Carro carro1 = new Carro("FIAT", "UNO", "PWN8565", "BRANCO", proprietario1);
            // Carro carro2 = new Carro("FIAT", "FIESTA", "ORS4588", "BRANCO", proprietario2);
            // Carro carro3 = new Carro("FIAT", "STRADA", "SFH4852", "BRANCO", proprietario3);


            // carros.Add(carro1);
            // carros.Add(carro2);
            // carros.Add(carro3);
            void cadastrarCarro()
            {
                string Nome;
                string CPF;
                string Telefone;
                string Marca;
                string Modelo;
                string Placa;
                string Cor;

                Console.WriteLine("Digite o nome do proprietario");
                Nome = Console.ReadLine();
                Console.WriteLine("Digite o CPF do proprietario");
                CPF = Console.ReadLine();
                Console.WriteLine("Digite o telefone do proprietario");
                Telefone = Console.ReadLine();
                Console.WriteLine("Digite o marca do carro");
                Marca = Console.ReadLine();
                Console.WriteLine("Digite o modelo do carro");
                Modelo = Console.ReadLine();
                Console.WriteLine("Digite a placa do carro");
                Placa = Console.ReadLine();
                Console.WriteLine("Digite a cor do carro");
                Cor = Console.ReadLine();

                carros.Add(
                    new Carro(Marca, Modelo, Placa, Cor, new Proprietario(Nome, CPF, Telefone))
                );
            }

            void exibir()
            {
                foreach (Carro carro in carros)
                {
                    Console.WriteLine(
                        $"{carro.Marca} {carro.Modelo} {carro.Placa} {carro.Cor} {carro.proprietario.ToString()}"
                    );
                }
            }
            int escolha = 0;
            do
            {
                Console.WriteLine("Escolha a opção desejada:");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                  case 1:
                   cadastrarCarro();
                    break;
                   case 2:
                    exibir();
                    break;
                   case 3:
                    Console.WriteLine("SAINDO DO SISTEMA!");
                    break;
                  default:
                   Console.WriteLine("OPÇÃO INVALIDA, TENTE NOVAMENTE!");
                    break;
                }
                
            } while (escolha != 3);
           
           
        }
    }
}
