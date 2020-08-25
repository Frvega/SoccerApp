using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoccerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerApp.Infrestuctura.Configurations
{
    public class JugadorConfiguration : IEntityTypeConfiguration<Jugador>
    {
        public void Configure(EntityTypeBuilder<Jugador> builder)
        {
            builder.ToTable("Jugadores");
            builder.HasKey(j => j.JugadorId);
            builder.Property(j => j.Nombre);
            builder.Property(j => j.ApellidoMaterno);
            builder.Property(j => j.ApellidoPaterno);
            builder.Property(j => j.Edad);

        }
    }
}
