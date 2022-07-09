
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using n00033054app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace n00033054app.BD.Maping
{
    public class IngresoMaping : IEntityTypeConfiguration<Ingreso>
    {
        public void Configure(EntityTypeBuilder<Ingreso> builder)
        {
            builder.ToTable("Ingresos");
            builder.HasKey(o => o.id);
            builder.HasOne(o => o.cuenta).WithMany().HasForeignKey(o => o.cuentaid);
        }

    }
}
