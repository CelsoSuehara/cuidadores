using CuidadoresAPI.Data.Dtos.Usuario;

namespace CuidadoresAPI.Services.Interfaces
{
    public interface IUsuarioService
    {
        void Cadastrar(CreateUsuarioDto usuarioDto);
        ReadUsuarioDto RecuperarPorId(int id);
        void Atualizar(int id, UpdateUsuarioDto usuarioDto);
        void Deletar(int id);
        ReadUsuarioDto RealizarLogin(string email, string senha);
    }
}
