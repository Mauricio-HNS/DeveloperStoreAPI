using DeveloperStore.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperStore.API.Repositories.Interfaces
{
    public interface ISaleRepository
    {
        Task<Sale> GetSaleByIdAsync(int saleId);
        Task<IEnumerable<Sale>> GetAllSalesAsync();
        Task<Sale> AddSaleAsync(Sale sale);
        Task<Sale> UpdateSaleAsync(Sale sale);
        Task<bool> DeleteSaleAsync(int saleId);
    }
}

