using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiWeb.Models
{
    public class MatricularCurso
    {
        [Key]
        public int MatricularCursoId { get; set; }

        public double ValorTotalCurso { get; set; }
        public int QtdPagamentoUsuario { get; set; }


        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }


        [ForeignKey("Cartao")]
        public int CartaoId { get; set; }
        public Cartao Cartao { get; set; }


        [ForeignKey("Curso")]
        public int CursoId { get; set; }
        public Curso Curso { get; set; }

        public MatricularCurso()
        {
        }

        public MatricularCurso(int matricularCursoId, double valorTotalCurso, int qtdPagamentoUsuario, int usuarioId, int cartaoId, int cursoId)
        {
            MatricularCursoId = matricularCursoId;
            ValorTotalCurso = valorTotalCurso;
            QtdPagamentoUsuario = qtdPagamentoUsuario;
            UsuarioId = usuarioId;
            CartaoId = cartaoId;
            CursoId = cursoId;
        }
    }
}
