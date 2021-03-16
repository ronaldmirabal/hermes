﻿// <auto-generated />
using System;
using Hermes.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hermes.Api.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Hermes.Api.Models.Articulo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Articulos");
                });

            modelBuilder.Entity("Hermes.Api.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Identificacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Hermes.Api.Models.Detallefactura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("IdArticulo")
                        .HasColumnType("int");

                    b.Property<int?>("IdArticuloNavigationId")
                        .HasColumnType("int");

                    b.Property<int>("IdFactura")
                        .HasColumnType("int");

                    b.Property<int?>("IdFacturaNavigationId")
                        .HasColumnType("int");

                    b.Property<decimal>("Itbis")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("IdArticuloNavigationId");

                    b.HasIndex("IdFacturaNavigationId");

                    b.ToTable("Detallefacturas");
                });

            modelBuilder.Entity("Hermes.Api.Models.Factura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int?>("IdClienteNavigationId")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("IdClienteNavigationId");

                    b.ToTable("Facturas");
                });

            modelBuilder.Entity("Hermes.Api.Models.Detallefactura", b =>
                {
                    b.HasOne("Hermes.Api.Models.Articulo", "IdArticuloNavigation")
                        .WithMany("Detallefacturas")
                        .HasForeignKey("IdArticuloNavigationId");

                    b.HasOne("Hermes.Api.Models.Factura", "IdFacturaNavigation")
                        .WithMany("Detallefacturas")
                        .HasForeignKey("IdFacturaNavigationId");

                    b.Navigation("IdArticuloNavigation");

                    b.Navigation("IdFacturaNavigation");
                });

            modelBuilder.Entity("Hermes.Api.Models.Factura", b =>
                {
                    b.HasOne("Hermes.Api.Models.Cliente", "IdClienteNavigation")
                        .WithMany("Facturas")
                        .HasForeignKey("IdClienteNavigationId");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("Hermes.Api.Models.Articulo", b =>
                {
                    b.Navigation("Detallefacturas");
                });

            modelBuilder.Entity("Hermes.Api.Models.Cliente", b =>
                {
                    b.Navigation("Facturas");
                });

            modelBuilder.Entity("Hermes.Api.Models.Factura", b =>
                {
                    b.Navigation("Detallefacturas");
                });
#pragma warning restore 612, 618
        }
    }
}
