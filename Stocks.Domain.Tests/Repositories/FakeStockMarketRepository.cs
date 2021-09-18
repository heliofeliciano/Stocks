using Stocks.Domain.Entities;
using Stocks.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stocks.Domain.Tests.Repositories
{
    public class FakeStockMarketRepository : IStockMarketRepository
    {
        public void Create(StockMarket stockMarket)
        {
        }

        public void Update(StockMarket stockMarket)
        {
        }
    }
}
