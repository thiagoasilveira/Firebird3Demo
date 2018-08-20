﻿// <auto-generated />
using Firebird3Demo.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Firebird3Demo.DAO.Migrations
{
    [DbContext(typeof(FbContext))]
    partial class FbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846");

            modelBuilder.Entity("Firebird3Demo.DTO.Cidade", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .IsFixedLength(true)
                        .HasMaxLength(2);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("UFId")
                        .IsRequired()
                        .IsFixedLength(true)
                        .HasMaxLength(2);

                    b.HasKey("Id");

                    b.HasIndex("UFId");

                    b.ToTable("Cidade");
                });

            modelBuilder.Entity("Firebird3Demo.DTO.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER GENERATED BY DEFAULT AS IDENTITY");

                    b.Property<bool>("Ativo");

                    b.Property<string>("Bairro")
                        .HasMaxLength(30);

                    b.Property<string>("CEP")
                        .HasMaxLength(7);

                    b.Property<string>("CidadeId")
                        .IsRequired()
                        .HasMaxLength(7);

                    b.Property<string>("Complemento")
                        .HasMaxLength(30);

                    b.Property<string>("Endereco")
                        .HasMaxLength(60);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("NomeFantasia")
                        .HasMaxLength(60);

                    b.Property<string>("Numero")
                        .HasMaxLength(10);

                    b.Property<string>("Telefone")
                        .HasMaxLength(12);

                    b.HasKey("Id");

                    b.HasIndex("CidadeId");

                    b.ToTable("Pessoa");
                });

            modelBuilder.Entity("Firebird3Demo.DTO.UF", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .IsFixedLength(true)
                        .HasMaxLength(2);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.HasKey("Id");

                    b.ToTable("UF");
                });

            modelBuilder.Entity("Firebird3Demo.DTO.Cidade", b =>
                {
                    b.HasOne("Firebird3Demo.DTO.UF", "UF")
                        .WithMany()
                        .HasForeignKey("UFId")
                        .HasConstraintName("FK_Cidade_UF")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Firebird3Demo.DTO.Pessoa", b =>
                {
                    b.HasOne("Firebird3Demo.DTO.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeId")
                        .HasConstraintName("FK_Pessoa_Cidade")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}