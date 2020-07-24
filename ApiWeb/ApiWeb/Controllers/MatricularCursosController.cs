using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiWeb;
using ApiWeb.Models;
using ApiWeb.Services.MatricularCursoService;
using FluentAssertions;
using MimeKit;
using MailKit.Net.Smtp;
using System.Security.Authentication;
using MailKit.Security;
using System.Net;

namespace ApiWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatricularCursosController : ControllerBase
    {
        private readonly MatricularCursoService _matricularCursoService;
        

        public MatricularCursosController(MatricularCursoService matricularCursoService)
        {
           _matricularCursoService = matricularCursoService;
           
        }

        // GET: api/MatricularCursos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MatricularCurso>>> GetMatricularCurso()
        {
            
            var listaMatricula = await _matricularCursoService.ListarMatriculasCurso();
            return Ok(listaMatricula);
        }

        


        [HttpPost]
        public async Task<ActionResult> PostMatricularCurso(MatricularCurso matricularCurso)
        {
            var matricula = await _matricularCursoService.CriarMatriculaCurso(matricularCurso);
            if(matricula != null)
            { 
                return CreatedAtAction("GetMatricularCurso", new { id = matricula.MatricularCursoId }, matricula);
            }
            return NotFound("O estudante não pode se matricular neste curso pois não foi efetuado nenhum pagamento.");
        }
    }
}
