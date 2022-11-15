using CuidadoresAPI.Data.Dtos.Usuario;
using CuidadoresAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CuidadoresAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        private readonly IIdosoService _idosoService;

        public UsuarioController(IUsuarioService usuarioService, IIdosoService idosoService)
        {
            _usuarioService = usuarioService;
            _idosoService = idosoService;
        }

        [HttpPost]
        public IActionResult Cadastrar([FromBody] CreateUsuarioDto usuarioDto)
        {
            _usuarioService.Cadastrar(usuarioDto);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarPorId(int id)
        {
            var usuario = _usuarioService.RecuperarPorId(id);
            if (usuario != null)
            {
                return Ok(usuario);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, [FromBody] UpdateUsuarioDto usuarioDto)
        {
            var usuario = _usuarioService.RecuperarPorId(id);
            if (usuario == null)
            {
                return NotFound();
            }

            _usuarioService.Atualizar(id, usuarioDto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var usuario = _usuarioService.RecuperarPorId(id);
            if (usuario == null)
            {
                return NotFound();
            }

            _usuarioService.Deletar(id);
            return Ok();
        }

        [HttpPost("login")]
        public IActionResult RealizarLogin([FromBody] LoginUsuarioDto usuarioDto)
        {
            var usuario = _usuarioService.RealizarLogin(usuarioDto.Email, usuarioDto.Senha);
            if (usuario != null)
                return Ok(new { Id = usuario.Id });
            else
                return StatusCode(500, "Login ou senha inválido!");
        }

        [HttpGet("{id}/idosos")]
        public IActionResult RecuperarIdosos(int id)
        {
            var idosos = _idosoService.RecuperarPorIdUsuario(id);
            if (idosos != null)
            {
                return Ok(idosos);
            }
            return NotFound();
        }
    }
}
