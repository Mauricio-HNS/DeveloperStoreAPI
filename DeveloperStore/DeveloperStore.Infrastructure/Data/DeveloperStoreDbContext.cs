using Microsoft.EntityFrameworkCore;
using DeveloperStore.API.Entities;
using DeveloperStore.Domain.Entities;  // Verifique se este namespace está correto

namespace DeveloperStore.API.Data
{
    public class DeveloperStoreDbContext : DbContext
    {
        public DeveloperStoreDbContext(DbContextOptions<DeveloperStoreDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleItem> SaleItems { get; set; }  // Corrigido para DbSet<SaleItem>
    }
}
