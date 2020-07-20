using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiWeb;
using ApiWeb.Models;
using ApiWeb.Services.CursoService;

namespace ApiWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursosController : ControllerBase
    {
        private readonly CursoService _cursoService;

        public CursosController(CursoService cursoService)
        {
            _cursoService = cursoService;
        }

        // GET: api/Cursos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Curso>>> GetCurso()
        {
           var listaCursos = await _cursoService.listarCursos();
            return Ok(listaCursos);
        }



        [HttpPost]
        public async Task<ActionResult<Curso>> PostCurso(Curso curso)
        {
            var criarCurso = await _cursoService.CriarCurso(curso);
            return CreatedAtAction("GetCurso", new { id = criarCurso.CursoId }, criarCurso);
        }

    }
}
