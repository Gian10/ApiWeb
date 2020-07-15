using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.CodeAnalysis.Options;
using Swashbuckle.AspNetCore.Swagger;
using Microsoft.OpenApi.Models;
using ApiWeb.Services;
using ApiWeb.Controllers;
using Microsoft.AspNetCore.Http;

namespace ApiWeb
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddDbContext<UsuarioContext>(options =>
            //options.UseMySql(Configuration.GetConnectionString("UsuarioContext"), builder =>
            //builder.MigrationsAssembly("ApiWeb")));

            
            // service para salvar o context em memoria
            services.AddDbContext<UsuarioContext>(opt => opt.UseInMemoryDatabase("UsuarioList"));


            services.AddControllers().AddNewtonsoftJson();
           
            
            services.AddScoped<UsuarioServiceFake>();
            services.AddScoped<IUsuarioService, UsuarioService>();


            

            // baixar o  Swashbuckle.AspNetCore para usar o swagger

            services.AddSwaggerGen((options) =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Teste Apiii",
                    Version = "v1",
                    Description = "Exemplo de API REST criada com o ASP.NET Core 3.1",
                    Contact = new OpenApiContact
                    {
                        Name = "Gian Karlos",
                        //Url = new Uri("https://github.com/renatogroffe")
                    }
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            // Ativando middlewares para uso do Swagger
            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Teste api V1");
            });



            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
