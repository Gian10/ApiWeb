using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiWeb.Models;
using ApiWeb.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiWeb.Controllers
{
    // CONTROLLER PARA REALIZAÇÃO DE TESTES

    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioFakeController : ControllerBase
    {

        private readonly IUsuarioServiceFake usuarioServiceFake;

        public UsuarioFakeController(IUsuarioServiceFake iUsuarioServiceFake)
        {
            usuarioServiceFake = iUsuarioServiceFake;
        }


        [HttpGet]
        public async Task<ActionResult<List<Usuario>>> GetUsuariosFake()
        {
            var list = await usuarioServiceFake.ListarUsuarioFake();
            return Ok(list);

        }

        [HttpPost]
        public async Task<ActionResult<Usuario>> CriarUsuarioFake(Usuario usuario)
        {
            var retorno = await usuarioServiceFake.CriarUsuario(usuario);
            return CreatedAtAction(nameof(GetUsuariosFake), new { id = retorno.UsuarioId }, retorno);

        }
    }
}
