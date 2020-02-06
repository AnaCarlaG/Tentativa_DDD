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

        public Candidato(string nome, string apelido, string cPF)
        {
            Nome = nome;
            Apelido = apelido;
            CPF = cPF;
        }

        [Key]
        public int IdCandidato { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }

        public string CPF { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Email { get; set; }
        public string TelefonePrimario { get; set; }
        public string TelefoneSecundario { get; set; }

        public int IdEndereco { get; set; }
        public Endereco Enderecos { get; set; }
        public List<Endereco> list_enderecos { get; set; }

    }
}
