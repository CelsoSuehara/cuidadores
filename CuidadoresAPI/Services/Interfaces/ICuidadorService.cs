using CuidadoresAPI.Data.Dtos.Cuidador;
using System.Collections.Generic;

namespace CuidadoresAPI.Services.Interfaces
{
    public interface ICuidadorService
    {
        void Cadastrar(CreateCuidadorDto cuidadorDto);
        ReadCuidadorDto RecuperarPorId(int id);
        List<ReadCuidadorDto> RecuperarTodos();
        void Atualizar(int id, UpdateCuidadorDto cuidadorDto);
        void Deletar(int id);
        ReadCuidadorDto RealizarLogin(string email, string senha);
    }
}
