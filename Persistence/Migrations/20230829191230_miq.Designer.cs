﻿// <auto-generated />
using CarSite.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarSite.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230829191230_miq")]
    partial class miq
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CarSite.Domain.Entities.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EngineSize")
                        .HasColumnType("int");

                    b.Property<double>("FuelEfficiency")
                        .HasColumnType("float");

                    b.Property<string>("Make")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.Property<string>("photos")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "Black",
                            EngineSize = 2500,
                            FuelEfficiency = 25.800000000000001,
                            Make = "Ford",
                            Model = "Mustang",
                            Price = 45000,
                            Year = 2023,
                            photos = "/Images/mustang.jpg"
                        },
                        new
                        {
                            Id = 2,
                            Color = "Yellow",
                            EngineSize = 3000,
                            FuelEfficiency = 24.600000000000001,
                            Make = "Chevrolet",
                            Model = "Camaro",
                            Price = 42000,
                            Year = 2022,
                            photos = "/Images/camaro.jpg"
                        },
                        new
                        {
                            Id = 3,
                            Color = "Blue",
                            EngineSize = 2000,
                            FuelEfficiency = 28.5,
                            Make = "BMW",
                            Model = "3 Series",
                            Price = 40000,
                            Year = 2021,
                            photos = "/Images/bmw3ser.jpg"
                        },
                        new
                        {
                            Id = 4,
                            Color = "Dark",
                            EngineSize = 10000,
                            FuelEfficiency = 90.5,
                            Make = "Toyota",
                            Model = "Supra",
                            Price = 45000,
                            Year = 2012,
                            photos = "/Images/supra.jpg"
                        },
                        new
                        {
                            Id = 5,
                            Color = "Silver",
                            EngineSize = 2000,
                            FuelEfficiency = 30.5,
                            Make = "Toyota",
                            Model = "Camry",
                            Price = 25000,
                            Year = 2022,
                            photos = ""
                        },
                        new
                        {
                            Id = 6,
                            Color = "White",
                            EngineSize = 3500,
                            FuelEfficiency = 22.300000000000001,
                            Make = "BMW",
                            Model = "X5",
                            Price = 65000,
                            Year = 2023,
                            photos = "/Images/bmwx5jpg.jpg"
                        },
                        new
                        {
                            Id = 7,
                            Color = "Red",
                            EngineSize = 1800,
                            FuelEfficiency = 32.100000000000001,
                            Make = "Honda",
                            Model = "Accord",
                            Price = 28000,
                            Year = 2021,
                            photos = "/Images/HondaAccord.jpg"
                        },
                        new
                        {
                            Id = 8,
                            Color = "Red",
                            EngineSize = 5000,
                            FuelEfficiency = 20.100000000000001,
                            Make = "Ford",
                            Model = "Mustang GT",
                            Price = 50000,
                            Year = 2022,
                            photos = ""
                        },
                        new
                        {
                            Id = 9,
                            Color = "White",
                            EngineSize = 2500,
                            FuelEfficiency = 26.800000000000001,
                            Make = "Mercedes-Benz",
                            Model = "C-Class",
                            Price = 45000,
                            Year = 2020,
                            photos = "/Images/mers.jpg"
                        },
                        new
                        {
                            Id = 10,
                            Color = "Silver",
                            EngineSize = 1600,
                            FuelEfficiency = 34.200000000000003,
                            Make = "Hyundai",
                            Model = "Elantra",
                            Price = 28000,
                            Year = 2020,
                            photos = "/Images/elantra.jpg"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
