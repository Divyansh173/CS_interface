﻿// <auto-generated />
using EfCoreProgramFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EfCoreProgramFirst.Migrations
{
    [DbContext(typeof(IDbContext))]
    [Migration("20221018071620_seventhhmigration")]
    partial class seventhhmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EfCoreProgramFirst.Models.Person", b =>
                {
                    b.Property<int>("PersonUniqueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonUniqueId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(700)
                        .HasColumnType("nvarchar(700)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PersonId")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PersonName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.HasKey("PersonUniqueId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("EfCoreProgramFirst.Models.ProductionUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReleaseYear")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ProductionUnits");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ProductionUnit");
                });

            modelBuilder.Entity("EfCoreProgramFirst.Models.Movies", b =>
                {
                    b.HasBaseType("EfCoreProgramFirst.Models.ProductionUnit");

                    b.Property<double>("BoxOfficeCollection")
                        .HasColumnType("float");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlayDuration")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Dr.No",
                            ReleaseYear = 1963,
                            BoxOfficeCollection = 12222.0,
                            Category = "Spy",
                            PlayDuration = 150
                        },
                        new
                        {
                            Id = 2,
                            Name = "Golmal",
                            ReleaseYear = 1976,
                            BoxOfficeCollection = 122.0,
                            Category = "Comedy",
                            PlayDuration = 180
                        });
                });

            modelBuilder.Entity("EfCoreProgramFirst.Models.WebSeries", b =>
                {
                    b.HasBaseType("EfCoreProgramFirst.Models.ProductionUnit");

                    b.Property<int>("EpisodPerSeason")
                        .HasColumnType("int");

                    b.Property<int>("Seasons")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("WebSeries");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            Name = "Ramayan",
                            ReleaseYear = 1986,
                            EpisodPerSeason = 100,
                            Seasons = 2
                        },
                        new
                        {
                            Id = 4,
                            Name = "House of Cards",
                            ReleaseYear = 2005,
                            EpisodPerSeason = 50,
                            Seasons = 6
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
