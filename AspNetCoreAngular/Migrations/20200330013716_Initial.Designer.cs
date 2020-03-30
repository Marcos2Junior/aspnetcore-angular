﻿// <auto-generated />
using System;
using AspNetCoreAngular.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AspNetCoreAngular.Migrations
{
    [DbContext(typeof(AspNetCoreAngularContext))]
    [Migration("20200330013716_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AspNetCoreAngular.Model.Evento", b =>
                {
                    b.Property<int>("EventoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataEvento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Local")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Lote")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("QntPessoas")
                        .HasColumnType("int");

                    b.Property<string>("Tema")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("EventoId");

                    b.ToTable("Evento");
                });
#pragma warning restore 612, 618
        }
    }
}
