using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using BeautyCenterCore.Models;

namespace BeautyCenterCore.Migrations
{
    [DbContext(typeof(BeautyCoreDb))]
    partial class BeautyCoreDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BeautyCenterCore.Models.Citas", b =>
                {
                    b.Property<int>("CitaId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CantPersonas");

                    b.Property<int>("ClienteId");

                    b.Property<DateTime>("Fecha");

                    b.Property<string>("Nombres")
                        .IsRequired();

                    b.Property<string>("Servicio")
                        .IsRequired();

                    b.HasKey("CitaId");

                    b.ToTable("Citas");
                });

            modelBuilder.Entity("BeautyCenterCore.Models.Clientes", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cedula")
                        .IsRequired();

                    b.Property<string>("Ciudad");

                    b.Property<string>("Direccion")
                        .IsRequired();

                    b.Property<DateTime>("FechaNac");

                    b.Property<string>("Nombres")
                        .IsRequired();

                    b.Property<string>("Provincia");

                    b.Property<string>("Telefono")
                        .IsRequired();

                    b.HasKey("ClienteId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("BeautyCenterCore.Models.DetalleCitas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CitaId");

                    b.Property<int>("ClienteId");

                    b.Property<string>("Nombres")
                        .IsRequired();

                    b.Property<string>("Servicio");

                    b.HasKey("Id");

                    b.ToTable("DetalleCitas");
                });

            modelBuilder.Entity("BeautyCenterCore.Models.Empleados", b =>
                {
                    b.Property<int>("EmpleadoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cedula")
                        .IsRequired();

                    b.Property<string>("Ciudad");

                    b.Property<string>("Direccion")
                        .IsRequired();

                    b.Property<DateTime>("FecaNac");

                    b.Property<string>("Nombres")
                        .IsRequired();

                    b.Property<string>("Provincia");

                    b.Property<decimal>("SueldoFijo");

                    b.Property<string>("Telefono")
                        .IsRequired();

                    b.HasKey("EmpleadoId");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("BeautyCenterCore.Models.FacturaDetalles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Costo");

                    b.Property<double>("Descuento");

                    b.Property<int>("FacturaId");

                    b.Property<string>("ServicioId");

                    b.Property<double>("SubTotal");

                    b.HasKey("Id");

                    b.ToTable("FacturaDetalles");
                });

            modelBuilder.Entity("BeautyCenterCore.Models.Facturas", b =>
                {
                    b.Property<int>("FacturaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClienteId");

                    b.Property<DateTime>("Fecha");

                    b.Property<decimal>("Total");

                    b.HasKey("FacturaId");

                    b.ToTable("Facturas");
                });

            modelBuilder.Entity("BeautyCenterCore.Models.Servicios", b =>
                {
                    b.Property<int>("ServicioId")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Costo");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("ServicioId");

                    b.ToTable("Servicios");
                });

            modelBuilder.Entity("BeautyCenterCore.Models.UserAccount", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConfirmPassword");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("Username")
                        .IsRequired();

                    b.HasKey("UserID");

                    b.ToTable("userAccount");
                });
        }
    }
}
