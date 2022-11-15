using CuidadoresAPI.Data.Dtos.Servico;
using System.Collections.Generic;

namespace CuidadoresAPI.Services.Interfaces
{
    public interface IServicoService
    {
        void Cadastrar(CreateServicoDto servicoDto);
        ReadServicoDto RecuperarPorId(int id);
        List<ReadServicoDto> RecuperarPorIdCuidador(int id);
        void CancelarServicoPorId(int id);
    }
}
