using System.ComponentModel.DataAnnotations;

namespace Demo.Domain.Entities
{
    public class CursoInstituicao
    {
        public CursoInstituicao()
        {

        }
        [Key]
        public int IdINstituicao { get; set; }
        public int IdCurso { get; set; }
        public int IdCidade { get; set; }
        public int QuantidadeVagas { get; set; }
    }
}