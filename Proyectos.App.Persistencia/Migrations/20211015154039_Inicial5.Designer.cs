﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proyectos.App.Persistencia.AppRepositorios;

namespace Proyectos.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20211015154039_Inicial5")]
    partial class Inicial5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Proyectos.App.Dominio.Equipo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("formador")
                        .HasColumnType("int");

                    b.Property<string>("meet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tutor")
                        .HasColumnType("int");

                    b.Property<string>("whatapp")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Equipos");
                });

            modelBuilder.Entity("Proyectos.App.Dominio.EstadoProyecto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("EstadoProyectos");
                });

            modelBuilder.Entity("Proyectos.App.Dominio.EstadoTarea", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("EstadoTareas");
                });

            modelBuilder.Entity("Proyectos.App.Dominio.Estudiante", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("identificacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("movil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Estudiantes");
                });

            modelBuilder.Entity("Proyectos.App.Dominio.Formador", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("identificacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Formadores");
                });

            modelBuilder.Entity("Proyectos.App.Dominio.Rol", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Proyectos.App.Dominio.Tutor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("identificacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Tutores");
                });
#pragma warning restore 612, 618
        }
    }
}
