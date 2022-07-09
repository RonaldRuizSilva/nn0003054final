
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using n00033054app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace n00033054app.BD.Maping
{
    public class CuentaMaping : IEntityTypeConfiguration<Cuenta>
    {
        public void Configure(EntityTypeBuilder<Cuenta> builder)
        {
            builder.ToTable("Cuenta");
            builder.HasKey(o => o.id);

            builder.HasMany<Gasto>(o=>o.gastos).WithOne().HasForeignKey(o=>o.cuentaid);
            builder.HasMany<Ingreso>(o => o.ingresos).WithOne().HasForeignKey(o => o.cuentaid);
        }
    }
}
