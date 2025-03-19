using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperStore.API.ValueObjects
{
    public class SaleItem
    {
        public ProductDetails Product { get; private set; }
        public int Quantity { get; private set; }
        public Money UnitPrice { get; private set; }

        public SaleItem(ProductDetails product, int quantity, Money unitPrice)
        {
            Product = product ?? throw new ArgumentNullException(nameof(product));
            Quantity = quantity;
            UnitPrice = unitPrice ?? throw new ArgumentNullException(nameof(unitPrice));
        }

        public Money TotalPrice()
        {
            return UnitPrice.Multiply(Quantity);
        }
    }
}

