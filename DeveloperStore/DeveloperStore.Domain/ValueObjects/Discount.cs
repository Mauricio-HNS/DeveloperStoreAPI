using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperStore.API.ValueObjects
{
    public class Discount
    {
        public decimal Percentage { get; private set; }
        public Money FixedAmount { get; private set; }

        public Discount(decimal percentage)
        {
            if (percentage < 0 || percentage > 100)
                throw new ArgumentException("Percentage must be between 0 and 100.");

            Percentage = percentage;
            FixedAmount = null;
        }

        public Discount(Money fixedAmount)
        {
            FixedAmount = fixedAmount ?? throw new ArgumentNullException(nameof(fixedAmount));
            Percentage = 0;
        }

        public Money Apply(Money amount)
        {
            if (Percentage > 0)
            {
                decimal discountAmount = (Percentage / 100) * amount.Amount;
                return new Money(amount.Amount - discountAmount, amount.Currency);
            }

            if (FixedAmount != null)
            {
                return amount.Subtract(FixedAmount);
            }

            return amount;
        }
    }
}

