using ApiWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiWeb.Services
{
    // INTERFACE
    public interface IUsuarioService
    {

        Task<List<Usuario>> ListarUsuario();

        Task<Usuario> CriarUsuario(Usuario usuario);



    }
}
