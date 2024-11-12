using ManchiEco.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManchiEco.EntityFramework
{
    public class ManchiEcoDbContext: DbContext
    {
        public ManchiEcoDbContext(DbContextOptions<ManchiEcoDbContext> options) : base(options)
        {
        }
        public DbSet<Cuota> Cuotas { get; set; }
        public DbSet<TipoCuota> TipoCuotas { get; set; }
        public DbSet<Ingreso> Ingresos{ get; set; }
        public DbSet<Ahorro> Ahorros { get; set; }
        public DbSet<Gusto> Gustos { get; set; }
        public DbSet<Porcentaje> Porcentajes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cuota>().ToTable("Cuotas");
            modelBuilder.Entity<TipoCuota>().ToTable("TipoCuotas");
            modelBuilder.Entity<Ingreso>().ToTable("Ingresos");
            modelBuilder.Entity<Ahorro>().ToTable("Ahorros");
            modelBuilder.Entity<Gusto>().ToTable("Gustos");
            modelBuilder.Entity<Porcentaje>().ToTable("Porcentajes");
        }
    }
}
