using Microsoft.EntityFrameworkCore;
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

        public string Estado { get; set; }

        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string CelularOpcional { get; set; }
        public List<Cidade> list_cidade { get; set; }
    }
}
