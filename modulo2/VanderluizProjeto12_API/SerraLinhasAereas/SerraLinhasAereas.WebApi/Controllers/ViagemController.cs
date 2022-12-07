using System;
using Microsoft.AspNetCore.Mvc;
using SerraLinhasAereas.Domain;
using SerraLinhasAereas.Domain.Repository;
using SerraLinhasAereas.Infra.Data;
using SerraLinhasAereas.Infra.Data.Repository;

namespace SerraLinhasAereas.WebApi.Controllers
{
    [ApiController]
    [Route("api/viagem")]
    public class ViagemController : ControllerBase
    {
        private readonly IViagemRepository _repository;
        public ViagemController()
        {
            _repository = new ViagemRepository();
        }

        [HttpPost]
        public IActionResult PostViagem(Viagem novaViagem)
        {
            try
            {
                _repository.AdicionarViagem(novaViagem);

                return Ok(new Resposta(200, "Criado com sucesso!"));
            }
            catch (Exception e)
            {
                return StatusCode(500, new Resposta(500, e.Message));
            }
        }

        [HttpGet]
        public IActionResult GetViagem()
        {
            try
            {
                _repository.BuscarTodasAsViagens();
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, new Resposta(500, e.Message));
            }
        }
        [HttpPut]
        public IActionResult PutViagem([FromBody]Viagem editado)
        {
            try
            {
                //var clienteBuscado = editado.Cpf;
                _repository.AlterarViagem(editado.CodigoReserva);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, new Resposta(500, e.Message));
            }
        }
        [HttpDelete]
        public IActionResult Delete([FromBody]Viagem viagemRemovida)
        {
            try
            {
                var viagemBuscado = viagemRemovida.CodigoReserva;
                _repository.DeletarViagem(viagemBuscado);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, new Resposta(500, e.Message));
            }
        }      
        
    }
    
}
