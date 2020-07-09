using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reunioes.Dominio.Entidades;

namespace Reunioes.Repositorio.Config
{
    public class SalaConfiguration : IEntityTypeConfiguration<Sala>
    {
        public SalaConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<Sala> builder)
        {
            builder.HasKey(s => s.Id);
            builder
                .Property(s => s.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .HasMany(s => s.Reunioes)
                .WithOne(r => r.Sala);


        }
    }
}
