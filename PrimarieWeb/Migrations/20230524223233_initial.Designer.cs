﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PrimarieWeb.Models;

#nullable disable

namespace PrimarieWeb.Migrations
{
    [DbContext(typeof(GestiunePrimarieContext))]
    [Migration("20230524223233_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PrimarieWeb.Models.Cetatean", b =>
                {
                    b.Property<int>("CetateanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CetateanId"));

                    b.Property<string>("nume")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CetateanId");

                    b.ToTable("Cetateans");
                });

            modelBuilder.Entity("PrimarieWeb.Models.Chat", b =>
                {
                    b.Property<int>("ChatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChatId"));

                    b.Property<int>("CetateanId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("data")
                        .HasColumnType("datetime2");

                    b.Property<int>("nrParticipanti")
                        .HasColumnType("int");

                    b.HasKey("ChatId");

                    b.HasIndex("CetateanId");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("PrimarieWeb.Models.Document", b =>
                {
                    b.Property<int>("DocumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DocumentId"));

                    b.Property<int>("CetateanId")
                        .HasColumnType("int");

                    b.Property<string>("descriere")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numeDoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("urlFisier")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DocumentId");

                    b.HasIndex("CetateanId");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("PrimarieWeb.Models.Eveniment", b =>
                {
                    b.Property<int>("EvenimentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EvenimentId"));

                    b.Property<int>("CetateanId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("dataEveniment")
                        .HasColumnType("datetime2");

                    b.Property<string>("descriere")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numeEveniment")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EvenimentId");

                    b.HasIndex("CetateanId");

                    b.ToTable("Eveniments");
                });

            modelBuilder.Entity("PrimarieWeb.Models.Chat", b =>
                {
                    b.HasOne("PrimarieWeb.Models.Cetatean", "Cetatean")
                        .WithMany("Chats")
                        .HasForeignKey("CetateanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cetatean");
                });

            modelBuilder.Entity("PrimarieWeb.Models.Document", b =>
                {
                    b.HasOne("PrimarieWeb.Models.Cetatean", "Cetatean")
                        .WithMany("Documents")
                        .HasForeignKey("CetateanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cetatean");
                });

            modelBuilder.Entity("PrimarieWeb.Models.Eveniment", b =>
                {
                    b.HasOne("PrimarieWeb.Models.Cetatean", "Cetatean")
                        .WithMany("Eveniments")
                        .HasForeignKey("CetateanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cetatean");
                });

            modelBuilder.Entity("PrimarieWeb.Models.Cetatean", b =>
                {
                    b.Navigation("Chats");

                    b.Navigation("Documents");

                    b.Navigation("Eveniments");
                });
#pragma warning restore 612, 618
        }
    }
}
