using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_ComicsDB
{
    public class ComicContext : DbContext
    {
        public DbSet<Autor> Autors { get; set; }
        public DbSet<Categoria> Categories { get; set; }
        public DbSet<Comic> Comics { get; set; }
        public DbSet<Comic_Autor> Roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EF_ComicsDB;Trusted_Connection=True;");
        }
    }
}
