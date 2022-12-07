using System;
using Microsoft.AspNetCore.Mvc;
using SerraLinhasAereas.Domain;
using SerraLinhasAereas.Domain.Repository;
using SerraLinhasAereas.Infra.Data;
using SerraLinhasAereas.Infra.Data.Repository;

namespace SerraLinhasAereas.WebApi.Controllers
{
    [ApiController]
    [Route("api/passagem")]
    public class PassagemController : ControllerBase
    {
        private readonly IPassagemRepository _repository;
        public PassagemController()
        {
            _repository = new PassagemRepository();
        }

        [HttpPost]
        public IActionResult PostPassagem(Passagem novaPassagem)
        {
            try
            {
                _repository.AdicionarPassagem(novaPassagem);

                return Ok(new Resposta(200, "Criado com sucesso!"));
            }
            catch (Exception e)
            {
                return StatusCode(500, new Resposta(500, e.Message));
            }
        }

        [HttpGet]
        public IActionResult GetPassagem()
        {
            try
            {
                _repository.BuscarTodasAsPassagens();
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, new Resposta(500, e.Message));
            }
        }
        [HttpPut]
        public IActionResult PutPassagem([FromBody]Passagem editado)
        {
            try
            {
                //var clienteBuscado = editado.Cpf;
                _repository.AlterarPassagem(editado.IdPassagem);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, new Resposta(500, e.Message));
            }
        }
        [HttpDelete]
        public IActionResult Delete([FromBody]Passagem passagemRemovida)
        {
            try
            {
                var passagemBuscada = passagemRemovida.IdPassagem;
                _repository.DeletarPassagem(passagemBuscada);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, new Resposta(500, e.Message));
            }
        }      
        
    }
}
