﻿// <auto-generated />
using System;
using Hatogan.IA.Gateways.EFCore.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hatogan.IA.Gateways.EFCore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211004154921_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0-rc.1.21452.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Hatogan.EB.Domain.Entities.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("AdmissionDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("date");

                    b.Property<decimal>("BirthWeight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("BreedId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Color")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("DamId")
                        .HasColumnType("int");

                    b.Property<string>("EarTag")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("FarmId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("IncomeWeight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Iron")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Name")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int?>("SireId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("UpdatedOn")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("BreedId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.HasIndex("DamId");

                    b.HasIndex("FarmId");

                    b.HasIndex("SireId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdmissionDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BirthWeight = 0m,
                            BreedId = 1,
                            CategoryId = 8,
                            Code = "Mad/Desc",
                            CreatedBy = "system",
                            CreatedOn = new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(2497), new TimeSpan(0, -5, 0, 0, 0)),
                            FarmId = 1,
                            IncomeWeight = 0m,
                            Name = "Madre Desconocida",
                            Sex = "Hembra",
                            Status = "Activo"
                        },
                        new
                        {
                            Id = 2,
                            AdmissionDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BirthWeight = 0m,
                            BreedId = 1,
                            CategoryId = 9,
                            Code = "Padr/Desc",
                            CreatedBy = "system",
                            CreatedOn = new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(2518), new TimeSpan(0, -5, 0, 0, 0)),
                            FarmId = 1,
                            IncomeWeight = 0m,
                            Name = "Padre Desconocido",
                            Sex = "Macho",
                            Status = "Activo"
                        });
                });

            modelBuilder.Entity("Hatogan.EB.Domain.Entities.Breed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("UpdatedOn")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Breeds");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "system",
                            CreatedOn = new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3115), new TimeSpan(0, -5, 0, 0, 0)),
                            Name = "-No Asignado-"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "system",
                            CreatedOn = new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3120), new TimeSpan(0, -5, 0, 0, 0)),
                            Name = "Angus"
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "system",
                            CreatedOn = new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3121), new TimeSpan(0, -5, 0, 0, 0)),
                            Name = "Angus Negro"
                        },
                        new
                        {
                            Id = 4,
                            CreatedBy = "system",
                            CreatedOn = new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3122), new TimeSpan(0, -5, 0, 0, 0)),
                            Name = "Angus Rojo"
                        },
                        new
                        {
                            Id = 5,
                            CreatedBy = "system",
                            CreatedOn = new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3123), new TimeSpan(0, -5, 0, 0, 0)),
                            Name = "Ayrshire"
                        },
                        new
                        {
                            Id = 6,
                            CreatedBy = "system",
                            CreatedOn = new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3123), new TimeSpan(0, -5, 0, 0, 0)),
                            Name = "Bom"
                        },
                        new
                        {
                            Id = 7,
                            CreatedBy = "system",
                            CreatedOn = new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3124), new TimeSpan(0, -5, 0, 0, 0)),
                            Name = "Brahman"
                        },
                        new
                        {
                            Id = 8,
                            CreatedBy = "system",
                            CreatedOn = new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3125), new TimeSpan(0, -5, 0, 0, 0)),
                            Name = "Brangus"
                        },
                        new
                        {
                            Id = 9,
                            CreatedBy = "system",
                            CreatedOn = new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3126), new TimeSpan(0, -5, 0, 0, 0)),
                            Name = "Casanareño"
                        },
                        new
                        {
                            Id = 10,
                            CreatedBy = "system",
                            CreatedOn = new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3127), new TimeSpan(0, -5, 0, 0, 0)),
                            Name = "Cebu"
                        },
                        new
                        {
                            Id = 11,
                            CreatedBy = "system",
                            CreatedOn = new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3128), new TimeSpan(0, -5, 0, 0, 0)),
                            Name = "Charolais"
                        },
                        new
                        {
                            Id = 12,
                            CreatedBy = "system",
                            CreatedOn = new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3129), new TimeSpan(0, -5, 0, 0, 0)),
                            Name = "Chino Santandereano"
                        },
                        new
                        {
                            Id = 13,
                            CreatedBy = "system",
                            CreatedOn = new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3130), new TimeSpan(0, -5, 0, 0, 0)),
                            Name = "Costeño con Cuernos"
                        },
                        new
                        {
                            Id = 14,
                            CreatedBy = "system",
                            CreatedOn = new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3131), new TimeSpan(0, -5, 0, 0, 0)),
                            Name = "Criollo"
                        },
                        new
                        {
                            Id = 15,
                            CreatedBy = "system",
                            CreatedOn = new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3132), new TimeSpan(0, -5, 0, 0, 0)),
                            Name = "Guzerat"
                        },
                        new
                        {
                            Id = 16,
                            CreatedBy = "system",
                            CreatedOn = new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3132), new TimeSpan(0, -5, 0, 0, 0)),
                            Name = "Gyr"
                        },
                        new
                        {
                            Id = 17,
                            CreatedBy = "system",
                            CreatedOn = new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3133), new TimeSpan(0, -5, 0, 0, 0)),
                            Name = "Harton del valle"
                        },
                        new
                        {
                            Id = 18,
                            CreatedBy = "system",
                            CreatedOn = new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3134), new TimeSpan(0, -5, 0, 0, 0)),
                            Name = "Holstein"
                        },
                        new
                        {
                            Id = 19,
                            CreatedBy = "system",
                            CreatedOn = new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3135), new TimeSpan(0, -5, 0, 0, 0)),
                            Name = "Indubrasil"
                        },
                        new
                        {
                            Id = 20,
                            CreatedBy = "system",
                            CreatedOn = new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3136), new TimeSpan(0, -5, 0, 0, 0)),
                            Name = "Jersey"
                        },
                        new
                        {
                            Id = 21,
                            CreatedBy = "system",
                            CreatedOn = new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3137), new TimeSpan(0, -5, 0, 0, 0)),
                            Name = "Limousin"
                        },
                        new
                        {
                            Id = 22,
                            CreatedBy = "system",
                            CreatedOn = new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3138), new TimeSpan(0, -5, 0, 0, 0)),
                            Name = "Lucerna"
                        },
                        new
                        {
                            Id = 23,
                            CreatedBy = "system",
                            CreatedOn = new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3139), new TimeSpan(0, -5, 0, 0, 0)),
                            Name = "Nelore"
                        },
                        new
                        {
                            Id = 24,
                            CreatedBy = "system",
                            CreatedOn = new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3140), new TimeSpan(0, -5, 0, 0, 0)),
                            Name = "Normando"
                        },
                        new
                        {
                            Id = 25,
                            CreatedBy = "system",
                            CreatedOn = new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3141), new TimeSpan(0, -5, 0, 0, 0)),
                            Name = "Pardo"
                        },
                        new
                        {
                            Id = 26,
                            CreatedBy = "system",
                            CreatedOn = new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3142), new TimeSpan(0, -5, 0, 0, 0)),
                            Name = "Romosinuano"
                        },
                        new
                        {
                            Id = 27,
                            CreatedBy = "system",
                            CreatedOn = new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3143), new TimeSpan(0, -5, 0, 0, 0)),
                            Name = "Sanmartinero"
                        },
                        new
                        {
                            Id = 28,
                            CreatedBy = "system",
                            CreatedOn = new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3144), new TimeSpan(0, -5, 0, 0, 0)),
                            Name = "Simmental"
                        },
                        new
                        {
                            Id = 29,
                            CreatedBy = "system",
                            CreatedOn = new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3145), new TimeSpan(0, -5, 0, 0, 0)),
                            Name = "Velasquez"
                        });
                });

            modelBuilder.Entity("Hatogan.EB.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Since")
                        .HasColumnType("int");

                    b.Property<int>("Until")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Crias",
                            Since = 0,
                            Until = 240
                        },
                        new
                        {
                            Id = 2,
                            Name = "Novillas Destete",
                            Since = 240,
                            Until = 365
                        },
                        new
                        {
                            Id = 3,
                            Name = "Mautes Destete",
                            Since = 240,
                            Until = 365
                        },
                        new
                        {
                            Id = 4,
                            Name = "Novillas de Levante",
                            Since = 365,
                            Until = 600
                        },
                        new
                        {
                            Id = 5,
                            Name = "Maute de Levante",
                            Since = 365,
                            Until = 600
                        },
                        new
                        {
                            Id = 6,
                            Name = "Novillas de Vientre",
                            Since = 600,
                            Until = 1080
                        },
                        new
                        {
                            Id = 7,
                            Name = "Maute de Vientre",
                            Since = 600,
                            Until = 1080
                        },
                        new
                        {
                            Id = 8,
                            Name = "Vacas",
                            Since = 1080,
                            Until = 3600
                        },
                        new
                        {
                            Id = 9,
                            Name = "Toros",
                            Since = 1080,
                            Until = 3600
                        });
                });

            modelBuilder.Entity("Hatogan.EB.Domain.Entities.Farm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("UpdatedOn")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("Farms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Santa Rosa de Lima, paralelo 38",
                            Code = "ARZ",
                            CreatedBy = "system",
                            CreatedOn = new DateTimeOffset(new DateTime(2021, 10, 4, 10, 49, 21, 461, DateTimeKind.Unspecified).AddTicks(3946), new TimeSpan(0, -5, 0, 0, 0)),
                            Name = "Hacienda Arizona Y Villa Monica",
                            Phone = "3000000000"
                        });
                });

            modelBuilder.Entity("Hatogan.EB.Domain.Entities.Animal", b =>
                {
                    b.HasOne("Hatogan.EB.Domain.Entities.Breed", "Breed")
                        .WithMany("Animals")
                        .HasForeignKey("BreedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hatogan.EB.Domain.Entities.Category", "Category")
                        .WithMany("Animals")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hatogan.EB.Domain.Entities.Animal", "Dam")
                        .WithMany("DamPups")
                        .HasForeignKey("DamId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Hatogan.EB.Domain.Entities.Farm", "Farm")
                        .WithMany("Animals")
                        .HasForeignKey("FarmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hatogan.EB.Domain.Entities.Animal", "Sire")
                        .WithMany("SirePups")
                        .HasForeignKey("SireId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Breed");

                    b.Navigation("Category");

                    b.Navigation("Dam");

                    b.Navigation("Farm");

                    b.Navigation("Sire");
                });

            modelBuilder.Entity("Hatogan.EB.Domain.Entities.Animal", b =>
                {
                    b.Navigation("DamPups");

                    b.Navigation("SirePups");
                });

            modelBuilder.Entity("Hatogan.EB.Domain.Entities.Breed", b =>
                {
                    b.Navigation("Animals");
                });

            modelBuilder.Entity("Hatogan.EB.Domain.Entities.Category", b =>
                {
                    b.Navigation("Animals");
                });

            modelBuilder.Entity("Hatogan.EB.Domain.Entities.Farm", b =>
                {
                    b.Navigation("Animals");
                });
#pragma warning restore 612, 618
        }
    }
}