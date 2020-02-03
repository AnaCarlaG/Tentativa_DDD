using Demo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Infra.EntityConfig
{
    public class CandidatoMap : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.HasKey(c => c.IdCandidato);
            builder.HasOne(e => e.Enderecos).WithOne(e => e.candidato).HasForeignKey<Curso>(e => e.IdEndereco);
        }
    }
}
