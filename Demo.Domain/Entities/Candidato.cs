using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo.Domain.Entities
{
    public class Candidato
    {
        public Candidato()
        {

        }

        [Key]
        public int IdCandidato { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Apelido { get; set; }
        [Required]

        public string CPF { get; set; }

        [Required]

        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Email { get; set; }
        public string TelefonePrimario { get; set; }
        public string TelefoneSecundario { get; set; }

        public int IdEndereco { get; set; }
        public Curso Enderecos { get; set; }
        public List<Curso> list_enderecos { get; set; }

    }
}
