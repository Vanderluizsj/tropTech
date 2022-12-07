using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SerraLinhasAereas.Domain;
using SerraLinhasAereas.Domain.Repository;

namespace SerraLinhasAereas.Infra.Data.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ClienteDAO _clienteDao;
        public ClienteRepository()
        {
            _clienteDao = new ClienteDAO();
        }

        public void AdicionarCliente(Cliente cliente)
        {
            _clienteDao.AdicionarCliente(cliente);
        }

        public Cliente BuscarCliente(long cpfCliente)
        {
            return _clienteDao.BuscarPorCpf(cpfCliente);
        }
        public void AtualizarCliente(long cpfCliente)
        {
            var clienteEncontrado = _clienteDao.BuscarPorCpf(cpfCliente);
            _clienteDao.AtualizarCliente(clienteEncontrado);
        }

        public List<Cliente> BuscarTodosOsClientes()
        {
            return _clienteDao.BuscarTodos();
        }

        public void DeletarCliente(long cpfCliente)
        {
            var clienteEncontrado = _clienteDao.BuscarPorCpf(cpfCliente);

            _clienteDao.DeletarCliente(clienteEncontrado);
        }

    }
}