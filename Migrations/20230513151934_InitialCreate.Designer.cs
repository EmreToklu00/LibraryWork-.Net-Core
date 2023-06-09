﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using librarywork.src.context;

#nullable disable

namespace librarywork.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20230513151934_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("librarywork.src.models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("librarywork.src.models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("PublishYear")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
