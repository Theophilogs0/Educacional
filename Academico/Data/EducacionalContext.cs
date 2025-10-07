﻿using Academico.Models;
using Microsoft.EntityFrameworkCore;

namespace Academico.Data
{
    public class EducacionalContext : DbContext
    {
        public EducacionalContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Instituicao> Instituicoes { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Departamento> Alunos { get; set; }
        public DbSet<Academico.Models.Curso> Curso { get; set; } = default!;
    }
}
