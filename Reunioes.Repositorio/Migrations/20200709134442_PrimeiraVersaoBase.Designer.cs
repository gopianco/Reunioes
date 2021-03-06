﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Reunioes.Repositorio.Contexto;

namespace Reunioes.Repositorio.Migrations
{
    [DbContext(typeof(ReunioesContexto))]
    [Migration("20200709134442_PrimeiraVersaoBase")]
    partial class PrimeiraVersaoBase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Reunioes.Dominio.Entidades.Reuniao", b =>
                {
                    b.Property<int>("ReuniaoId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataHoraFim");

                    b.Property<DateTime>("DataHoraInicio");

                    b.Property<int>("SalaId");

                    b.Property<string>("Titulo")
                        .IsRequired();

                    b.HasKey("ReuniaoId");

                    b.HasIndex("SalaId");

                    b.ToTable("Reunioes");
                });

            modelBuilder.Entity("Reunioes.Dominio.Entidades.Sala", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Salas");
                });

            modelBuilder.Entity("Reunioes.Dominio.Entidades.Reuniao", b =>
                {
                    b.HasOne("Reunioes.Dominio.Entidades.Sala", "Sala")
                        .WithMany("Reunioes")
                        .HasForeignKey("SalaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
