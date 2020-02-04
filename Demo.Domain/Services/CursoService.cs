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
        public Candidato Add(Candidato entity)
        {
            return _cursoRepository.Add(entity);
        }

        public IEnumerable<Candidato> GetAll()
        {
            return _cursoRepository.GetAll();
        }

        public Candidato GetForId(int id)
        {
            return _cursoRepository.GetById(id);
        }

        public void Remove(Candidato entity)
        {
            _cursoRepository.Remove(entity);
        }

        public IEnumerable<Candidato> Search(Expression<Func<Candidato, bool>> predicado)
        {
            return _cursoRepository.Search(predicado);
        }

        public void Update(Candidato entity)
        {
            _cursoRepository.Update(entity);
        }
    }
}
