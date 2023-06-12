﻿// <auto-generated />
using System;
using Company.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CompanyAPI.Migrations
{
    [DbContext(typeof(CompanyDBContext))]
    [Migration("20230612113224_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Company.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Product", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Product 1",
                            Name = "Product 1",
                            Price = 1.99
                        },
                        new
                        {
                            Id = 2,
                            Description = "Product 2",
                            Name = "Product 2",
                            Price = 2.9900000000000002
                        },
                        new
                        {
                            Id = 3,
                            Description = "Product 3",
                            Name = "Product 3",
                            Price = 3.9900000000000002
                        },
                        new
                        {
                            Id = 4,
                            Description = "Product 4",
                            Name = "Product 4",
                            Price = 4.9900000000000002
                        },
                        new
                        {
                            Id = 5,
                            Description = "Product 5",
                            Name = "Product 5",
                            Price = 5.9900000000000002
                        });
                });

            modelBuilder.Entity("Company.Models.StockEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("StockEntry", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ProductId = 1,
                            Quantity = 10,
                            StoreId = 1
                        },
                        new
                        {
                            Id = 2,
                            ProductId = 2,
                            Quantity = 10,
                            StoreId = 1
                        },
                        new
                        {
                            Id = 3,
                            ProductId = 3,
                            Quantity = 10,
                            StoreId = 1
                        },
                        new
                        {
                            Id = 4,
                            ProductId = 4,
                            Quantity = 10,
                            StoreId = 1
                        },
                        new
                        {
                            Id = 5,
                            ProductId = 5,
                            Quantity = 10,
                            StoreId = 1
                        },
                        new
                        {
                            Id = 6,
                            ProductId = 1,
                            Quantity = 10,
                            StoreId = 2
                        },
                        new
                        {
                            Id = 7,
                            ProductId = 2,
                            Quantity = 10,
                            StoreId = 2
                        },
                        new
                        {
                            Id = 8,
                            ProductId = 3,
                            Quantity = 10,
                            StoreId = 2
                        },
                        new
                        {
                            Id = 9,
                            ProductId = 4,
                            Quantity = 10,
                            StoreId = 2
                        },
                        new
                        {
                            Id = 10,
                            ProductId = 5,
                            Quantity = 10,
                            StoreId = 2
                        },
                        new
                        {
                            Id = 11,
                            ProductId = 1,
                            Quantity = 10,
                            StoreId = 3
                        },
                        new
                        {
                            Id = 12,
                            ProductId = 2,
                            Quantity = 10,
                            StoreId = 3
                        },
                        new
                        {
                            Id = 13,
                            ProductId = 3,
                            Quantity = 10,
                            StoreId = 3
                        },
                        new
                        {
                            Id = 14,
                            ProductId = 4,
                            Quantity = 10,
                            StoreId = 3
                        },
                        new
                        {
                            Id = 15,
                            ProductId = 5,
                            Quantity = 10,
                            StoreId = 3
                        },
                        new
                        {
                            Id = 16,
                            ProductId = 1,
                            Quantity = 10,
                            StoreId = 4
                        },
                        new
                        {
                            Id = 17,
                            ProductId = 2,
                            Quantity = 10,
                            StoreId = 4
                        },
                        new
                        {
                            Id = 18,
                            ProductId = 3,
                            Quantity = 10,
                            StoreId = 4
                        },
                        new
                        {
                            Id = 19,
                            ProductId = 4,
                            Quantity = 10,
                            StoreId = 4
                        },
                        new
                        {
                            Id = 20,
                            ProductId = 5,
                            Quantity = 10,
                            StoreId = 4
                        },
                        new
                        {
                            Id = 21,
                            ProductId = 1,
                            Quantity = 10,
                            StoreId = 5
                        },
                        new
                        {
                            Id = 22,
                            ProductId = 2,
                            Quantity = 10,
                            StoreId = 5
                        },
                        new
                        {
                            Id = 23,
                            ProductId = 3,
                            Quantity = 10,
                            StoreId = 5
                        },
                        new
                        {
                            Id = 24,
                            ProductId = 4,
                            Quantity = 10,
                            StoreId = 5
                        },
                        new
                        {
                            Id = 25,
                            ProductId = 5,
                            Quantity = 10,
                            StoreId = 5
                        });
                });

            modelBuilder.Entity("Company.Models.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CloseTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OpenTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Store", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CloseTime = new DateTime(2021, 1, 1, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Location 1",
                            Name = "Store 1",
                            OpenTime = new DateTime(2021, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CloseTime = new DateTime(2021, 1, 1, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Location 2",
                            Name = "Store 2",
                            OpenTime = new DateTime(2021, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CloseTime = new DateTime(2021, 1, 1, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Location 3",
                            Name = "Store 3",
                            OpenTime = new DateTime(2021, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CloseTime = new DateTime(2021, 1, 1, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Location 4",
                            Name = "Store 4",
                            OpenTime = new DateTime(2021, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            CloseTime = new DateTime(2021, 1, 1, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Location 5",
                            Name = "Store 5",
                            OpenTime = new DateTime(2021, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
