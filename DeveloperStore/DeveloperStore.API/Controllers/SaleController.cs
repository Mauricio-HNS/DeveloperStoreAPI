using Microsoft.AspNetCore.Mvc;
using DeveloperStore.API.Models;
using DeveloperStore.API.Services;
using System.Collections.Generic;

namespace DeveloperStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleController : ControllerBase
    {
        private readonly ISaleService _saleService;

        public SaleController(ISaleService saleService)
        {
            _saleService = saleService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Sale>> GetAllSales()
        {
            return Ok(_saleService.GetAllSales());
        }

        [HttpGet("{id}")]
        public ActionResult<Sale> GetSaleById(int id)
        {
            var sale = _saleService.GetSaleById(id);
            if (sale == null)
            {
                return NotFound();
            }
            return Ok(sale);
        }

        [HttpPost]
        public ActionResult<Sale> CreateSale(Sale sale)
        {
            var createdSale = _saleService.CreateSale(sale);
            return CreatedAtAction(nameof(GetSaleById), new { id = createdSale.SaleId }, createdSale);
        }

        [HttpPut("{id}")]
        public ActionResult<Sale> UpdateSale(int id, Sale sale)
        {
            if (id != Convert.ToInt32(sale.SaleId))
            {
                return BadRequest();
            }

            var updatedSale = _saleService.UpdateSale(sale);
            return Ok(updatedSale);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteSale(int id)
        {
            _saleService.DeleteSale(id);
            return NoContent();
        }
    }
}
