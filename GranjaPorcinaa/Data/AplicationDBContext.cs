using GranjaPorcinaa.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranjaPorcinaa.Data
{
    internal class AplicationDBContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database= GranjaPorcina;Username=postgres;password=epcom115ea");
            base.OnConfiguring(optionsBuilder);


        }
        public DbSet<Cerditos> Cerditos { get; set; }
        public DbSet<Ventas> Ventas { get; set; }
        public DbSet<Vacunas> Vacunas { get; set; }

    }
}
