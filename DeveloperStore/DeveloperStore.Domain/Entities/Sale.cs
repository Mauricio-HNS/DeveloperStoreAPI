using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperStore.API.Entities
{
    public class Sale
    {
        public int SaleId { get; set; }
        public DateTime SaleDate { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
        public decimal TotalAmount { get; set; }
        public bool IsCancelled { get; set; }
        public ICollection<SaleItem> SaleItems { get; set; }
        public object? Id { get; set; }

        public Sale()
        {
            SaleItems = new List<SaleItem>();
        }
    }
}

