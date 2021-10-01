using Stocks.Domain.Shared.Entities;
using System;

namespace Stocks.Domain.Entities
{
    public class Stock : Entity
    {
        public Stock()
        {
        }

        public Stock(Guid companyId, string ticker, Guid stockMarketId)
        {
            CompanyId = companyId;
            Ticker = ticker;
            StockMarketId = stockMarketId;
            Active = true;
        }

        //public Stock(Company company, string ticker, StockMarket stockMarket)
        //{
        //    Company = company;
        //    Ticker = ticker;
        //    StockMarket = stockMarket;
        //    Active = true;
        //}

        public Guid CompanyId { get; private set; }
        public Company Company { get; private set; }
        public string Ticker { get; private set; }
        public Guid StockMarketId { get; private set; }
        public StockMarket StockMarket { get; private set; }
        public bool Active { get; private set; }
        public void UpdateTicker(string ticker)
        {
            Ticker = ticker;
        }

        public void InactivateStock()
        {
            Active = false;
        }
        
        public void ActivateStock()
        {
            Active = true;
        }
    }
}
