using System;

namespace DeveloperStore.API.Models
{
    public class SaleItem
    {
        public int Id { get; set; }
        public int SaleId { get; set; }
        public Sale Sale { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Discount { get; set; }
        public object SaleItemId { get; internal set; }

        public SaleItem()
        {
            TotalAmount = UnitPrice * Quantity - Discount;
        }
    }
}

