using AutoMapper;
using CuidadoresAPI.Data;
using CuidadoresAPI.Data.Dtos.Idoso;
using CuidadoresAPI.Models;
using CuidadoresAPI.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CuidadoresAPI.Services
{
    public class IdosoService : IIdosoService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public IdosoService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Cadastrar(CreateIdosoDto idosoDto)
        {
            Idoso idoso = _mapper.Map<Idoso>(idosoDto);
            _context.Idosos.Add(idoso);
            _context.SaveChanges();
        }

        public void Atualizar(int id, UpdateIdosoDto idosoDto)
        {
            Idoso idoso = _context.Idosos.FirstOrDefault(u => u.Id == id);
            if (idoso != null)
            {
                _mapper.Map(idosoDto, idoso);
                _context.SaveChanges();
            }
        }

        public void Deletar(int id)
        {
            Idoso idoso = _context.Idosos.FirstOrDefault(u => u.Id == id);
            if (idoso != null)
            {
                _context.Remove(idoso);
                _context.SaveChanges();
            }
        }

        public ReadIdosoDto RecuperarPorId(int id)
        {
            Idoso idoso = _context.Idosos.FirstOrDefault(u => u.Id == id);
            ReadIdosoDto idosoDto = _mapper.Map<ReadIdosoDto>(idoso);
            return idosoDto;
        }

        public List<ReadIdosoDto> RecuperarPorIdUsuario(int idUsuario)
        {
            List<Idoso> idosos = _context.Idosos.Where(u => u.IdUsuario == idUsuario).ToList();
            List<ReadIdosoDto> idososDto = _mapper.Map<List<ReadIdosoDto>>(idosos);
            return idososDto;
        }
    }
}
