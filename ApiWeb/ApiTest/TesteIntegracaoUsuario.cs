using ApiWeb;
using ApiWeb.Models;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ApiTest
{
    // USANDO XUNIT E FluentAssertions PARA TESTE DE INTEGRAÇÃO
    public class TesteIntegracaoUsuario
    {

        private readonly HttpClient httpClient;

        public TesteIntegracaoUsuario()
        {
            // Configurar os testes
            var appHttpCliente = new WebApplicationFactory<Startup>();
            httpClient = appHttpCliente.CreateClient();

        }

        // TESTANDO A ROTA DA SOLICITAÇÃO PARA VER SE O RETORNO DA SOLICITAÇÃO É 200 OK
        [Fact]
        public async Task GetUsuario()
        {
            // Act onde o teste é execultado
            var response = await httpClient.GetAsync("/api/usuarioFake");
            response.StatusCode.Should().Be(HttpStatusCode.OK);

            // Assert para verificar a ação do teste
            var usuario = JsonConvert.DeserializeObject<List<Usuario>>(await response.Content.ReadAsStringAsync());
            usuario.Should();
        }


        // TESTE QUE SIMULA A SOLICITAÇÃO POST DE USUARIO
        [Fact]
        public async Task PostUsuario()
        {
            // ARRANGE
            var testeCreate = new Usuario()
            {
                UsuarioId = 3,
                Nome = "Giiiiiannn",
                Matricula = "888888"
            };

            // ACT
            var response = await httpClient.PostAsync("/api/usuarioFake", ContentHelper.GetStringContent(testeCreate));
            // ASSERT
            response.EnsureSuccessStatusCode();
        }


    }
}
