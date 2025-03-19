using DeveloperStore.API.Models;
using System.Collections.Generic;

namespace DeveloperStore.API.Repositories
{
    public interface ISaleItemRepository
    {
        IEnumerable<SaleItem> GetAllSaleItems();
        SaleItem GetSaleItemById(int id);
        SaleItem CreateSaleItem(SaleItem saleItem);
        SaleItem UpdateSaleItem(SaleItem saleItem);
        void DeleteSaleItem(int id);
    }
}
