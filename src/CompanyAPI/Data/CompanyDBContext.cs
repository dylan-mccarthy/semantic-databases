//Database context for EntityFramework
//This class is used to connect to the database and to access the tables in the database
//The models for the database tables are stored in the models directory

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Company.Models;

namespace Company.Data;


public class CompanyDBContext : DbContext
{
    public DbSet<Store>? Stores { get; set; }
    public DbSet<Product>? Products { get; set; }
    public DbSet<StockEntry>? StockEntries { get; set; }

    private readonly ILoggerFactory _loggerFactory;
    private readonly IConfiguration _configuration;

    public CompanyDBContext(IConfiguration configuration, ILoggerFactory loggerFactory)
    {
        _configuration = configuration;
        _loggerFactory = loggerFactory;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_configuration.GetConnectionString("CompanyDB"));
        optionsBuilder.UseLoggerFactory(_loggerFactory);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Store>().ToTable("Store");
        modelBuilder.Entity<Product>().ToTable("Product");
        modelBuilder.Entity<StockEntry>().ToTable("StockEntry");

        DateTime openTime = new DateTime(2021, 1, 1, 8, 0, 0);
        DateTime closeTime = new DateTime(2021, 1, 1, 17, 0, 0);

        modelBuilder.Entity<Store>().HasData(
            new Store(1, "Store 1", "Location 1", openTime, closeTime),
            new Store(2, "Store 2", "Location 2", openTime, closeTime),
            new Store(3, "Store 3", "Location 3", openTime, closeTime),
            new Store(4, "Store 4", "Location 4", openTime, closeTime),
            new Store(5, "Store 5", "Location 5", openTime, closeTime)
        );

        modelBuilder.Entity<Product>().HasData(
            new Product(1, "Product 1", "Product 1", 1.99),
            new Product(2, "Product 2", "Product 2", 2.99),
            new Product(3, "Product 3", "Product 3", 3.99),
            new Product(4, "Product 4", "Product 4", 4.99),
            new Product(5, "Product 5", "Product 5", 5.99)
        );

        modelBuilder.Entity<StockEntry>().HasData(
            new StockEntry(1, 1, 1, 10),
            new StockEntry(2, 1, 2, 10),
            new StockEntry(3, 1, 3, 10),
            new StockEntry(4, 1, 4, 10),
            new StockEntry(5, 1, 5, 10),
            new StockEntry(6, 2, 1, 10),
            new StockEntry(7, 2, 2, 10),
            new StockEntry(8, 2, 3, 10),
            new StockEntry(9, 2, 4, 10),
            new StockEntry(10, 2, 5, 10),
            new StockEntry(11, 3, 1, 10),
            new StockEntry(12, 3, 2, 10),
            new StockEntry(13, 3, 3, 10),
            new StockEntry(14, 3, 4, 10),
            new StockEntry(15, 3, 5, 10),
            new StockEntry(16, 4, 1, 10),
            new StockEntry(17, 4, 2, 10),
            new StockEntry(18, 4, 3, 10),
            new StockEntry(19, 4, 4, 10),
            new StockEntry(20, 4, 5, 10),
            new StockEntry(21, 5, 1, 10),
            new StockEntry(22, 5, 2, 10),
            new StockEntry(23, 5, 3, 10),
            new StockEntry(24, 5, 4, 10),
            new StockEntry(25, 5, 5, 10)
        );



    }
}