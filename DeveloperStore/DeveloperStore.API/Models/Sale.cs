using DeveloperStore.Domain.Entities;
using System;
using System.Collections.Generic;

namespace DeveloperStore.API.Models
{
    public class Sale
    {
        public int Id { get; set; }  // Primary key for Sale
        public DateTime Date { get; set; }
        public int CustomerId { get; set; }  // Foreign key for Customer
        public Customer Customer { get; set; }  // Navigation property for Customer
        public decimal TotalAmount { get; set; }
        public int BranchId { get; set; }  // Foreign key for Branch
        public Branch Branch { get; set; }  // Navigation property for Branch
        public List<SaleItem> SaleItems { get; set; }  // Sale's items
        public bool IsCancelled { get; set; }  // Flag to indicate if the sale is cancelled

        public Sale()
        {
            SaleItems = new List<SaleItem>();  // Initializing SaleItems list
        }
    }
}
