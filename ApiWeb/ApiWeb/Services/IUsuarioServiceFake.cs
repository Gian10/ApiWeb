using ApiWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiWeb.Services
{
    public interface IUsuarioServiceFake
    {

        Task<List<Usuario>> ListarUsuarioFake();

        Task<Usuario> CriarUsuario(Usuario usuario);
    }
}
