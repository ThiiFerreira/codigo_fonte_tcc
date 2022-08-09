using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using teste.tcc.Models;

namespace teste.tcc.data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base (opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
        }

        public DbSet<Responsavel> Responsavel { get; set; }
        public DbSet<UserResponsavel> UserResponsavel { get; set; }
        public DbSet<Idoso> Idoso { get; set; }
        public DbSet<Tarefa> Tarefa { get; set; }

    }
}
