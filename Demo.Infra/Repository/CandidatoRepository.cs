using Demo.Domain.Entities;
using Demo.Domain.Interfaces.Repository;
using Demo.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.Infra.Repository
{
    public class CandidatoRepository : EFRepository<Curso>, ICandidatoRepository
    {

        public CandidatoRepository(DataContext _dbContext) : base(_dbContext)
        {

        }

        public Curso ObterCandidatoPorCidade(int IdCidade)
        {
           return Search(cand => cand.list_enderecos.Any()).Where(c => c.Enderecos.IdCidade == IdCidade).FirstOrDefault();
            
        }
    }
}
