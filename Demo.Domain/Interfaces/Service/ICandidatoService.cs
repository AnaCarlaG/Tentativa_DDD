using Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Demo.Domain.Interfaces.Service
{
    public interface ICandidatoService 
    {
        Candidato Add(Candidato entity);
        void Update(Candidato entity);
        IEnumerable<Candidato> GetAll();
        Candidato GetForId(int id);
        IEnumerable<Candidato> Search(Expression<Func<Candidato, bool>> predicado);
        void Remove(Candidato entity);
    }
}
