// <auto-generated />
using System;
using Desafio_Backend.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Desafio_Backend.Migrations
{
    [DbContext(typeof(DesafioContext))]
    [Migration("20221114234446_Primeira")]
    partial class Primeira
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Desafio_Backend.Models.Autor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("descricao")
                        .HasColumnType("text");

                    b.Property<string>("nome")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Autor");
                });

            modelBuilder.Entity("Desafio_Backend.Models.Genero", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("descricao")
                        .HasColumnType("text");

                    b.Property<string>("nome")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Genero");
                });

            modelBuilder.Entity("Desafio_Backend.Models.Livro", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<decimal>("avaliacao")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("dataCadastro")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("dataPublicacao")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("descricao")
                        .HasColumnType("text");

                    b.Property<int>("edicao")
                        .HasColumnType("integer");

                    b.Property<int>("idGenero")
                        .HasColumnType("integer");

                    b.Property<string>("nome")
                        .HasColumnType("text");

                    b.Property<string>("urlCapa")
                        .HasColumnType("text");

                    b.Property<decimal>("valor")
                        .HasColumnType("numeric");

                    b.HasKey("id");

                    b.ToTable("Livro");
                });

            modelBuilder.Entity("Desafio_Backend.Models.Livro_Autor", b =>
                {
                    b.Property<int>("idAutor")
                        .HasColumnType("integer");

                    b.Property<int>("idLivro")
                        .HasColumnType("integer");

                    b.ToTable("Livro_Autor");
                });
#pragma warning restore 612, 618
        }
    }
}
