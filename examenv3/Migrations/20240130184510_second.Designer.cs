﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using examenv3.contextModels;

#nullable disable

namespace examenv3.Migrations
{
    [DbContext(typeof(EmisiuneContext))]
    [Migration("20240130184510_second")]
    partial class second
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("examenv3.Models.Canal_TV", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("canale");
                });

            modelBuilder.Entity("examenv3.Models.Emisiune", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AnLansare")
                        .HasColumnType("int");

                    b.Property<int>("CanalId")
                        .HasColumnType("int");

                    b.Property<int>("Canal_TVId")
                        .HasColumnType("int");

                    b.Property<string>("Gen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Producator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titlu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Canal_TVId");

                    b.ToTable("emisiuni");
                });

            modelBuilder.Entity("examenv3.Models.Emisiune", b =>
                {
                    b.HasOne("examenv3.Models.Canal_TV", "Canal_TV")
                        .WithMany()
                        .HasForeignKey("Canal_TVId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Canal_TV");
                });
#pragma warning restore 612, 618
        }
    }
}