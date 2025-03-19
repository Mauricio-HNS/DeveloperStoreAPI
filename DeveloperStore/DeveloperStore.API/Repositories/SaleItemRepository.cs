using DeveloperStore.API.Models;
using DeveloperStore.API.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DeveloperStore.API.Repositories
{
    public class SaleItemRepository : ISaleItemRepository
    {
        private readonly ApplicationDbContext _context;

        public SaleItemRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<SaleItem> GetAllSaleItems()
        {
            return _context.SaleItems.Include(si => si.Product).ToList();
        }

        public SaleItem GetSaleItemById(int id)
        {
            return _context.SaleItems.Include(si => si.Product).FirstOrDefault(si => si.SaleItemId == id);
        }

        public SaleItem CreateSaleItem(SaleItem saleItem)
        {
            _context.SaleItems.Add(saleItem);
            _context.SaveChanges();
            return saleItem;
        }

        public SaleItem UpdateSaleItem(SaleItem saleItem)
        {
            _context.SaleItems.Update(saleItem);
            _context.SaveChanges();
            return saleItem;
        }

        public void DeleteSaleItem(int id)
        {
            var saleItem = _context.SaleItems.Find(id);
            if (saleItem != null)
            {
                _context.SaleItems.Remove(saleItem);
                _context.SaveChanges();
            }
        }
    }
}

