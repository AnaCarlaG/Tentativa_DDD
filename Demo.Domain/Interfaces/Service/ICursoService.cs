using Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Demo.Domain.Interfaces.Service
{
    public interface ICursoService
    {
        Curso Add(Curso entity);
        void Update(Curso entity);
        IEnumerable<Curso> GetAll();
        Curso GetForId(int id);
        IEnumerable<Curso> Search(Expression<Func<Curso, bool>> predicado);
        void Remove(Curso entity);
    }
}
