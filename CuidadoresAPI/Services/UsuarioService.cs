using AutoMapper;
using CuidadoresAPI.Data;
using CuidadoresAPI.Data.Dtos.Usuario;
using CuidadoresAPI.Models;
using CuidadoresAPI.Services.Interfaces;
using System.Linq;

namespace CuidadoresAPI.Services
{
    public class UsuarioService: IUsuarioService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public UsuarioService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Cadastrar(CreateUsuarioDto usuarioDto)
        {
            Usuario usuario = _mapper.Map<Usuario>(usuarioDto);
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public ReadUsuarioDto RecuperarPorId(int id)
        {
            Usuario usuario = _context.Usuarios.FirstOrDefault(u => u.Id == id);
            ReadUsuarioDto usuarioDto = _mapper.Map<ReadUsuarioDto>(usuario);
            return usuarioDto;
        }

        public void Atualizar(int id, UpdateUsuarioDto usuarioDto)
        {
            Usuario usuario = _context.Usuarios.FirstOrDefault(u => u.Id == id);
            if (usuario != null)
            {
                _mapper.Map(usuarioDto, usuario);
                _context.SaveChanges();
            }            
        }

        public void Deletar(int id)
        {
            Usuario usuario = _context.Usuarios.FirstOrDefault(u => u.Id == id);
            if (usuario != null)
            {
                _context.Remove(usuario);
                _context.SaveChanges();
            }            
        }

        public ReadUsuarioDto RealizarLogin(string email, string senha)
        {
            Usuario usuario = _context.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
            ReadUsuarioDto usuarioDto = _mapper.Map<ReadUsuarioDto>(usuario);
            return usuarioDto;
        }
    }
}
