using Demo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Infra.EntityConfig
{
    public class CandidatoMap : IEntityTypeConfiguration<Candidato>
    {
        public void Configure(EntityTypeBuilder<Candidato> builder)
        {
            builder.HasKey(c => c.IdCandidato);
            builder.Property(cand => cand.CPF).IsRequired();
            builder.HasOne(e => e.Enderecos).WithOne(e => e.candidato).HasForeignKey<Candidato>(e => e.IdEndereco);
        }
    }
}
