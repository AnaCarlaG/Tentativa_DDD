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
        public DbSet<Candidato> Cidades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new CandidatoMap());
            modelBuilder.Entity<Cidade>().HasKey(c => c.IdCidade);

        }
    }
}
