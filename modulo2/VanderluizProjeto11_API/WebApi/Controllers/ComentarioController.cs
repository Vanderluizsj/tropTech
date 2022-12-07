using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ComentarioController : ControllerBase
    {
         public List<Comentario> listaComentario = new List<Comentario>(){
            new Comentario(1, "Eleições 2022", Convert.ToDateTime("10/09/2022"), "João", 5, 1),
            new Comentario(1, "Inflação 2022", Convert.ToDateTime("10/09/2022"), "Luiz", 3, 2),
            new Comentario(1, "Escolas de periferia", Convert.ToDateTime("10/09/2022"), "João", 15, 4),
            new Comentario(1, "Saude na infancia", Convert.ToDateTime("10/09/2022"), "João", 5, 3),
        };
        [HttpGet]
        public List<Comentario> Get(){
            return listaComentario;
        }
        [HttpGet]
        [Route("{id}")]
        public Comentario GetById(int id){
            var comentarioBuscado = listaComentario.Find(comentario => comentario.Id == id);
            return comentarioBuscado;
        }
        [HttpPost]
        public List<Comentario> Post([FromBody]Comentario novoComentario)
        {
            listaComentario.Add(novoComentario);

            return listaComentario;
        }

        [HttpPut]
        public List<Comentario> Put([FromBody]Comentario comentarioEditado)
        {
            var comentarioBuscado = listaComentario.Find(comentario => comentario.Id == comentarioEditado.Id);
            
            comentarioBuscado.Descricao = comentarioEditado.Descricao;
            
            return listaComentario;
        }

        [HttpDelete]
        public List<Comentario> Delete([FromBody]Comentario comentarioRemovido)
        {
            var comentarioBuscado = listaComentario.Find(comentario => comentario.Id == comentarioRemovido.Id);
            
            listaComentario.Remove(comentarioBuscado);
            
            return listaComentario;
        }

    }
}