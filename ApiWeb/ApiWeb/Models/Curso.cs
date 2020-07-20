using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiWeb.Models
{
    public class Curso
    {
        [Key]
        public int CursoId { get; set; }
        public string NomeCurso { get; set; }
        public double ValorCurso { get; set; }

        public Curso(int cursoId, string nomeCurso, double valorCurso)
        {
            CursoId = cursoId;
            NomeCurso = nomeCurso;
            ValorCurso = valorCurso;
        }
    }

}
