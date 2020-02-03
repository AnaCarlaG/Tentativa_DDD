using Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Demo.Domain.Interfaces.Service
{
    public interface IInstituicaoService 
    {
        Instituicao Add(Instituicao entity);
        void Update(Instituicao entity);
        IEnumerable<Instituicao> GetAll();
        Instituicao GetForId(int id);
        IEnumerable<Instituicao> Search(Expression<Func<Instituicao, bool>> predicado);
        void Remove(Instituicao entity);
    }
}
