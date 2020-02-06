using Demo.Domain.Entities;
using Demo.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Demo.Domain.Interfaces.Service
{
    public interface ICandidatoService 
    {
        Candidato Add(CandidatoViewModel model);
        void Update(Candidato entity);
        IEnumerable<Candidato> GetAll();
        Candidato GetById(int id);
        IEnumerable<Candidato> Search(Expression<Func<Candidato, bool>> predicado);
        void Remove(Candidato entity);
    }
}
