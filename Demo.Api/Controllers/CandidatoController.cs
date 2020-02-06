using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.Domain.Interfaces.Repository;
using Demo.Domain.Model;
using Demo.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Api.Controllers
{

    [ApiController]
    [Route("[controller]/[action]")]
    public class CandidatoController : ControllerBase
    {
        private CandidatoService _candidatoService;
        public CandidatoController(ICandidatoRepository candidatoRepository)
        {
            _candidatoService = new CandidatoService(candidatoRepository);
        }

        [HttpGet]
        [Route("")]
        public ActionResult<CandidatoViewModel> Start()
        {
            CandidatoViewModel c1 = new CandidatoViewModel { Nome = "Thiago", Apelido = "TT", CPF = "025" };
            CandidatoViewModel c2 = new CandidatoViewModel { Nome = "Joao", Apelido = "JJ", CPF = "026" };
            _candidatoService.Add(c1);
            _candidatoService.Add(c2);
            return StatusCode(200);
        }


        [HttpGet]
        [Route("")]

        public ActionResult<IEnumerable<CandidatoViewModel>> Get()
        {
            return _candidatoService.GetAll().ToList();
        }

        [HttpPost]
        [Route("")]
        public ActionResult<CandidatoViewModel> Post([FromBody] CandidatoViewModel model)
        {
            _candidatoService.Add(model);
            return model;
        }
    }
}