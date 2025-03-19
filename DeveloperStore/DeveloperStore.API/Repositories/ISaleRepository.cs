using DeveloperStore.API.Models;
using System.Collections.Generic;

namespace DeveloperStore.API.Repositories
{
    public interface ISaleRepository
    {
        IEnumerable<Sale> GetAllSales();
        Sale GetSaleById(int id);
        Sale CreateSale(Sale sale);
        Sale UpdateSale(Sale sale);
        void DeleteSale(int id);
    }
}

