using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerraLinhasAereas.Domain
{
    public class Passagem
    {
        public int IdPassagem { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public DateTime DataOrigem { get; set; }
        public DateTime DataDestino { get; set; }
        public double Valor { get; set; }

        public Passagem(int idPassagem, string origem, string destino, DateTime dataOrigem, DateTime dataDestino, double valor)
        {
            IdPassagem = idPassagem;
            Origem = origem;
            Destino = destino;
            DataOrigem = dataOrigem;
            DataDestino = dataDestino;
            Valor = valor;
        }
        public Passagem()
        {
            
        }
    }
}