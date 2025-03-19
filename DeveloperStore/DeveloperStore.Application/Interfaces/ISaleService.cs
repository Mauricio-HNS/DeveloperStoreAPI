using DeveloperStore.API.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperStore.API.Services.Interfaces
{
    public interface ISaleService
    {
        Task<SaleDTO> GetSaleByIdAsync(int saleId);
        Task<IEnumerable<SaleDTO>> GetAllSalesAsync();
        Task<SaleDTO> CreateSaleAsync(SaleDTO saleDto);
        Task<SaleDTO> UpdateSaleAsync(int saleId, SaleDTO saleDto);
        Task<bool> DeleteSaleAsync(int saleId);
        Task<IEnumerable<SaleDTO>> GetSalesByCustomerIdAsync(int customerId);
    }
}

