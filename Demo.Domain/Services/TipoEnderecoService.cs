using Demo.Domain.Entities;
using Demo.Domain.Interfaces.Repository;
using Demo.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Demo.Domain.Services
{
    public class TipoEnderecoService : ITipoEnderecoService
    {
        private readonly ITipoEnderecoRepository _tipoenderecoRepository;
        public TipoEnderecoService(ITipoEnderecoRepository _cursoRepository)
        {
            this._tipoenderecoRepository = _cursoRepository;
        }
        public TipoEndereco Add(TipoEndereco entity)
        {
            return _tipoenderecoRepository.Add(entity);
        }

        public IEnumerable<TipoEndereco> GetAll()
        {
            return _tipoenderecoRepository.GetAll();
        }

        public TipoEndereco GetForId(int id)
        {
            return _tipoenderecoRepository.GetForId(id);
        }

        public void Remove(TipoEndereco entity)
        {
            _tipoenderecoRepository.Remove(entity);
        }

        public IEnumerable<TipoEndereco> Search(Expression<Func<TipoEndereco, bool>> predicado)
        {
            return _tipoenderecoRepository.Search(predicado);
        }

        public void Update(TipoEndereco entity)
        {
            _tipoenderecoRepository.Update(entity);
        }
    }
}
