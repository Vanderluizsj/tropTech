using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SerraLinhasAereas.Domain;
using SerraLinhasAereas.Domain.Repository;

namespace SerraLinhasAereas.Infra.Data.Repository
{
    public class PassagemRepository : IPassagemRepository
    {
        private readonly PassagemDAO _passagemDao;
        public PassagemRepository()
        {
            _passagemDao = new PassagemDAO();
        }

        public void AdicionarPassagem(Passagem passagem)
        {
            _passagemDao.AdicionarPassagem(passagem);
        }

        public Passagem BuscarPassagem(int idPassagem)
        {
            return _passagemDao.BuscarPorId(idPassagem);
        }
        public void AlterarPassagem(int idPassagem)
        {
            var passagemEncontrada = _passagemDao.BuscarPorId(idPassagem);
            _passagemDao.AtualizarPassagem(passagemEncontrada);
        }

        public void BuscarTodasAsPassagens()
        {
            _passagemDao.BuscarTodos();
        }

        public void DeletarPassagem(int idPassagem)
        {
            var passagemEncontrada = _passagemDao.BuscarPorId(idPassagem);

            _passagemDao.DeletarPassagem(passagemEncontrada);
        }
    }
}