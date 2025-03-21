using System;

namespace DeveloperStore.API.Models
{
    public class SaleItem
    {
        public int Id { get; set; }
        public int SaleId { get; set; }
        public Sale Sale { get; set; }  // Certifique-se de que há uma relação com Sale
        public int ProductId { get; set; }
        public Product Product { get; set; }  // Certifique-se de que há uma relação com Product
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Discount { get; set; }
        public bool SaleItemId { get; internal set; }

        public SaleItem()
        {
            TotalAmount = UnitPrice * Quantity - Discount;
        }
    }
}
