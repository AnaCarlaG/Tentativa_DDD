using Demo.Domain.Entities;
using Demo.Domain.Interfaces.Repository;
using Demo.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Demo.Domain.Services
{
    public class CursoInstituicaoService : ICursoInstituicaoService
    {
        private readonly ICursoInstituicaoRepository _cursoinstituicaoRepository;
        public CursoInstituicaoService(ICursoInstituicaoRepository _cursoinstituicaoRepository)
        {
            this._cursoinstituicaoRepository = _cursoinstituicaoRepository;
        }
        public CursoInstituicao Add(CursoInstituicao entity)
        {
            return _cursoinstituicaoRepository.Add(entity);
        }

        public IEnumerable<CursoInstituicao> GetAll()
        {
            return _cursoinstituicaoRepository.GetAll();
        }

        public CursoInstituicao GetForId(int id)
        {
            throw new NotImplementedException();
        }

        //public CursoInstituicao GetForId(int id)
        //{
        //    return _cursoinstituicaoRepository.GetById(id);
        //}

        public void Remove(CursoInstituicao entity)
        {
            _cursoinstituicaoRepository.Remove(entity);
        }

        public IEnumerable<CursoInstituicao> Search(Expression<Func<CursoInstituicao, bool>> predicado)
        {
            return _cursoinstituicaoRepository.Search(predicado);
        }

        public void Update(CursoInstituicao entity)
        {
            _cursoinstituicaoRepository.Update(entity);
        }
    }
}
