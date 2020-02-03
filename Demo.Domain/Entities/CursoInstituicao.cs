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
        [Key]
        public int IdCurso { get; set; }
        [Key]
        public int IdCidade { get; set; }
        public int QuantidadeVagas { get; set; }
    }
}