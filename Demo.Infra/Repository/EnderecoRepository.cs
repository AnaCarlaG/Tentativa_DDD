using Demo.Domain.Entities;
using Demo.Domain.Interfaces.Repository;
using Demo.Infra.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Infra.Repository
{
    public class EnderecoRepository : EFRepository<Candidato> , IEnderecoRepository
    {
        public EnderecoRepository(DataContext _dbContext) : base(_dbContext)
        {

        }
    }
}
