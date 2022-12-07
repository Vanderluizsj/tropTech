using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PublicacaoController : ControllerBase
    {
        public List<Publicacao> listaPublicacao = new List<Publicacao>(){
            new Publicacao(1, "Eleições", Convert.ToDateTime("10/09/2022"), "Luiz", 0),
            new Publicacao(2, "Inflação", Convert.ToDateTime("10/09/2022"), "João", 0),
            new Publicacao(3, "Saude", Convert.ToDateTime("10/09/2022"), "Carlos", 0),
            new Publicacao(4, "Escolas", Convert.ToDateTime("10/09/2022"), "Ana", 0),            
        };
        [HttpGet]
        public List<Publicacao> Get(){
            return listaPublicacao;
        }
        [HttpGet]
        [Route("{id}")]
        public Publicacao GetById(int id){
            var publicacaoBuscada = listaPublicacao.Find(publicacao => publicacao.Id == id);
            return publicacaoBuscada;
        }
        [HttpGet("Curtir/{id}")]
        //[Route("Curtir")]
        public Publicacao LikeById(int id){
            var publicacaoBuscada = listaPublicacao.Find(publicacao => publicacao.Id == id);
            publicacaoBuscada.Curtir();
            return publicacaoBuscada;
        }

        [HttpPost]
        public List<Publicacao> Post([FromBody]Publicacao novPublicacao)
        {
            listaPublicacao.Add(novPublicacao);

            return listaPublicacao;
        }

        [HttpPut]
        public List<Publicacao> Put([FromBody]Publicacao publicacaoEditada)
        {
            var publicacaoBuscada = listaPublicacao.Find(publicacao => publicacao.Id == publicacaoEditada.Id);
            
            publicacaoBuscada.Titulo = publicacaoEditada.Titulo;
            
            return listaPublicacao;
        }

        [HttpDelete]
        public List<Publicacao> Delete([FromBody]Publicacao publicacaoRemovida)
        {
            var publicacaoBuscada = listaPublicacao.Find(publicacao => publicacao.Id == publicacaoRemovida.Id);
            
            listaPublicacao.Remove(publicacaoBuscada);
            
            return listaPublicacao;
        }
    }
}