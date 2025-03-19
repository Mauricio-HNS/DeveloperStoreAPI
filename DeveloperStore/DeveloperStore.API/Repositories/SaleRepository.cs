using DeveloperStore.API.Models;
using DeveloperStore.API.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DeveloperStore.API.Repositories
{
    public class SaleRepository : ISaleRepository
    {
        private readonly DeveloperStoreDbContext _context;

        public SaleRepository(DeveloperStoreDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Sale> GetAllSales()
        {
            return _context.Sales.Include(s => s.SaleItems).ToList();
        }

        public Sale GetSaleById(int id)
        {
            return _context.Sales.Include(s => s.SaleItems).FirstOrDefault(s => s.SaleId == id);
        }

        public Sale CreateSale(Sale sale)
        {
            _context.Sales.Add(sale);
            _context.SaveChanges();
            return sale;
        }

        public Sale UpdateSale(Sale sale)
        {
            _context.Sales.Update(sale);
            _context.SaveChanges();
            return sale;
        }

        public void DeleteSale(int id)
        {
            var sale = _context.Sales.Find(id);
            if (sale != null)
            {
                _context.Sales.Remove(sale);
                _context.SaveChanges();
            }
        }
    }
}
