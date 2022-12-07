using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi
{
    public class Publicacao
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string NomeUsuario { get; set; }
        public int QtdCurtidas { get; set; }

        public Publicacao(int id, string titulo, DateTime dataPublicacao, string nomeUsuario, int qtdCurtidas)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.DataPublicacao = dataPublicacao;
            this.NomeUsuario = nomeUsuario;
            this.QtdCurtidas = qtdCurtidas;
        }
        public void Curtir(){
            QtdCurtidas+=1;
        }
    }
}