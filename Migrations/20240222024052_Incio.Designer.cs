﻿// <auto-generated />
using System;
using LionDev;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Backend.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240222024052_Incio")]
    partial class Incio
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LionDev.Models.Comprador", b =>
                {
                    b.Property<Guid>("IdComprador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Contrasena")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("CorreoElectronico")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasMaxLength(9)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(9)");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("NumeroDeDocumento")
                        .HasMaxLength(16)
                        .IsUnicode(true)
                        .HasColumnType("int");

                    b.Property<string>("Rol")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("TipoDeDocumento")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("IdComprador");

                    b.ToTable("Compradores");

                    b.HasData(
                        new
                        {
                            IdComprador = new Guid("876e1c21-42e3-45bb-bd56-291b5a6e6844"),
                            Apellidos = "Falcao",
                            Contrasena = "Rada1",
                            CorreoElectronico = "rada@gmail.com",
                            Direccion = "Calle 1",
                            Genero = "Masculino",
                            Nombres = "Radamel",
                            NumeroDeDocumento = 12345,
                            Rol = "Administrador",
                            TipoDeDocumento = "Cedula"
                        },
                        new
                        {
                            IdComprador = new Guid("abeed370-8e6e-4121-879d-bc982f5aaac4"),
                            Apellidos = "Rodriguez",
                            Contrasena = "James1",
                            CorreoElectronico = "james@gmail.com",
                            Direccion = "Calle 2",
                            Genero = "Masculino",
                            Nombres = "James",
                            NumeroDeDocumento = 12346,
                            Rol = "Empleado",
                            TipoDeDocumento = "Cedula"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}