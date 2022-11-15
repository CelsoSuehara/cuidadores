using CuidadoresAPI.Data.Dtos.Idoso;
using System.Collections.Generic;

namespace CuidadoresAPI.Services.Interfaces
{
    public interface IIdosoService
    {
        void Cadastrar(CreateIdosoDto idosoDto);
        ReadIdosoDto RecuperarPorId(int id);
        List<ReadIdosoDto> RecuperarPorIdUsuario(int idUsuario);
        void Atualizar(int id, UpdateIdosoDto idosoDto);
        void Deletar(int id);
    }
}
