using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo.Domain.Entities
{
    public class VagaCandidato
    {
        public VagaCandidato()
        {

        }
        [Key]
        public int IdVaga { get; set; }
        public DateTime DataInclusao { get; set; }
        public char StatusAprovado { get; set; }
        public float Nota { get; set; }
        public int IdCandidato { get; set; }
        public int IdCurso { get; set; }
        public int IdInstituicao { get; set; }
        public int IdCidade { get; set; }
        public List<Candidato> list_candidatos { get; set; }
        public List<CursoInstituicao> list_cursoInstituicao { get; set; }
    }
}
