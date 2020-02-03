using Demo.Domain.Entities;
using Demo.Infra.EntityConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Infra.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Candidato> Candidatos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Instituicao> Instituicoes { get; set; }
        public DbSet<TipoEndereco> TiposEndereco { get; set; }
        public DbSet<VagaCandidato> VagasCandidatos { get; set; }
        public DbSet<CursoInstituicao> CursosInstituicoes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new CandidatoMap());
            modelBuilder.Entity<Cidade>().HasKey(c => c.IdCidade);

        }
    }
}
