using System.ComponentModel.DataAnnotations;

namespace Demo.Domain.Entities
{
    public class TipoEndereco
    {
        public TipoEndereco()
        {

        }
        [Key]
        public int IdTipoEndereco { get; set; }
        public string Descricao { get; set; }
    }
}