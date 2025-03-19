using DeveloperStore.API.Models;
using DeveloperStore.API.Repositories;
using System.Collections.Generic;

namespace DeveloperStore.API.Services
{
    public class SaleItemService : ISaleItemService
    {
        private readonly ISaleItemRepository _saleItemRepository;

        public SaleItemService(ISaleItemRepository saleItemRepository)
        {
            _saleItemRepository = saleItemRepository;
        }

        public IEnumerable<SaleItem> GetAllSaleItems()
        {
            return _saleItemRepository.GetAllSaleItems();
        }

        public SaleItem GetSaleItemById(int id)
        {
            return _saleItemRepository.GetSaleItemById(id);
        }

        public SaleItem CreateSaleItem(SaleItem saleItem)
        {
            return _saleItemRepository.CreateSaleItem(saleItem);
        }

        public SaleItem UpdateSaleItem(SaleItem saleItem)
        {
            return _saleItemRepository.UpdateSaleItem(saleItem);
        }

        public void DeleteSaleItem(int id)
        {
            _saleItemRepository.DeleteSaleItem(id);
        }
    }
}

