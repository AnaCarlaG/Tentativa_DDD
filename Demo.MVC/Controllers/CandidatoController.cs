using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.Domain.Entities;
using Demo.Domain.Interfaces.Repository;
using Demo.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Demo.MVC.Controllers
{
    public class CandidatoController : Controller
    {
        private readonly CandidatoService candidatoService;
        public CandidatoController(ICandidatoRepository candidatoRepository)
        {
            candidatoService = new CandidatoService(candidatoRepository);
        }
        public IActionResult Index()
        {
            IEnumerable<Candidato> list_candidato;
            candidatoService.Add(new Candidato
            {
                Nome = "Thiago Souza da Silva",
                CPF = "83847565036",
            });
            candidatoService.Add(new Candidato
            {
                Nome = "Elma Souza da Silva",
                CPF = "50070125058",
            });
            candidatoService.Add(new Candidato
            {
                Nome = "Ana Souza da Silva",
                CPF = "17090223027",
            });
            ViewBag.c = candidatoService.GetAll();
            return View("Index");
        }
        public IActionResult Create()
        {
            return View("Create");
        }

        public IActionResult Incluir(Candidato candidato)
        {
            candidatoService.Add(candidato);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(Candidato candidato)
        {
            candidatoService.Remove(candidato);
            return RedirectToAction("Index");
        }
    }
}