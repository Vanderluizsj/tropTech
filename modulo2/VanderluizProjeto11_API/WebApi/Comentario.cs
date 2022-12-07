using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi
{
    public class Comentario
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataComentario { get; set; }
        public string NomeUsuario { get; set; }
        public int QtdCurtidas { get; set; }
        public int IdPublicacaoComentada { get; set; }

        public Comentario(int id, string descricao, DateTime dataComentario, string nomeUsuario, int qtdCurtidas, int idPublicacaoComentada)
        {
            this.Id = id;
            this.Descricao = descricao;
            this.DataComentario = dataComentario;
            this.NomeUsuario = nomeUsuario;
            this.QtdCurtidas = qtdCurtidas;
            this.IdPublicacaoComentada = idPublicacaoComentada;
        }
    }
}