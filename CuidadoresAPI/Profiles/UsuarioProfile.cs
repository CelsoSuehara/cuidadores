using AutoMapper;
using CuidadoresAPI.Data.Dtos.Usuario;
using CuidadoresAPI.Models;

namespace CuidadoresAPI.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<CreateUsuarioDto, Usuario>();
            CreateMap<Usuario, ReadUsuarioDto>();
            CreateMap<UpdateUsuarioDto, Usuario>();
        }
    }
}
