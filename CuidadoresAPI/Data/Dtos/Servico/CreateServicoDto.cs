using System;
using System.ComponentModel.DataAnnotations;

namespace CuidadoresAPI.Data.Dtos.Servico
{
    public class CreateServicoDto
    {
        [Required(ErrorMessage = "O campo id do idoso é obrigatório")]
        public int IdIdoso { get; set; }

        [Required(ErrorMessage = "O campo id do cuidador é obrigatório")]
        public int IdCuidador { get; set; }

        public DateTime DataHoraInicio { get; set; }

        public DateTime DataHoraFim { get; set; }
        
        public string Observacoes { get; set; }
    }
}
