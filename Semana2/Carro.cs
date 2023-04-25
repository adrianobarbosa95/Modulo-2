using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semana2
{
    public class Carro
    {
        public string Marca;
        public string Modelo;
        public string Placa;
        public string Cor;
        public Proprietario proprietario;

    public Carro(string marca, string modelo, string placa, string cor, Proprietario proprietario)
    {
      Marca = marca;
      Modelo = modelo;
      Placa = placa;
      Cor = cor;
      this.proprietario = proprietario;
    }
  }
}
