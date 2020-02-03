using Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Domain.Interfaces.Repository
{
    public interface ICandidatoRepository : IRepository<Candidato>
    {
        Candidato ObterCandidatoPorCidade(int IdCidade);
    }
}
