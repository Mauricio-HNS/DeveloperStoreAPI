using System;

namespace DeveloperStore.API.ValueObjects
{
    public class Money
    {
        public decimal Amount { get; private set; }
        public string Currency { get; private set; }

        public Money(decimal amount, string currency)
        {
            if (amount < 0)
                throw new ArgumentException("Amount cannot be negative.");

            Amount = amount;
            Currency = currency ?? throw new ArgumentNullException(nameof(currency));
        }

        public Money Add(Money money)
        {
            if (money.Currency != Currency)
                throw new ArgumentException("Cannot add money with different currencies.");

            return new Money(Amount + money.Amount, Currency);
        }

        public Money Subtract(Money money)
        {
            if (money.Currency != Currency)
                throw new ArgumentException("Cannot subtract money with different currencies.");

            if (Amount < money.Amount)
                throw new InvalidOperationException("Insufficient funds.");

            return new Money(Amount - money.Amount, Currency);
        }

        // Método Multiply
        public Money Multiply(decimal multiplier)
        {
            if (multiplier < 0)
                throw new ArgumentException("Multiplier cannot be negative.");

            return new Money(Amount * multiplier, Currency);
        }

        // Sobrecarga do operador *
        public static Money operator *(Money money, decimal multiplier)
        {
            if (multiplier < 0)
                throw new ArgumentException("Multiplier cannot be negative.");

            return new Money(money.Amount * multiplier, money.Currency);
        }

        public override string ToString()
        {
            return $"{Currency} {Amount:F2}";
        }
    }
}
