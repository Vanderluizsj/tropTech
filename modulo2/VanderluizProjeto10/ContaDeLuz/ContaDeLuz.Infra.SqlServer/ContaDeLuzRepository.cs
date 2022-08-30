using ContaDeLuz.Domain;
using ContaDeLuz.Domain.Repositories;
using ContaDeLuz.Infra.SqlServer.DAO;
using System;
using System.Collections.Generic;

namespace ContaDeLuz.Infra.SqlServer
{
    public class ContaDeLuzRepository : IContaDeLuzRepository
    {
        private readonly ContaDeLuzDAO _contaDeLuzDAO;
        private readonly ContaLuz _conta;
        public ContaDeLuzRepository()
        {
            _contaDeLuzDAO = new ContaDeLuzDAO();
            _conta = new ContaLuz();
        }
        public List<ContaLuz> BuscarTodos()
        {
            return _contaDeLuzDAO.BuscarTodos();
        }       
        public ContaLuz BuscarPorNumeroFatura(int numero, ContaLuz conta)
        {            
            return conta = _contaDeLuzDAO.BuscarPorNumeroFatura(numero);
        }
        public void Cadastrar(ContaLuz contaLuz)
        {            
            _contaDeLuzDAO.AdicionarConta(contaLuz);

        }
        public void Modificar(ContaLuz contaLuz)
        {
            _contaDeLuzDAO.AtualizarConta(contaLuz); 
        }
        public void Apagar(ContaLuz contaLuz)
        {            
            _contaDeLuzDAO.DeletarConta(contaLuz);  
        }
        public void ApagarTudo()
        {
            _contaDeLuzDAO.DeletarTodasAsFaturas();  
        }
    }
}