
using Microsoft.EntityFrameworkCore;
using n00033054app.BD.Maping;
using n00033054app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace n00033054app.BD
{
    public class DbEntities : DbContext
    {
        public DbSet<Cuenta> Cuentas { get; set; }
        public DbSet<Ingreso> GetIngresos { get; set; }
        public DbSet<Gasto> GetGastos { get; set; }

        public DbEntities(DbContextOptions<DbEntities> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Configuracion de tablas

            modelBuilder.ApplyConfiguration(new CuentaMaping());
            modelBuilder.ApplyConfiguration(new IngresoMaping());
            modelBuilder.ApplyConfiguration(new Gastosmaping());
        
        }
    }
}
