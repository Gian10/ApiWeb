using ApiWeb;
using ApiWeb.Models;
using ApiWeb.Services;
using FluentAssertions;
using Google.Protobuf.WellKnownTypes;
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
    public class TesteIntegracao 
    {

        private readonly HttpClient httpClient;

        public TesteIntegracao()
        {
            var appHttpCliente = new WebApplicationFactory<Startup>();
            httpClient = appHttpCliente.CreateClient();
        }

        [Fact]
        public async Task Teste1()
        {
            var response = await httpClient.GetAsync("/api/usuarios");
            response.StatusCode.Should().Be(HttpStatusCode.OK);


            var usuario = JsonConvert.DeserializeObject<Usuario>(await response.Content.ReadAsStringAsync());
            usuario.Should();
        }
    }
}
