using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo.Domain.Entities
{
    public class Instituicao
    {
        public Instituicao()
        {

        }

        [Key]
        public int IdInstituicao { get; set; }
        public string Nome { get; set; }
    }
}
