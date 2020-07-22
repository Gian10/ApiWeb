using ApiWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiWeb.Services.MatricularCursoService
{
    public class MatricularCursoService
    {

        private readonly UsuarioContext _context;

        public MatricularCursoService(UsuarioContext context)
        {
            _context = context;
        }

        public async Task<List<MatricularCurso>> ListarMatriculasCurso()
        {
            var listaMatricula = await _context.MatricularCurso.ToListAsync();
            return listaMatricula;
        }


    }
}
