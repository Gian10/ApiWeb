﻿using ApiWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiWeb
{
    public class UsuarioContext : DbContext
    {

        public UsuarioContext(DbContextOptions<UsuarioContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get ; set ;}

        public DbSet<Cartao> Cartao { get; set; }

        public DbSet<Curso> Curso { get; set; }

        public DbSet<ApiWeb.Models.MatricularCurso> MatricularCurso { get; set; }


    }
}
