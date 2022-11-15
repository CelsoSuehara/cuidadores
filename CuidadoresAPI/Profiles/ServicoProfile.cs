using AutoMapper;
using CuidadoresAPI.Data.Dtos.Servico;
using CuidadoresAPI.Models;

namespace CuidadoresAPI.Profiles
{
    public class ServicoProfile : Profile
    {
        public ServicoProfile()
        {
            CreateMap<CreateServicoDto, Servico>();
            CreateMap<Servico, ReadServicoDto>();
        }
    }
}
