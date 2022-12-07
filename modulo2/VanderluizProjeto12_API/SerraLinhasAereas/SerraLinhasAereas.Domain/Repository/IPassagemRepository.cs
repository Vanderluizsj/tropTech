using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerraLinhasAereas.Domain.Repository
{
    public interface IPassagemRepository
    {
        void AdicionarPassagem(Passagem passagem);
        void AlterarPassagem(int idPpassagem);
        void DeletarPassagem(int ID_PASSAGEM);
        Passagem BuscarPassagem(int ID_PASSAGEM);
        void BuscarTodasAsPassagens(); 
    }
}