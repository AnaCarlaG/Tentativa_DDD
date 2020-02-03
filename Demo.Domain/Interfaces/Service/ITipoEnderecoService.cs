using Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Demo.Domain.Interfaces.Service
{
    public interface ITipoEnderecoService
    {
        TipoEndereco Add(TipoEndereco entity);
        void Update(TipoEndereco entity);
        IEnumerable<TipoEndereco> GetAll();
        TipoEndereco GetForId(int id);
        IEnumerable<TipoEndereco> Search(Expression<Func<TipoEndereco, bool>> predicado);
        void Remove(TipoEndereco entity);
    }
}
