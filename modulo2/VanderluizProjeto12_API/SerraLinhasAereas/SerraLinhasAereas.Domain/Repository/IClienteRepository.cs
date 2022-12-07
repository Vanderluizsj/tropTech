using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerraLinhasAereas.Domain.Repository
{
    public interface IClienteRepository
    {
        void AdicionarCliente(Cliente cliente);
        void AtualizarCliente(long cpfCliente);
        void DeletarCliente(long cpfCliente);
        Cliente BuscarCliente(long cpfCliente);
        List<Cliente> BuscarTodosOsClientes();       
    }
}