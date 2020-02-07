using Demo.Domain.Entities;
using Demo.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Demo.Domain.Interfaces.Service
{
    public interface ICandidatoService 
    {
        Candidato Add(CandidatoViewModel model);
        IEnumerable<CandidatoViewModel> GetAll();
        CandidatoViewModel GetByCpf(string cpf);
        IEnumerable<Candidato> Search(Expression<Func<Candidato, bool>> predicado);
        void UpdateByCpf(CandidatoViewModel candidatoViewModel);
        void RemoveByCpf(string cpf);
    }
}
