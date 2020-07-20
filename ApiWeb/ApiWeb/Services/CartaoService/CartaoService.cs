using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiWeb.Services.CartaoService
{
    // CLASSE DE SERVIÇO DE CARTÃO LIGADO AO BANCO DE DADOS
    public class CartaoService
    {

        private readonly UsuarioContext _context;

        public CartaoService(UsuarioContext context)
        {
            _context = context;
        }

        public async Task<List<Cartao>> ListarCartao()
        {
            var listaCartao = _context.Cartao.ToListAsync();
            return await listaCartao;
        }

        public async Task<Cartao> InserirCartao(Cartao cartaoModel)
        {
            _context.Add(cartaoModel);
            await _context.SaveChangesAsync();
            return cartaoModel;
        }

    }
}
