using Demo.Domain.Entities;
using Demo.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Demo.Domain.Interfaces.Service
{
    public interface ICursoInstituicaoService
    {
        CursoInstituicao Add(CursoInstituicao entity);
        void Update(CursoInstituicao entity);
        IEnumerable<CursoInstituicao> GetAll();
        CursoInstituicao GetForId(int id);
        IEnumerable<CursoInstituicao> Search(Expression<Func<CursoInstituicao, bool>> predicado);
        void Remove(CursoInstituicao entity);
    }
}
