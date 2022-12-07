using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerraLinhasAereas.Domain.Repository
{
    public interface IViagemRepository
    {
        void AdicionarViagem(Viagem viagem);
        void AlterarViagem(string codigoViagem);
        void DeletarViagem(string codigoReserva);
        Viagem BuscarViagem(string codigoReserva);
        void BuscarTodasAsViagens(); 
    }
}