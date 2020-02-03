using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Demo.Domain.Entities;

namespace Demo.Infra.Data
{
    public class DbInicialize
    {
        public static void Inicialize(DataContext context)
        {
            if (context.Candidatos.Any())
            {
                return;
            }
            var candidato = new Curso[]
            {
                new Curso
                {
                    Nome = "Thiago Souza da Silva",
                    CPF = "83847565036",
                },
                new Curso
                {
                    Nome = "Elma Souza da Silva",
                    CPF = "50070125058",
                },
                new Curso
                {
                    Nome = "Ana Souza da Silva",
                    CPF = "17090223027",
                }
        };
            context.AddRange(candidato);
            var cidade = new Cidade[]
            {
                new Cidade
                {
                    Nome = "Aracaju",
                    UF = "SE"
                },
                new Cidade
                {
                    Nome = "Colegio",
                    UF = "SE"
                }
            };
            context.AddRange(cidade);
            context.SaveChanges();
        }
    }
}
