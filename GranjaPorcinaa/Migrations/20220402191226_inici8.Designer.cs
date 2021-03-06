// <auto-generated />
using System;
using GranjaPorcinaa.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GranjaPorcinaa.Migrations
{
    [DbContext(typeof(AplicationDBContext))]
    [Migration("20220402191226_inici8")]
    partial class inici8
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-preview.2.22153.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("GranjaPorcinaa.Models.Cerditos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateIngreso")
                        .HasColumnType("Date");

                    b.Property<DateTime>("DateNacimiento")
                        .HasColumnType("Date");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("NumCorral")
                        .HasColumnType("integer");

                    b.Property<int>("Peso")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Cerditos");
                });

            modelBuilder.Entity("GranjaPorcinaa.Models.Vacunas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateVacuna")
                        .HasColumnType("Date");

                    b.Property<int>("IdCer")
                        .HasColumnType("integer");

                    b.Property<string>("NomVacu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Vacunas");
                });

            modelBuilder.Entity("GranjaPorcinaa.Models.Ventas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateVenta")
                        .HasColumnType("Date");

                    b.Property<int>("Idcer")
                        .HasColumnType("integer");

                    b.Property<string>("NomComp")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Presio")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Ventas");
                });
#pragma warning restore 612, 618
        }
    }
}
