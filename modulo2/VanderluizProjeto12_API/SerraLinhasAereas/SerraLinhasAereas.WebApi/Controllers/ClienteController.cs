using System;
using Microsoft.AspNetCore.Mvc;
using SerraLinhasAereas.Domain;
using SerraLinhasAereas.Domain.Repository;
using SerraLinhasAereas.Infra.Data;
using SerraLinhasAereas.Infra.Data.Repository;

namespace SerraLinhasAereas.WebApi.Controllers
{
    [ApiController]
    [Route("api/cliente")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _repository;
        public ClienteController()
        {
            _repository = new ClienteRepository();
        }

        [HttpPost]
        public IActionResult PostCliente(Cliente novoCliente)
        {
            try
            {
                _repository.AdicionarCliente(novoCliente);

                return Ok(new Resposta(200, "Criado com sucesso!"));
            }
            catch (Exception e)
            {
                return StatusCode(500, new Resposta(500, e.Message));
            }
        }

        [HttpGet]
        public IActionResult GetCliente()
        {
            try
            {
                return Ok(_repository.BuscarTodosOsClientes());
            }
            catch (Exception e)
            {
                return StatusCode(500, new Resposta(500, e.Message));
            }
        }
        [HttpPut]
        public IActionResult PutCliente([FromBody]Cliente editado)
        {
            try
            {
                //var clienteBuscado = editado.Cpf;
                _repository.AtualizarCliente(editado.Cpf);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, new Resposta(500, e.Message));
            }
        }
        [HttpDelete]
        public IActionResult Delete([FromBody]Cliente clienteRemovido)
        {
            try
            {
                var clienteBuscado = clienteRemovido.Cpf;
                _repository.DeletarCliente(clienteBuscado);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, new Resposta(500, e.Message));
            }
        }      
        
    }    
}
