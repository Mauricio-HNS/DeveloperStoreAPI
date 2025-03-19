using DeveloperStore.API.Models;
using DeveloperStore.API.Repositories;
using System.Collections.Generic;

namespace DeveloperStore.API.Services
{
    public class SaleService : ISaleService
    {
        private readonly ISaleRepository _saleRepository;

        public SaleService(ISaleRepository saleRepository)
        {
            _saleRepository = saleRepository;
        }

        public IEnumerable<Sale> GetAllSales()
        {
            return _saleRepository.GetAllSales();
        }

        public Sale GetSaleById(int id)
        {
            return _saleRepository.GetSaleById(id);
        }

        public Sale CreateSale(Sale sale)
        {
            return _saleRepository.CreateSale(sale);
        }

        public Sale UpdateSale(Sale sale)
        {
            return _saleRepository.UpdateSale(sale);
        }

        public void DeleteSale(int id)
        {
            _saleRepository.DeleteSale(id);
        }
    }
}
