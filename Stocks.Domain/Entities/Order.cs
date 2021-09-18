using Stocks.Domain.Enums;
using Stocks.Domain.Shared.Entities;
using System;

namespace Stocks.Domain.Entities
{
    /*
     * Ação (Stock)
     * Corretora (Broker)
     * Data Movimentação (Date)
     * Tipo da Movimentação (Event)
     * Quantidade (Amount)
     * Valor Unitário (UnitPrice)
     * Valor Financeiro (TotalValue)
     * 
     */
    public abstract class Order : Entity
    {
        protected Order(Broker broker, Stock stock, EEvent eevent, DateTime date, double amount, decimal price, decimal fees)
        {
            Broker = broker;
            Stock = stock;
            EEvent = eevent;
            Date = date;
            Amount = amount;
            Price = price;
            Fees = fees;
        }

        public Broker Broker { get; private set; }
        public Stock Stock { get; private set; }
        public EEvent EEvent { get; private set; }
        public DateTime Date { get; private set; }
        public double Amount { get; private set; }
        public decimal Price { get; private set; }
        public decimal Fees { get; private set; }

    }
}
