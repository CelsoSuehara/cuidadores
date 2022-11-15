using CuidadoresAPI.Data.Dtos.Servico;
using CuidadoresAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CuidadoresAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicoController : ControllerBase
    {
        private readonly IServicoService _servicoService;

        public ServicoController(IServicoService servicoService)
        {
            _servicoService = servicoService;
        }

        [HttpPost]
        public IActionResult Cadastrar([FromBody] CreateServicoDto servicoDto)
        {
            _servicoService.Cadastrar(servicoDto);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarPorId(int id)
        {
            var servico = _servicoService.RecuperarPorId(id);
            if (servico != null)
            {
                return Ok(servico);
            }
            return NotFound();
        }

        [HttpPost("{id}/cancelar")]
        public IActionResult CancelarPorId(int id)
        {
            _servicoService.CancelarServicoPorId(id);
            return Ok();
        }
    }
}
