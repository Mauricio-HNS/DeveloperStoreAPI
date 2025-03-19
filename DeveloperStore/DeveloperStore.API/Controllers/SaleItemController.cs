using Microsoft.AspNetCore.Mvc;
using DeveloperStore.API.Models;
using DeveloperStore.API.Services;
using System.Collections.Generic;

namespace DeveloperStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleItemController : ControllerBase
    {
        private readonly ISaleItemService _saleItemService;

        public SaleItemController(ISaleItemService saleItemService)
        {
            _saleItemService = saleItemService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<SaleItem>> GetAllSaleItems()
        {
            return Ok(_saleItemService.GetAllSaleItems());
        }

        [HttpGet("{id}")]
        public ActionResult<SaleItem> GetSaleItemById(int id)
        {
            var saleItem = _saleItemService.GetSaleItemById(id);
            if (saleItem == null)
            {
                return NotFound();
            }
            return Ok(saleItem);
        }

        [HttpPost]
        public ActionResult<SaleItem> CreateSaleItem(SaleItem saleItem)
        {
            var createdSaleItem = _saleItemService.CreateSaleItem(saleItem);
            return CreatedAtAction(nameof(GetSaleItemById), new { id = createdSaleItem.SaleItemId }, createdSaleItem);
        }

        [HttpPut("{id}")]
        public ActionResult<SaleItem> UpdateSaleItem(int id, SaleItem saleItem)
        {
            if (id != Convert.ToInt32(saleItem.SaleItemId))
            {
                return BadRequest();
            }

            var updatedSaleItem = _saleItemService.UpdateSaleItem(saleItem);
            return Ok(updatedSaleItem);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteSaleItem(int id)
        {
            _saleItemService.DeleteSaleItem(id);
            return NoContent();
        }
    }
}
