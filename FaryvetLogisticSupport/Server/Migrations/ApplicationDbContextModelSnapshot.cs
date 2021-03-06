﻿// <auto-generated />
using System;
using FaryvetLogisticSupport.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FaryvetLogisticSupport.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("FARYVET")
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FaryvetLogisticSupport.Shared.Models.Conductor", b =>
                {
                    b.Property<string>("cedula")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("apellido1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("apellido2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fechaDeContratacion")
                        .HasColumnType("date");

                    b.Property<DateTime>("fechaVencimientoA")
                        .HasColumnType("date");

                    b.Property<DateTime>("fechaVencimientoB")
                        .HasColumnType("date");

                    b.Property<int>("licenciaA")
                        .HasColumnType("int");

                    b.Property<int>("licenciaB")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("cedula");

                    b.ToTable("FLS_Conductores");
                });

            modelBuilder.Entity("FaryvetLogisticSupport.Shared.Models.DivisionGeografica", b =>
                {
                    b.Property<int>("codigoPostal")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ubicacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("codigoPostal");

                    b.ToTable("FLS_DisionesGeograficas");
                });

            modelBuilder.Entity("FaryvetLogisticSupport.Shared.Models.Entrega", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("chofer")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("comentarios")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("comentariosLlegada")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("costo")
                        .HasColumnType("real");

                    b.Property<float>("costoOperativo")
                        .HasColumnType("real");

                    b.Property<string>("estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fechaLlegada")
                        .HasColumnType("date");

                    b.Property<DateTime>("fechaSalida")
                        .HasColumnType("date");

                    b.Property<float>("kilometrajeLlegada")
                        .HasColumnType("real");

                    b.Property<float>("kilometrajeSalida")
                        .HasColumnType("real");

                    b.Property<float>("peso")
                        .HasColumnType("real");

                    b.Property<bool>("recargaCombustible")
                        .HasColumnType("bit");

                    b.Property<string>("vehiculo")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("id");

                    b.HasIndex("chofer");

                    b.HasIndex("vehiculo");

                    b.ToTable("FLS_Entregas");
                });

            modelBuilder.Entity("FaryvetLogisticSupport.Shared.Models.Factura", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("comentarios")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("entrega")
                        .HasColumnType("int");

                    b.Property<string>("estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("date");

                    b.Property<string>("formaCobro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("formaDespacho")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("moneda")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("montoTotal")
                        .HasColumnType("real");

                    b.Property<string>("nombreCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("pesoTotal")
                        .HasColumnType("real");

                    b.Property<int>("ubicacion")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("entrega");

                    b.HasIndex("ubicacion");

                    b.ToTable("FLS_Facturas");
                });

            modelBuilder.Entity("FaryvetLogisticSupport.Shared.Models.Vehiculo", b =>
                {
                    b.Property<string>("placa")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("CVOSenasa")
                        .HasColumnType("bit");

                    b.Property<int>("annioFabricacion")
                        .HasColumnType("int");

                    b.Property<float>("capacidadCarga")
                        .HasColumnType("real");

                    b.Property<string>("estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fechaVencimientoCVOSenasa")
                        .HasColumnType("date");

                    b.Property<DateTime>("fechaVencimientoSalidaPais")
                        .HasColumnType("date");

                    b.Property<bool>("isReparto")
                        .HasColumnType("bit");

                    b.Property<string>("licenciaRequerida")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("salidaPais")
                        .HasColumnType("bit");

                    b.HasKey("placa");

                    b.ToTable("FLS_Vehiculos");
                });

            modelBuilder.Entity("FaryvetLogisticSupport.Shared.Models.Entrega", b =>
                {
                    b.HasOne("FaryvetLogisticSupport.Shared.Models.Conductor", "ConductorNavigation")
                        .WithMany("Entregas")
                        .HasForeignKey("chofer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FaryvetLogisticSupport.Shared.Models.Vehiculo", "VehiculoNavigation")
                        .WithMany("Entregas")
                        .HasForeignKey("vehiculo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FaryvetLogisticSupport.Shared.Models.Factura", b =>
                {
                    b.HasOne("FaryvetLogisticSupport.Shared.Models.Entrega", "EntregaNavigation")
                        .WithMany("Facturas")
                        .HasForeignKey("entrega");

                    b.HasOne("FaryvetLogisticSupport.Shared.Models.DivisionGeografica", "DivisionGeograficaNavigation")
                        .WithMany("Facturas")
                        .HasForeignKey("ubicacion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
