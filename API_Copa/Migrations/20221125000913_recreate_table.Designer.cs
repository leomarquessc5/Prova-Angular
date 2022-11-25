﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api.Models;

namespace API_Copa.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20221125000913_recreate_table")]
    partial class recreate_table
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("API_Copa.Models.Jogo", b =>
                {
                    b.Property<int>("jogoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<int?>("SelecaoAId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SelecaoBId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("palpiteA")
                        .HasColumnType("INTEGER");

                    b.Property<int>("palpiteB")
                        .HasColumnType("INTEGER");

                    b.HasKey("jogoId");

                    b.HasIndex("SelecaoAId");

                    b.HasIndex("SelecaoBId");

                    b.ToTable("Jogos");
                });

            modelBuilder.Entity("API_Copa.Models.Selecao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Selecoes");
                });

            modelBuilder.Entity("API_Copa.Models.Jogo", b =>
                {
                    b.HasOne("API_Copa.Models.Selecao", "SelecaoA")
                        .WithMany()
                        .HasForeignKey("SelecaoAId");

                    b.HasOne("API_Copa.Models.Selecao", "SelecaoB")
                        .WithMany()
                        .HasForeignKey("SelecaoBId");

                    b.Navigation("SelecaoA");

                    b.Navigation("SelecaoB");
                });
#pragma warning restore 612, 618
        }
    }
}
