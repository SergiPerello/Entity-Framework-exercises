﻿// <auto-generated />
using System;
using EF_ComicsDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EF_ComicsDB.Migrations
{
    [DbContext(typeof(ComicContext))]
    [Migration("20190905080521_EF_ComicsDB")]
    partial class EF_ComicsDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EF_ComicsDB.Autor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("Name");

                    b.Property<string>("Nationality");

                    b.HasKey("Id");

                    b.ToTable("Autors");
                });

            modelBuilder.Entity("EF_ComicsDB.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("EF_ComicsDB.Comic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoriaId");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<int>("NumberPages");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Comics");
                });

            modelBuilder.Entity("EF_ComicsDB.Comic_Autor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AutorId");

                    b.Property<int?>("ComicId");

                    b.Property<string>("Rol");

                    b.HasKey("Id");

                    b.HasIndex("AutorId");

                    b.HasIndex("ComicId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("EF_ComicsDB.Comic", b =>
                {
                    b.HasOne("EF_ComicsDB.Categoria", "Categoria")
                        .WithMany("Comics")
                        .HasForeignKey("CategoriaId");
                });

            modelBuilder.Entity("EF_ComicsDB.Comic_Autor", b =>
                {
                    b.HasOne("EF_ComicsDB.Autor", "Autor")
                        .WithMany("Roles")
                        .HasForeignKey("AutorId");

                    b.HasOne("EF_ComicsDB.Comic", "Comic")
                        .WithMany()
                        .HasForeignKey("ComicId");
                });
#pragma warning restore 612, 618
        }
    }
}