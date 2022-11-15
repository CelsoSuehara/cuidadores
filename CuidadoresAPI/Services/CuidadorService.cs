using AutoMapper;
using CuidadoresAPI.Data;
using CuidadoresAPI.Data.Dtos.Cuidador;
using CuidadoresAPI.Models;
using CuidadoresAPI.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CuidadoresAPI.Services
{
    public class CuidadorService : ICuidadorService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public CuidadorService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Cadastrar(CreateCuidadorDto cuidadorDto)
        {
            Cuidador cuidador = _mapper.Map<Cuidador>(cuidadorDto);
            _context.Cuidadores.Add(cuidador);
            _context.SaveChanges();
        }

        public void Atualizar(int id, UpdateCuidadorDto cuidadorDto)
        {
            Cuidador cuidador = _context.Cuidadores.FirstOrDefault(u => u.Id == id);
            if (cuidador != null)
            {
                _mapper.Map(cuidadorDto, cuidador);
                _context.SaveChanges();
            }
        }

        public void Deletar(int id)
        {
            Cuidador cuidador = _context.Cuidadores.FirstOrDefault(u => u.Id == id);
            if (cuidador != null)
            {
                _context.Remove(cuidador);
                _context.SaveChanges();
            }
        }

        public ReadCuidadorDto RecuperarPorId(int id)
        {
            Cuidador cuidador = _context.Cuidadores.FirstOrDefault(u => u.Id == id);
            ReadCuidadorDto cuidadorDto = _mapper.Map<ReadCuidadorDto>(cuidador);
            return cuidadorDto;
        }

        public List<ReadCuidadorDto> RecuperarTodos()
        {
            List<Cuidador> cuidadores = _context.Cuidadores.ToList();
            List<ReadCuidadorDto> cuidadoresDto = _mapper.Map<List<ReadCuidadorDto>>(cuidadores);
            return cuidadoresDto;
        }

        public ReadCuidadorDto RealizarLogin(string email, string senha)
        {
            Cuidador cuidador = _context.Cuidadores.FirstOrDefault(u => u.Email == email && u.Senha == senha);
            ReadCuidadorDto cuidadorDto = _mapper.Map<ReadCuidadorDto>(cuidador);
            return cuidadorDto;
        }
    }
}
