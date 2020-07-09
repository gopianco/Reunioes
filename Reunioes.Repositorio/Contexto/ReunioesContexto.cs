using System;
using Microsoft.EntityFrameworkCore;
using Reunioes.Dominio.Entidades;
using Reunioes.Repositorio.Config;

namespace Reunioes.Repositorio.Contexto
{
    public class ReunioesContexto : DbContext
    {
        public DbSet<Reuniao> Reunioes { get; set; }
        public DbSet<Sala> Salas { get; set; }

        public ReunioesContexto(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new SalaConfiguration());
            modelBuilder.ApplyConfiguration(new ReuniaoConfiguration());

            base.OnModelCreating(modelBuilder);
        }

    }
}
