using ApiWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiWeb.Services
{
    // CLASSE DE SERVIÇO LIGADO AO BANCO DE DADOS
    public class UsuarioService : IUsuarioService
    {
        public readonly UsuarioContext usuarioContext;
        

        public UsuarioService(UsuarioContext context)
        {
            usuarioContext = context;

        }


        Task<List<Usuario>> IUsuarioService.ListarUsuario()
        {
            var listaUsuario =  usuarioContext.Usuarios.ToListAsync();
            return listaUsuario;
        }



        async Task<Usuario> IUsuarioService.CriarUsuario(Usuario usuario)
        {
            usuarioContext.Add(usuario);
            await usuarioContext.SaveChangesAsync();
            return usuario;
        }



    }
}
