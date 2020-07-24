using ApiWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiWeb.Services.MatricularCursoService
{
    // CLASSE DE SERVIÇO DE MATRICULAR CURSO LIGADO AO BANCO DE DADOS
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

        public async Task<MatricularCurso> CriarMatriculaCurso(MatricularCurso matricularCurso)
        {
            if (matricularCurso.QtdPagamentoUsuario >= 1)
            {
                _context.Add(matricularCurso);
                await _context.SaveChangesAsync();
                return matricularCurso;
            }
            return null;
        }


    }
}
