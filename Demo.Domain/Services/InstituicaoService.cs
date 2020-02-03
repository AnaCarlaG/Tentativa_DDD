using Demo.Domain.Entities;
using Demo.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Demo.Domain.Services
{
    public class InstituicaoService
    {
        private readonly IInstituicaoRepository _instituicaoRepository;
        public InstituicaoService(IInstituicaoRepository _cursoRepository)
        {
            this._instituicaoRepository = _cursoRepository;
        }
        public Instituicao Add(Instituicao entity)
        {
            return _instituicaoRepository.Add(entity);
        }

        public IEnumerable<Instituicao> GetAll()
        {
            return _instituicaoRepository.GetAll();
        }

        public Instituicao GetForId(int id)
        {
            return _instituicaoRepository.GetForId(id);
        }

        public void Remove(Instituicao entity)
        {
            _instituicaoRepository.Remove(entity);
        }

        public IEnumerable<Instituicao> Search(Expression<Func<Instituicao, bool>> predicado)
        {
            return _instituicaoRepository.Search(predicado);
        }

        public void Update(Instituicao entity)
        {
            _instituicaoRepository.Update(entity);
        }
    }
}
