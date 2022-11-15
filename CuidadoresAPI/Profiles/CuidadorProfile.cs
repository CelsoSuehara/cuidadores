using AutoMapper;
using CuidadoresAPI.Data.Dtos.Cuidador;
using CuidadoresAPI.Models;

namespace CuidadoresAPI.Profiles
{
    public class CuidadorProfile : Profile
    {
        public CuidadorProfile()
        {
            CreateMap<CreateCuidadorDto, Cuidador>();
            CreateMap<Cuidador, ReadCuidadorDto>();
            CreateMap<UpdateCuidadorDto, Cuidador>();
        }
    }
}
