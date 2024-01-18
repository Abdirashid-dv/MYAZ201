using Microsoft.EntityFrameworkCore;
using Models;

namespace Repositories;

public class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions<RepositoryContext> options)
        : base(options)
    {

    }

    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder
            .Entity<Product>()
            .HasData(
                new Product
                {
                    ProductId = 1,
                    ProductName = "Laptop",
                    Price = 1_500.00m,
                    ExpirationDate = DateTime.Now.AddYears(2),
                    StockQuantity = 100
                },
                new Product
                {
                    ProductId = 2,
                    ProductName = "Smartphone",
                    Price = 800.50m,
                    ExpirationDate = DateTime.Now.AddYears(1),
                    StockQuantity = 50
                },
                new Product
                {
                    ProductId = 3,
                    ProductName = "Headphones",
                    Price = 75.99m,
                    ExpirationDate = DateTime.Now.AddYears(1),
                    StockQuantity = 200
                },
                new Product
                {
                    ProductId = 4,
                    ProductName = "Coffee Maker",
                    Price = 45.00m,
                    ExpirationDate = DateTime.Now.AddYears(1),
                    StockQuantity = 30
                },
                new Product
                {
                    ProductId = 5,
                    ProductName = "Backpack",
                    Price = 40.00m,
                    ExpirationDate = DateTime.Now.AddYears(1),
                    StockQuantity = 80
                },
                new Product
                {
                    ProductId = 6,
                    ProductName = "Wireless Mouse",
                    Price = 20.99m,
                    ExpirationDate = DateTime.Now.AddYears(1),
                    StockQuantity = 120
                },
                new Product
                {
                    ProductId = 7,
                    ProductName = "Desk Lamp",
                    Price = 30.50m,
                    ExpirationDate = DateTime.Now.AddYears(1),
                    StockQuantity = 60
                },
                new Product
                {
                    ProductId = 8,
                    ProductName = "External Hard Drive",
                    Price = 120.00m,
                    ExpirationDate = DateTime.Now.AddYears(1),
                    StockQuantity = 25
                },
                new Product
                {
                    ProductId = 9,
                    ProductName = "Bluetooth Speaker",
                    Price = 50.00m,
                    ExpirationDate = DateTime.Now.AddYears(1),
                    StockQuantity = 90
                },
                new Product
                {
                    ProductId = 10,
                    ProductName = "Fitness Tracker",
                    Price = 70.75m,
                    ExpirationDate = DateTime.Now.AddYears(1),
                    StockQuantity = 40
                }
            );
    }
}