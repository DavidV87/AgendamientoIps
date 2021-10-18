﻿// <auto-generated />
using System;
using Agendamiento.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Agendamiento.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20211018183948_Azure")]
    partial class Azure
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Agendamiento.App.Dominio.Agenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("FechaCita")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MedicoId")
                        .HasColumnType("int");

                    b.Property<string>("Nota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PacienteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MedicoId");

                    b.HasIndex("PacienteId");

                    b.ToTable("Agendas");
                });

            modelBuilder.Entity("Agendamiento.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ciudad")
                        .HasColumnType("int");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("Agendamiento.App.Dominio.SedeIps", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Ciudad")
                        .HasColumnType("int");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sedesips");
                });

            modelBuilder.Entity("Agendamiento.App.Dominio.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Agendamiento.App.Dominio.Medico", b =>
                {
                    b.HasBaseType("Agendamiento.App.Dominio.Persona");

                    b.Property<int>("Especialidad")
                        .HasColumnType("int");

                    b.Property<int?>("SedeIpsId")
                        .HasColumnType("int")
                        .HasColumnName("Medico_SedeIpsId");

                    b.Property<string>("TarjetaPro")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("SedeIpsId");

                    b.HasDiscriminator().HasValue("Medico");
                });

            modelBuilder.Entity("Agendamiento.App.Dominio.Paciente", b =>
                {
                    b.HasBaseType("Agendamiento.App.Dominio.Persona");

                    b.Property<int?>("SedeIpsId")
                        .HasColumnType("int");

                    b.HasIndex("SedeIpsId");

                    b.HasDiscriminator().HasValue("Paciente");
                });

            modelBuilder.Entity("Agendamiento.App.Dominio.Agenda", b =>
                {
                    b.HasOne("Agendamiento.App.Dominio.Medico", "Medico")
                        .WithMany()
                        .HasForeignKey("MedicoId");

                    b.HasOne("Agendamiento.App.Dominio.Paciente", "Paciente")
                        .WithMany()
                        .HasForeignKey("PacienteId");

                    b.Navigation("Medico");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("Agendamiento.App.Dominio.Persona", b =>
                {
                    b.HasOne("Agendamiento.App.Dominio.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Agendamiento.App.Dominio.Medico", b =>
                {
                    b.HasOne("Agendamiento.App.Dominio.SedeIps", "SedeIps")
                        .WithMany()
                        .HasForeignKey("SedeIpsId");

                    b.Navigation("SedeIps");
                });

            modelBuilder.Entity("Agendamiento.App.Dominio.Paciente", b =>
                {
                    b.HasOne("Agendamiento.App.Dominio.SedeIps", "SedeIps")
                        .WithMany()
                        .HasForeignKey("SedeIpsId");

                    b.Navigation("SedeIps");
                });
#pragma warning restore 612, 618
        }
    }
}