using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiWeb;
using ApiWeb.Models;
using ApiWeb.Services.CartaoService;

namespace ApiWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartaosController : ControllerBase
    {

        private readonly CartaoService _cartaoService;

        public CartaosController(CartaoService cartaoService)
        {
            _cartaoService = cartaoService;
        }


        // GET: api/Cartaos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cartao>>> GetCartao()
        {
            return Ok( await _cartaoService.ListarCartao());
        }


        [HttpPost]
        public async Task<ActionResult<Cartao>> PostCartao(Cartao cartao)
        {
            var objCartao = await _cartaoService.InserirCartao(cartao);
            return CreatedAtAction("GetCartao", new { id = objCartao.CartaoId }, objCartao);
        }

    }
}
