using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo.Domain.Entities
{
    public class Cidade
    {
        public Cidade()
        {

        }
        [Key]
        public int IdCidade { get; set; }
        [Required]

        public string Nome { get; set; }
        [Required]

        public string UF { get; set; }
        public int IdCandidato { get; set; }
        public Candidato candidato { get; set; }
    }
}
