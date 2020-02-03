using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo.Domain.Entities
{
    public class Curso
    {
        public Curso()
        {

        }
        [Key]
        public int IdCurso { get; set; }
        public string Nome { get; set; }
    }
}
