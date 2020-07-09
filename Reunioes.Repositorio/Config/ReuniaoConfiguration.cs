using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reunioes.Dominio.Entidades;

namespace Reunioes.Repositorio.Config
{
    public class ReuniaoConfiguration : IEntityTypeConfiguration<Reuniao>
    {
        public ReuniaoConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<Reuniao> builder)
        {
            builder.HasKey(r => r.ReuniaoId);
            builder.Property(r => r.DataHoraFim)
                .IsRequired();
            builder.Property(r => r.DataHoraInicio)
                .IsRequired();
            builder.Property(r => r.Titulo)
                .IsRequired();

        }
    }
}
