using System;

namespace CuidadoresAPI.Data.Dtos.Servico
{
    public class ReadServicoDto
    {
        public int Id { get; set; }
        public int IdIdoso { get; set; }
        public int IdCuidador { get; set; }
        public DateTime DataHoraInicio { get; set; }
        public DateTime DataHoraFim { get; set; }
        public double Valor { get; set; }
        public string Observacoes { get; set; }
        public int Cancelado { get; set; }
    }
}
