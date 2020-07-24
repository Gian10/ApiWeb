using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiWeb.Services.CursoService
{
    // CLASSE DE SERVIÇO DE CURSO LIGADO AO BANCO DE DADOS
    public class CursoService
    {

        private readonly UsuarioContext _context;

        public CursoService(UsuarioContext context)
        {
            _context = context;
            
        }

        public async Task<List<Curso>> listarCursos()
        {
            var listaCursos = await _context.Curso.ToListAsync();
            return listaCursos;
        }

        public async Task<Curso> CriarCurso(Curso curso)
        {
            _context.Add(curso);
            await _context.SaveChangesAsync();
            return curso;
        }
    }
}
