using Demo.Domain.Entities;
using Demo.Domain.Interfaces.Repository;
using Demo.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Demo.Domain.Services
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IEnderecoRepository _enderecoRepository;
        public EnderecoService(IEnderecoRepository enderecoRepository)
        {
            this._enderecoRepository = enderecoRepository;
        }
        public Candidato Add(Candidato entity)
        {
            return _enderecoRepository.Add(entity);
        }

        public IEnumerable<Candidato> GetAll()
        {
            return _enderecoRepository.GetAll();
        }

        public Candidato GetForId(int id)
        {
            return _enderecoRepository.GetForId(id);
        }

        public void Remove(Candidato entity)
        {
            _enderecoRepository.Remove(entity);
        }

        public IEnumerable<Candidato> Search(Expression<Func<Candidato, bool>> predicado)
        {
            return _enderecoRepository.Search(predicado);
        }

        public void Update(Candidato entity)
        {
            _enderecoRepository.Update(entity);
        }
    }
}
