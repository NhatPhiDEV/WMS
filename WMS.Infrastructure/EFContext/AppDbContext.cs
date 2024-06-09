using Microsoft.EntityFrameworkCore;
using Models = WMS.Domain.Models;

namespace WMS.Infrastructure.EFContext
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Models.Product> Products { get; set; }
        public DbSet<Models.Attribute> Attributes { get; set; }
        public DbSet<Models.ProductCategory> ProductCategories { get; set; }
        public DbSet<Models.Zone> Zones { get; set; }
        public DbSet<Models.Location> Locations { get; set; }
        public DbSet<Models.InventoryTransactionType> InventoryTransactionTypes { get; set; }
        public DbSet<Models.Inventory> Inventories { get; set; }
        public DbSet<Models.InventoryTransaction> InventoryTransactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
