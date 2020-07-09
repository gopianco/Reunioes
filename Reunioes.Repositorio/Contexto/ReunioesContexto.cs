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

            modelBuilder.Entity<Sala>().HasData(
                new Sala()
                    {
                        Id = 1,
                        Nome = "Sala 01",
                    }
                );

            modelBuilder.Entity<Sala>().HasData(
                new Sala()
                {
                    Id = 2,
                    Nome = "Sala 02",
                }
                );

            modelBuilder.Entity<Sala>().HasData(
                new Sala()
                {
                    Id = 3,
                    Nome = "Sala 03",
                }
                );

            modelBuilder.Entity<Reuniao>().HasData(
                new Reuniao()
                {
                    ReuniaoId = 1,
                    DataHoraInicio = new DateTime(2020, 07, 09, 16, 20, 00),
                    DataHoraFim = new DateTime(2020, 07, 09, 17, 20, 00 ),
                    Titulo = "Reunião Diretoria Financeira",
                    SalaId = 1
                }
                );
            modelBuilder.Entity<Reuniao>().HasData(
               new Reuniao()
               {
                   ReuniaoId = 2,
                   DataHoraInicio = new DateTime(2020, 07, 09, 16, 20, 00),
                   DataHoraFim = new DateTime(2020, 07, 09, 17, 20, 00),
                   Titulo = "Reunião Diretoria Financeira",
                   SalaId = 2
               }
               );
            modelBuilder.Entity<Reuniao>().HasData(
              new Reuniao()
              {
                  ReuniaoId = 3,
                  DataHoraInicio = new DateTime(2020, 07, 10, 09, 00, 00),
                  DataHoraFim = new DateTime(2020, 07, 10, 10, 00, 00),
                  Titulo = "Reunião Diretoria Financeira",
                  SalaId = 1
              }
              );
            modelBuilder.Entity<Reuniao>().HasData(
             new Reuniao()
             {
                 ReuniaoId = 4,
                 DataHoraInicio = new DateTime(2020, 07, 10, 11, 30, 00),
                 DataHoraFim = new DateTime(2020, 07, 10, 12, 00, 00),
                 Titulo = "Reunião Diretoria Financeira",
                 SalaId = 1
             }
             );

            base.OnModelCreating(modelBuilder);
        }

    }
}
