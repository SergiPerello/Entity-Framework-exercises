using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Aeropuerto
{
    class DBContext : DbContext
    {
        public DBContext()
        {
            this.Database.Migrate();
        }
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=hormiguero3;Trusted_Connection=True;");
            }
        }
        public DbSet<Hormiga> Hormigas { get; set; }

    }
}
