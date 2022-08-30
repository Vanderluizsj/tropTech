using System.Collections.Generic;

namespace ContaDeLuz.Domain.Repositories
{
    public interface IContaDeLuzRepository
    {
        List<ContaLuz> BuscarTodos();
        void Cadastrar(ContaLuz contaLuz);
    }
}