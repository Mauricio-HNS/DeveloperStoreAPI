using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperStore.API.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public ICollection<SaleItem> SaleItems { get; set; }

        public Product()
        {
            SaleItems = new List<SaleItem>();
        }
    }
}

