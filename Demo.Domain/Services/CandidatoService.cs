using Demo.Domain.Entities;
using Demo.Domain.Interfaces.Repository;
using Demo.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Demo.Domain.Services
{
    public class CandidatoService : ICandidatoService
    {
        private readonly ICandidatoRepository _candidatoRepository;
        public CandidatoService(ICandidatoRepository candidatoRepository)
        {
            this._candidatoRepository = candidatoRepository;
        }
        public Candidato Add(Candidato entity)
        {
            return _candidatoRepository.Add(entity);
        }

        public IEnumerable<Candidato> GetAll()
        {
            return _candidatoRepository.GetAll();
        }

        public Candidato GetForId(int id)
        {
            return _candidatoRepository.GetForId(id);
        }

        public void Remove(Candidato entity)
        {
            _candidatoRepository.Remove(entity);
        }

        public IEnumerable<Candidato> Search(Expression<Func<Candidato, bool>> predicado)
        {
            return _candidatoRepository.Search(predicado);
        }

        public void Update(Candidato entity)
        {
            _candidatoRepository.Update(entity);
        }
    }
}
