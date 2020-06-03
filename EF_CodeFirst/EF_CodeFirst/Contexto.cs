using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_CodeFirst
{
    class Contexto : DbContext
    {
        public Contexto()
        {
            this.Database.Migrate();
        }
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Jardin;Trusted_Connection=True;");
            }
        }
        public DbSet<Planta> Plantas { get; set; }

    }
}
