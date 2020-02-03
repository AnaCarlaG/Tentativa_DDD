using Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Demo.Domain.Interfaces.Service
{
    public interface IVagaCandidatoService
    {
        VagaCandidato Add(VagaCandidato entity);
        void Update(VagaCandidato entity);
        IEnumerable<VagaCandidato> GetAll();
        VagaCandidato GetForId(int id);
        IEnumerable<VagaCandidato> Search(Expression<Func<VagaCandidato, bool>> predicado);
        void Remove(VagaCandidato entity);
    }
}
