using AutoMapper;
using CuidadoresAPI.Data.Dtos.Idoso;
using CuidadoresAPI.Models;

namespace CuidadoresAPI.Profiles
{
    public class IdosoProfile : Profile
    {
        public IdosoProfile()
        {
            CreateMap<CreateIdosoDto, Idoso>();
            CreateMap<Idoso, ReadIdosoDto>();
            CreateMap<UpdateIdosoDto, Idoso>();
        }
    }
}
