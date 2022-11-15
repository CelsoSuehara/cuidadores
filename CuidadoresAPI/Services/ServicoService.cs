using AutoMapper;
using CuidadoresAPI.Data;
using CuidadoresAPI.Data.Dtos.Servico;
using CuidadoresAPI.Models;
using CuidadoresAPI.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CuidadoresAPI.Services
{
    public class ServicoService : IServicoService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public ServicoService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Cadastrar(CreateServicoDto servicoDto)
        {
            Servico servico = _mapper.Map<Servico>(servicoDto);

            var totalHoras = servico.DataHoraFim.Subtract(servico.DataHoraInicio);
            servico.Valor = 150 * totalHoras.Hours;
            servico.cancelado = 0;

            _context.Servicos.Add(servico);
            _context.SaveChanges();
        }

        public ReadServicoDto RecuperarPorId(int id)
        {
            Servico servico = _context.Servicos.FirstOrDefault(s => s.Id == id);
            ReadServicoDto servicoDto = _mapper.Map<ReadServicoDto>(servico);
            return servicoDto;
        }

        public List<ReadServicoDto> RecuperarPorIdCuidador(int id)
        {
            List<Servico> servicos = _context.Servicos.Where(s => s.IdCuidador == id).ToList();
            List<ReadServicoDto> servicosDto = _mapper.Map<List<ReadServicoDto>>(servicos);
            return servicosDto;
        }

        public void CancelarServicoPorId(int id)
        {
            Servico servico = _context.Servicos.FirstOrDefault(s => s.Id == id);
            if (servico != null)
            {
                servico.cancelado = 1;
                _context.SaveChanges();
            }
        }
    }
}
