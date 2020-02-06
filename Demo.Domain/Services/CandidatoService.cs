using Demo.Domain.Entities;
using Demo.Domain.Interfaces.Repository;
using Demo.Domain.Interfaces.Service;
using Demo.Domain.Model;
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
        public Candidato Add(CandidatoViewModel model)
        {
            Candidato candidato = new Candidato(model.Nome,model.Apelido,model.CPF);
            return _candidatoRepository.Add(candidato);
        }

        public IEnumerable<CandidatoViewModel> GetAll()
        {
            List<CandidatoViewModel> listaCandidatoViewModel = new List<CandidatoViewModel>();
            
            foreach (var candidato in _candidatoRepository.GetAll())
            {
                CandidatoViewModel candidatoViewModel = new CandidatoViewModel {
                    Nome = candidato.Nome,
                    Apelido = candidato.Apelido,
                    CPF = candidato.CPF };
                listaCandidatoViewModel.Add(candidatoViewModel);
            }
            return listaCandidatoViewModel;
        }

        public Candidato GetById(int id)
        {
            return _candidatoRepository.GetById(id);
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
