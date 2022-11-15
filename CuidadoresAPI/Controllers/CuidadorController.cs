using CuidadoresAPI.Data.Dtos.Cuidador;
using CuidadoresAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CuidadoresAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuidadorController : ControllerBase
    {
        private readonly ICuidadorService _cuidadorService;
        private readonly IServicoService _servicoService;

        public CuidadorController(ICuidadorService cuidadorService, IServicoService servicoService)
        {
            _cuidadorService = cuidadorService;
            _servicoService = servicoService;
        }

        [HttpPost("login")]
        public IActionResult RealizarLogin([FromBody] LoginCuidadorDto cuidadorDto)
        {
            var cuidador = _cuidadorService.RealizarLogin(cuidadorDto.Email, cuidadorDto.Senha);
            if (cuidador != null)
                return Ok(new { id = cuidador.Id });
            else
                return StatusCode(500, "Login ou senha inválido!");
        }

        [HttpPost]
        public IActionResult Cadastrar([FromBody] CreateCuidadorDto cuidadorDto)
        {
            _cuidadorService.Cadastrar(cuidadorDto);
            return Ok();
        }

        [HttpGet]
        public IActionResult RecuperarTodos()
        {
            var cuidadores = _cuidadorService.RecuperarTodos();
            if (cuidadores != null)
            {
                return Ok(cuidadores);
            }
            return NotFound();
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarPorId(int id)
        {
            var cuidador = _cuidadorService.RecuperarPorId(id);
            if (cuidador != null)
            {
                return Ok(cuidador);
            }
            return NotFound();
        }

        [HttpGet("{id}/servicos")]
        public IActionResult RecuperarServicosPorId(int id)
        {
            var servicos = _servicoService.RecuperarPorIdCuidador(id);
            if (servicos != null)
            {
                return Ok(servicos);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, [FromBody] UpdateCuidadorDto cuidadorDto)
        {
            var cuidador = _cuidadorService.RecuperarPorId(id);
            if (cuidador == null)
            {
                return NotFound();
            }

            _cuidadorService.Atualizar(id, cuidadorDto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var cuidador = _cuidadorService.RecuperarPorId(id);
            if (cuidador == null)
            {
                return NotFound();
            }

            _cuidadorService.Deletar(id);
            return Ok();
        }
    }
}
