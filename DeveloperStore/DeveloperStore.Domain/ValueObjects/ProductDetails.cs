using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperStore.API.ValueObjects
{
    public class ProductDetails
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string SKU { get; private set; }

        public ProductDetails(string name, string description, string sku)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            SKU = sku ?? throw new ArgumentNullException(nameof(sku));
        }

        public override string ToString()
        {
            return $"{Name} ({SKU}): {Description}";
        }
    }
}

