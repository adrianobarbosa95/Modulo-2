using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M2S5E2.Interface
{
    public interface IClienteService
    {
     
        void CriarConta();
        Cliente BuscarClientePorNumeroDeConta(int numeroConta);
        void ExibirClientes();
     
    }
}