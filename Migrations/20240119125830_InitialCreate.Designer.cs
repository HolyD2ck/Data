﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240119125830_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Data.Models.Prepod", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("День_Рождения")
                        .HasColumnType("datetime2");

                    b.Property<int>("Зарплата")
                        .HasColumnType("int");

                    b.Property<string>("Имя")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Куратор_Группы")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Номер_Кабинета")
                        .HasColumnType("int");

                    b.Property<string>("Отчество")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Профессия")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Стаж")
                        .HasColumnType("int");

                    b.Property<string>("Фамилия")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Prepod");
                });

            modelBuilder.Entity("Data.Models.Student", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("Возраст")
                        .HasColumnType("int");

                    b.Property<string>("Группа")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("День_Рождения")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Имя")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Отчество")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Рост")
                        .HasColumnType("int");

                    b.Property<string>("Специальность")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Стипендия")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Фамилия")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("Data.Models.View", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("Возраст")
                        .HasColumnType("int");

                    b.Property<string>("Группа")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("День_Рождения")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Имя")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Отчество")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Рост")
                        .HasColumnType("int");

                    b.Property<string>("Специальность")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Стипендия")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Фамилия")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("View");
                });
#pragma warning restore 612, 618
        }
    }
}
