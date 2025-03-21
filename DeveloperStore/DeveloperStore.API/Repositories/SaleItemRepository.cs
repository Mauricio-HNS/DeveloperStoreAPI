using DeveloperStore.API.Entities;
using DeveloperStore.API.Data;
using Microsoft.EntityFrameworkCore;  // Verifique se esta linha está presente
using System.Collections.Generic;
using System.Linq;

namespace DeveloperStore.API.Repositories
{
    public class SaleItemRepository : ISaleItemRepository
    {
        private readonly DeveloperStoreDbContext _context;

        public SaleItemRepository(DeveloperStoreDbContext context)
        {
            _context = context;
        }

        public IEnumerable<SaleItem> GetAllSaleItems()
        {
            return _context.SaleItems.Include(si => si.Product).ToList(); // Inclui o produto associado
        }

        public SaleItem GetSaleItemById(int id)
        {
            return _context.SaleItems.Include(si => si.Product).FirstOrDefault(si => si.Id == id); // Alterado para 'Id'
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

        IEnumerable<Models.SaleItem> ISaleItemRepository.GetAllSaleItems()
        {
            throw new NotImplementedException();
        }

        Models.SaleItem ISaleItemRepository.GetSaleItemById(int id)
        {
            throw new NotImplementedException();
        }

        public Models.SaleItem CreateSaleItem(Models.SaleItem saleItem)
        {
            throw new NotImplementedException();
        }

        public Models.SaleItem UpdateSaleItem(Models.SaleItem saleItem)
        {
            throw new NotImplementedException();
        }
    }
}
