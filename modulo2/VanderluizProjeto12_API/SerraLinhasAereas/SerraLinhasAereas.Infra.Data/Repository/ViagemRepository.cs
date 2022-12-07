using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SerraLinhasAereas.Domain;
using SerraLinhasAereas.Domain.Repository;

namespace SerraLinhasAereas.Infra.Data.Repository
{
    public class ViagemRepository : IViagemRepository
    {
        private readonly ViagemDAO _viagemDao;
        public ViagemRepository()
        {
            _viagemDao = new ViagemDAO();
        }

        public void AdicionarViagem(Viagem viagem)
        {
            _viagemDao.AdicionarViagem(viagem);
        }

        public Viagem BuscarViagem(string codigoReserva)
        {
            return _viagemDao.BuscarPorCodigo(codigoReserva);
        }
        public void AlterarViagem(string codigoReserva)
        {
            var viagemEncontrada = _viagemDao.BuscarPorCodigo(codigoReserva);
            _viagemDao.AtualizarViagem(viagemEncontrada);
        }

        public void BuscarTodasAsViagens()
        {
            _viagemDao.BuscarTodos();
        }

        public void DeletarViagem(string codigoReserva)
        {
            var viagemEncontrada = _viagemDao.BuscarPorCodigo(codigoReserva);

            _viagemDao.DeletarViagem(viagemEncontrada);
        }
    }
}