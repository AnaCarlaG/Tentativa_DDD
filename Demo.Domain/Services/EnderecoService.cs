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
        public Curso Add(Curso entity)
        {
            return _enderecoRepository.Add(entity);
        }

        public IEnumerable<Curso> GetAll()
        {
            return _enderecoRepository.GetAll();
        }

        public Curso GetForId(int id)
        {
            return _enderecoRepository.GetForId(id);
        }

        public void Remove(Curso entity)
        {
            _enderecoRepository.Remove(entity);
        }

        public IEnumerable<Curso> Search(Expression<Func<Curso, bool>> predicado)
        {
            return _enderecoRepository.Search(predicado);
        }

        public void Update(Curso entity)
        {
            _enderecoRepository.Update(entity);
        }
    }
}
