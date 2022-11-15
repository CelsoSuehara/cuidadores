using System;
using System.ComponentModel.DataAnnotations;

namespace CuidadoresAPI.Data.Dtos.Idoso
{
    public class CreateIdosoDto
    {
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo id do usuário é obrigatório")]
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "O campo sexo é obrigatório")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "O campo data de nascimento é obrigatório")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O campo necessidades é obrigatório")]
        public string Necessidades { get; set; }

        [Required(ErrorMessage = "O campo logradouro é obrigatório")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O campo número é obrigatório")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "O campo bairro é obrigatório")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O campo cidade é obrigatório")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O campo estado é obrigatório")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "O campo cep é obrigatório")]
        public string Cep { get; set; }
    }
}
