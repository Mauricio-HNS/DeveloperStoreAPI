using DeveloperStore.API.Models;
using System.Collections.Generic;

namespace DeveloperStore.API.Services
{
    public interface ISaleService
    {
        IEnumerable<Sale> GetAllSales();
        Sale GetSaleById(int id);
        Sale CreateSale(Sale sale);
        Sale UpdateSale(Sale sale);
        void DeleteSale(int id);
    }
}
