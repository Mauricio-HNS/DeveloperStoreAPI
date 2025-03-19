using DeveloperStore.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperStore.API.Repositories.Interfaces
{
    public interface ISaleItemRepository
    {
        Task<IEnumerable<SaleItem>> GetSaleItemsBySaleIdAsync(int saleId);
        Task<SaleItem> AddSaleItemAsync(SaleItem saleItem);
        Task<SaleItem> UpdateSaleItemAsync(SaleItem saleItem);
        Task<bool> DeleteSaleItemAsync(int saleItemId);
    }
}

