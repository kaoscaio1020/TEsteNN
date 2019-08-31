using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TEsteNN.Models;

namespace TEsteNN.Models
{
    public class TesteNNContext : DbContext
    {
        public TesteNNContext(DbContextOptions<TesteNNContext> options) : base(options)
        {

        }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Estudante> Estudante { get; set; }
        public virtual DbSet<CursoEstudante> CursosEstudantes { get; set; }
    }
}
