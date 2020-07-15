using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiWeb;
using ApiWeb.Models;
using System.Collections;
using ApiWeb.Services;

namespace ApiWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        
        private readonly IUsuarioService _iUsuarioService;


        [HttpGet]
        public async Task<ActionResult<List<Usuario>>> GetUsuarios()
        {
            return Ok(await _iUsuarioService.ListarUsuario());
            
        }



        [HttpPost]
        public async Task<ActionResult<Usuario>> PostUsuario(Usuario usuario)
        {
            var retorno = await _iUsuarioService.CriarUsuario(usuario);
            //return StatusCode(201);
            return CreatedAtAction("GetUsuarios", new { id = retorno.UsuarioId }, retorno);
        }



    }
}
