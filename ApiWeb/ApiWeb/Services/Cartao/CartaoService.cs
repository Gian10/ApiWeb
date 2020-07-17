using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiWeb.Services.Cartao
{
    public class CartaoService
    {

        private readonly UsuarioContext _context;

        public CartaoService(UsuarioContext context)
        {
            _context = context;
        }

        public async Task<List<CartaoModel>> ListarCartao()
        {
            var listaCartao = _context.Cartao.ToListAsync();
            return await listaCartao;
        }

        public async Task<CartaoModel> InserirCartao(CartaoModel cartaoModel)
        {
            _context.Add(cartaoModel);
            await _context.SaveChangesAsync();
            return cartaoModel;
        }

    }
}
