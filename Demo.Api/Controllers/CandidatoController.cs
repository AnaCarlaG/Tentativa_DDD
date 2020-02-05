using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.Domain.Entities;
using Demo.Domain.Interfaces.Repository;
using Demo.Domain.Services;
using Demo.Infra.Data;
using Demo.Infra.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Api.Controllers
{
    [Route("candidato")]
    [ApiController]
    public class CandidatoController : ControllerBase
    {
        private readonly CandidatoService candidatoservice;
        public CandidatoController(CandidatoRepository candidatorepository)
        {
            candidatoservice = new CandidatoService(candidatorepository);
        }

        #region getCandidato
        /// <summary>
        /// Get all Candidatos that we have
        /// </summary>
        /// <param name="context"></param>
        /// <returns>
        /// 200 - pega todos os candidatos
        /// </returns>
        [HttpGet]
        [Route("")]

        public ActionResult<IEnumerable<Candidato>> GetCandidato()
        {
            candidatoservice.Add(new Candidato { /*Id = 1,*/ Nome = "Thiago", Apelido = "TT", CPF = "025" });
            candidatoservice.Add(new Candidato {/* Id = 2,*/ Nome = "Ana", Apelido = "Ana", CPF = "026" });
            return candidatoservice.GetAll().ToList();
        }
        #endregion

        //#region postCandidato
        ///// <summary>
        ///// Post my Candidatos on my aplication
        ///// </summary>
        ///// <param name="context"></param>
        ///// <param name="model"></param>
        ///// <returns>
        ///// 200 - add na lista de candidatos
        ///// 400 - Bad Request(n add nada)
        ///// </returns>
        //[HttpPost]
        //[Route("")]
        //public ActionResult<Candidato> PostCandidato([FromServices] CandidatoService candidatoService, [FromBody] Candidato model)
        //{
        //    candidatoService.Add(model);
        //    return model;

        //}
        //#endregion

        //#region PutCandidato
        ///// <summary>
        ///// Editar o Candidato
        ///// </summary>
        ///// <param name="model"></param>
        ///// <returns></returns>
        //[HttpPut]
        //[Route("")]
        //public ActionResult<Candidato> PutCandidato([FromServices] CandidatoService candidatoService, [FromBody] Candidato model)
        //{
        //    var candidato = candidatoService.GetById(model.IdCandidato);
        //    candidatoService.Update(candidato);
        //    return candidato;
        //}
        //#endregion

        //#region DeleteCandidato
        ///// <summary>
        ///// Deletar meu Candidato
        ///// </summary>
        ///// <param name="model"></param>
        ///// <returns></returns>
        //[HttpDelete]
        //[Route("")]
        //public ActionResult DeleteCandidato([FromServices] CandidatoService candidatoService, [FromBody] Candidato model)
        //{
        //    int qntdObj = candidatoService.GetAll().Count();
        //    var candidato = candidatoService.GetById(model.IdCandidato);
        //    candidatoService.Remove(candidato);

        //    if (qntdObj > candidatoService.GetAll().Count())
        //        return Ok();

        //    return NotFound();
        //}
        //#endregion
    }
}