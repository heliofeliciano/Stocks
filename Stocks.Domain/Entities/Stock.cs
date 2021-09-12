using Stocks.Domain.Shared.Entities;

namespace Stocks.Domain.Entities
{
    public abstract class Stock : Entity
    {
        public Stock(Company company, string ticker, StockMarket stockMarket)
        {
            Company = company;
            StockMarket = stockMarket;
            Ticker = ticker;
        }

        public Company Company { get; private set; }
        public string Ticker { get; private set; }
        public StockMarket StockMarket { get; private set; }
    }
}
