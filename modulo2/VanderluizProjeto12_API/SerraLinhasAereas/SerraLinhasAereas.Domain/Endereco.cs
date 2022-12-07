using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerraLinhasAereas.Domain
{
    public struct Endereco
    {
        public string Rua { get; set; }
        public string Cep { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }

        public Endereco(string rua, string cep, int numero, string bairro, string complemento)
        {
            this.Rua=rua;
            this.Cep=cep;
            this.Numero=numero;
            this.Bairro=bairro;
            this.Complemento=complemento;
        }
        public string Completo{
            get
            {
                return $"Endereço: {Bairro}, {Rua}, {Numero} - {Complemento} - {Cep}";
            }
        }

    }
}