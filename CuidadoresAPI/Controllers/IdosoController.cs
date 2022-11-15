using CuidadoresAPI.Data.Dtos.Idoso;
using CuidadoresAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CuidadoresAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdosoController : ControllerBase
    {
        private readonly IIdosoService _idosoService;

        public IdosoController(IIdosoService idosoService)
        {
            this._idosoService = idosoService;
        }

        [HttpPost]
        public IActionResult Cadastrar([FromBody] CreateIdosoDto idosoDto)
        {
            _idosoService.Cadastrar(idosoDto);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarPorId(int id)
        {
            var idoso = _idosoService.RecuperarPorId(id);
            if (idoso != null)
            {
                return Ok(idoso);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, [FromBody] UpdateIdosoDto idosoDto)
        {
            var idoso = _idosoService.RecuperarPorId(id);
            if (idoso == null)
            {
                return NotFound();
            }

            _idosoService.Atualizar(id, idosoDto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var idoso = _idosoService.RecuperarPorId(id);
            if (idoso == null)
            {
                return NotFound();
            }

            _idosoService.Deletar(id);
            return Ok();
        }
    }
}
