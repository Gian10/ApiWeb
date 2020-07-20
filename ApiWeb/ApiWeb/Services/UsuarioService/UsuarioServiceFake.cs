using ApiWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiWeb.Services.UsuarioService
{
    //  CLASSE DE SERVIÇO FAKE PARA REALIZAÇÃO DE TESTES DE UNIDADE E INTEGRAÇÃO
    public class UsuarioServiceFake : IUsuarioServiceFake
    {
        private readonly List<Usuario> usuarios;

        public UsuarioServiceFake()
        {
            usuarios = new List<Usuario>()
            {
                new Usuario(){UsuarioId= 1, Nome = "Gian", Matricula = "0000"},
                new Usuario(){UsuarioId= 2, Nome = "Karlos", Matricula = "1111"},
                new Usuario(){UsuarioId= 3, Nome = "Sousa", Matricula = "2222"},
                new Usuario(){UsuarioId= 4, Nome = "Araujo", Matricula = "3333"},
                new Usuario(){UsuarioId= 5, Nome = "GKSA", Matricula = "4444"},
            };
        }

        public async Task<Usuario> CriarUsuarioFake(Usuario usuario)
        {
            usuarios.Add(usuario);
            return usuario;
        }

        public async Task<List<Usuario>> ListarUsuarioFake()
        {
            return usuarios;
        }

        
    }
}
