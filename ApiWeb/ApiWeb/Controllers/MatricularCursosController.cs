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

        
       

        //[HttpPost]
        //public async Task<ActionResult<MatricularCurso>> PostMatricularCurso(MatricularCurso matricularCurso)
        //{
        //    _context.MatricularCurso.Add(matricularCurso);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetMatricularCurso", new { id = matricularCurso.MatricularCursoId }, matricularCurso);
        //}

        
       
    }
}
