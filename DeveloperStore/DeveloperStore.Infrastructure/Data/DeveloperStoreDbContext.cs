using Microsoft.EntityFrameworkCore;
using DeveloperStore.API.Entities;  // Ou o namespace onde suas entidades estão

namespace DeveloperStore.API.Data  // ou o namespace onde você está criando a DbContext
{
    public class DeveloperStoreDbContext : DbContext
    {
        public DeveloperStoreDbContext(DbContextOptions<DeveloperStoreDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public object Branches { get; set; }
        public object Sales { get; set; }

        // Adicione mais DbSet para outras entidades
    }
}
