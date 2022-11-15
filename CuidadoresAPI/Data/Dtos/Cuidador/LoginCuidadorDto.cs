using System.ComponentModel.DataAnnotations;

namespace CuidadoresAPI.Data.Dtos.Cuidador
{
    public class LoginCuidadorDto
    {

        [Required(ErrorMessage = "O campo email é obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo senha é obrigatório")]
        public string Senha { get; set; }
    }
}
