using Stocks.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Stocks.Domain.Repositories
{
    public interface IStockMarketRepository
    {
        public void Create(StockMarket stockMarket);
        public void Update(StockMarket stockMarket);
        public StockMarket GetById(Guid id);
        IEnumerable<StockMarket> GetAll();
        IEnumerable<StockMarket> GetAllActive();
        IEnumerable<StockMarket> GetAllInactive();
    }
}
