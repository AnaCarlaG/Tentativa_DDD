using Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Demo.Infra.Data.Context
{
    public class DemoContext : System.Data.Entity.DbContext
    {

        public DemoContext() : base("DemoDDD")
        {


        }

        public DbSet<Candidato> Candidatos { get; set; }


    }
}
