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
            throw new NotImplementedException();
        }

        public IEnumerable<StockMarket> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StockMarket> GetAllActive()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StockMarket> GetAllInactive()
        {
            throw new NotImplementedException();
        }

        public StockMarket GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(StockMarket stockMarket)
        {
            throw new NotImplementedException();
        }
    }
}
