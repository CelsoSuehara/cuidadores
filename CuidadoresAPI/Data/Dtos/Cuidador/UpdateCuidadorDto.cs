using System;
using System.ComponentModel.DataAnnotations;

namespace CuidadoresAPI.Data.Dtos.Cuidador
{
    public class UpdateCuidadorDto
    {
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo email é obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo senha é obrigatório")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "O campo sexo é obrigatório")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "O campo data de nascimento é obrigatório")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O campo especialidade é obrigatório")]
        public string Especialidades { get; set; }

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

        [Required(ErrorMessage = "O campo telefone é obrigatório")]
        public string Telefone { get; set; }
    }
}
