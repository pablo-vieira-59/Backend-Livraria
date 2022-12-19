﻿// <auto-generated />
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
    [Migration("20221115033922_Correcao-Tabela-Livro_Autor")]
    partial class CorrecaoTabelaLivro_Autor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Desafio_Backend.Domain.Models.Autor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("descricao");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.HasKey("id");

                    b.ToTable("Autor");
                });

            modelBuilder.Entity("Desafio_Backend.Domain.Models.Genero", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("descricao");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.HasKey("id");

                    b.ToTable("Genero");
                });

            modelBuilder.Entity("Desafio_Backend.Domain.Models.Livro", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<decimal>("avaliacao")
                        .HasColumnType("numeric")
                        .HasColumnName("avaliacao");

                    b.Property<DateTime>("dataCadastro")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("dataCadastro");

                    b.Property<DateTime>("dataPublicacao")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("dataPublicacao");

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("descricao");

                    b.Property<int>("edicao")
                        .HasColumnType("integer")
                        .HasColumnName("edicao");

                    b.Property<int>("idGenero")
                        .HasColumnType("integer");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.Property<string>("urlCapa")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("urlCapa");

                    b.Property<decimal>("valor")
                        .HasColumnType("numeric")
                        .HasColumnName("valor");

                    b.HasKey("id");

                    b.HasIndex("idGenero");

                    b.ToTable("Livro");
                });

            modelBuilder.Entity("Desafio_Backend.Domain.Models.Livro_Autor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("idAutor")
                        .HasColumnType("integer")
                        .HasColumnName("idAutor");

                    b.Property<int>("idLivro")
                        .HasColumnType("integer")
                        .HasColumnName("idLivro");

                    b.HasKey("id");

                    b.HasIndex("idAutor");

                    b.HasIndex("idLivro");

                    b.ToTable("Livro_Autor");
                });

            modelBuilder.Entity("Desafio_Backend.Domain.Models.Livro", b =>
                {
                    b.HasOne("Desafio_Backend.Domain.Models.Genero", "Genero")
                        .WithMany("Livros")
                        .HasForeignKey("idGenero")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genero");
                });

            modelBuilder.Entity("Desafio_Backend.Domain.Models.Livro_Autor", b =>
                {
                    b.HasOne("Desafio_Backend.Domain.Models.Autor", "Autor")
                        .WithMany("Livro_Autores")
                        .HasForeignKey("idAutor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Desafio_Backend.Domain.Models.Livro", "Livro")
                        .WithMany("Livro_Autores")
                        .HasForeignKey("idLivro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Autor");

                    b.Navigation("Livro");
                });

            modelBuilder.Entity("Desafio_Backend.Domain.Models.Autor", b =>
                {
                    b.Navigation("Livro_Autores");
                });

            modelBuilder.Entity("Desafio_Backend.Domain.Models.Genero", b =>
                {
                    b.Navigation("Livros");
                });

            modelBuilder.Entity("Desafio_Backend.Domain.Models.Livro", b =>
                {
                    b.Navigation("Livro_Autores");
                });
#pragma warning restore 612, 618
        }
    }
}
