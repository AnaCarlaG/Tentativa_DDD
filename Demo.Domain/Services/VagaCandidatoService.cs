using Demo.Domain.Entities;
using Demo.Domain.Interfaces.Repository;
using Demo.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Demo.Domain.Services
{
    public class VagaCandidatoService : IVagaCandidatoService
    {
        private readonly IVagaCandidatoRepository vagaCandidatoRepository ;
        public VagaCandidatoService(IVagaCandidatoRepository vagacandidatoRepository)
        {
            this.vagaCandidatoRepository = vagacandidatoRepository;
        }
        public VagaCandidato Add(VagaCandidato entity)
        {
            return vagaCandidatoRepository.Add(entity);
        }

        public IEnumerable<VagaCandidato> GetAll()
        {
            return vagaCandidatoRepository.GetAll();
        }

        public VagaCandidato GetForId(int id)
        {
            return vagaCandidatoRepository.GetForId(id);
        }

        public void Remove(VagaCandidato entity)
        {
            vagaCandidatoRepository.Remove(entity);
        }

        public IEnumerable<VagaCandidato> Search(Expression<Func<VagaCandidato, bool>> predicado)
        {
            return vagaCandidatoRepository.Search(predicado);
        }

        public void Update(VagaCandidato entity)
        {
            vagaCandidatoRepository.Update(entity);
        }
    }
}
