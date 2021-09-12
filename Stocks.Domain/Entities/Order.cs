using Stocks.Domain.Shared.Entities;
using System;

namespace Stocks.Domain.Entities
{
    public abstract class Order : Entity
    {
        protected Order(Stock stock, DateTime date, double amount, decimal price, decimal fees)
        {
            Stock = stock;
            Date = date;
            Amount = amount;
            Price = price;
            Fees = fees;
        }

        public Stock Stock { get; private set; }
        public DateTime Date { get; private set; }
        public double Amount { get; private set; }
        public decimal Price { get; private set; }
        public decimal Fees { get; private set; }
    }
}
