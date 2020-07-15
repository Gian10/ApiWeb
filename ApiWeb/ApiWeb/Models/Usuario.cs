using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace ApiWeb.Models
{
    public class Usuario
    {

       public int UsuarioId {get; set; }
       public string Nome { get; set; }
       public string Matricula { get; set;}

        public Usuario()
        {
        }

        public Usuario(int usuarioId, string nome, string matricula)
        {
            this.UsuarioId = usuarioId;
            this.Nome = nome;
            this.Matricula = matricula;
        }

    }
}
