using DeveloperStore.API.Models;
using DeveloperStore.API.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeveloperStore.API.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DeveloperStoreDbContext _context;

        public ProductRepository(DeveloperStoreDbContext context)
        {
            _context = context;
        }

        // Usando assíncrono para evitar bloqueio de threads
        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _context.Products
                .FirstOrDefaultAsync(p => p.ProductId == id);
        }

        public async Task<Product> CreateProductAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();  // Operação assíncrona
            return product;
        }

        public async Task<Product> UpdateProductAsync(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();  // Operação assíncrona
            return product;
        }

        public async Task DeleteProductAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);  // Operação assíncrona
            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();  // Operação assíncrona
            }
        }
    }
}
