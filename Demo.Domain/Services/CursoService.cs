using Demo.Domain.Entities;
using Demo.Domain.Interfaces.Repository;
using Demo.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Demo.Domain.Services
{
    public class CursoService
    {
        private readonly ICursoRepository _cursoRepository;
        public CursoService(ICursoRepository _cursoRepository)
        {
            this._cursoRepository = _cursoRepository;
        }
        public Curso Add(Curso entity)
        {
            return _cursoRepository.Add(entity);
        }

        public IEnumerable<Curso> GetAll()
        {
            return _cursoRepository.GetAll();
        }

        public Curso GetForId(int id)
        {
            return _cursoRepository.GetForId(id);
        }

        public void Remove(Curso entity)
        {
            _cursoRepository.Remove(entity);
        }

        public IEnumerable<Curso> Search(Expression<Func<Curso, bool>> predicado)
        {
            return _cursoRepository.Search(predicado);
        }

        public void Update(Curso entity)
        {
            _cursoRepository.Update(entity);
        }
    }
}
