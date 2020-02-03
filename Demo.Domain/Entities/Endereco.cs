using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo.Domain.Entities
{
    public class Endereco
    {

        public Endereco()
        {

        }

        [Key]
        public int IdEndereco { get; set; }
        
        public string Logradouro{get;set;}
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public int Cep { get; set; }
        public string Estado { get; set; }

        public string Cidade { get; set; }
        public int IdCandidato { get; set; }
        public Curso candidato { get; set; }
        public int IdTipoEndereco { get; set; }
        public TipoEndereco tipoendereco { get; set; }
        public Cidade cidade { get; set; }
        public int IdCidade { get; set; }
        public List<Cidade> list_cidade { get; set; }

    }
}
