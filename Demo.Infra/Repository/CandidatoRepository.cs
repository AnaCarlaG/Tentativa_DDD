using Demo.Domain.Entities;
using Demo.Domain.Interfaces.Repository;
using Demo.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.Infra.Repository
{
    public class CandidatoRepository : EFRepository<Candidato>, ICandidatoRepository
    {
        
        public CandidatoRepository(DataContext _dbContext) : base(_dbContext)
        {
            
        }

        public Candidato GetByCpf(string cpf)
        {
            foreach(var candidato in GetAll())
            {
                if (candidato.CPF == cpf)
                    return candidato;
                   
            }
            return null;
        }

       
    }
}

