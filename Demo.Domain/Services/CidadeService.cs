using Demo.Domain.Entities;
using Demo.Domain.Interfaces.Repository;
using Demo.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Demo.Domain.Services
{
    public class CidadeService : ICidadeService
    {
        private readonly ICidadeRepository _cidadeRepository;
        public CidadeService(ICidadeRepository _cursoRepository)
        {
            this._cidadeRepository = _cursoRepository;
        }
        public Cidade Add(Cidade entity)
        {
            return _cidadeRepository.Add(entity);
        }

        public IEnumerable<Cidade> GetAll()
        {
            return _cidadeRepository.GetAll();
        }

        public Cidade GetForId(int id)
        {
            return _cidadeRepository.GetForId(id);
        }

        public void Remove(Cidade entity)
        {
            _cidadeRepository.Remove(entity);
        }

        public IEnumerable<Cidade> Search(Expression<Func<Cidade, bool>> predicado)
        {
            return _cidadeRepository.Search(predicado);
        }

        public void Update(Cidade entity)
        {
            _cidadeRepository.Update(entity);
        }
    }
}
