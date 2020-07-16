using ApiWeb.Controllers;
using ApiWeb.Models;
using ApiWeb.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ApiTest
{
    // USANDO XUNIT PARA TESTES DE UNIDADE DE USUARIO
   public class TesteUnidadeUsuario
    {

        UsuarioFakeController usuariosController;
        IUsuarioServiceFake usuarioServiceFake;

        public TesteUnidadeUsuario()
        {

            usuarioServiceFake = new UsuarioServiceFake();
            usuariosController = new UsuarioFakeController(usuarioServiceFake);
        }


        // Métodos de Get e Post para confirmar se o stutas da requisição é o esperado

        [Fact]
        public async Task GetReturnsOkResult()
        {
            var okResult = await usuariosController.GetUsuariosFake();
            Assert.IsType<OkObjectResult>(okResult.Result);

        }

        [Fact]
        public async Task CreateResponse()
        {
            var testeCreate = new Usuario()
            {
                UsuarioId = 3,
                Nome = "Giiiiiannn",
                Matricula = "888888"
            };

            var createResponse = await usuariosController.CriarUsuarioFake(testeCreate);
            Assert.IsType<CreatedAtActionResult>(createResponse.Result);
        }
    }
}
