using System;
using System.Collections.Generic;

namespace DeveloperStore.API.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public decimal TotalAmount { get; set; }
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
        public List<SaleItem> SaleItems { get; set; }
        public bool IsCancelled { get; set; }
        public object SaleId { get; internal set; }

        public Sale()
        {
            SaleItems = new List<SaleItem>();
        }
    }
}

