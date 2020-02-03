using Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Demo.Domain.Interfaces.Service
{
    public interface ICidadeService
    {
        Cidade Add(Cidade entity);
        void Update(Cidade entity);
        IEnumerable<Cidade> GetAll();
        Cidade GetForId(int id);
        IEnumerable<Cidade> Search(Expression<Func<Cidade, bool>> predicado);
        void Remove(Cidade entity);
    }
}
