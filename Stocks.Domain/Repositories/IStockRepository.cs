using Stocks.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Stocks.Domain.Repositories
{
    public interface IStockRepository
    {
        public void Create(Stock stock);
        public void Update(Stock stock);
        public Stock GetById(Guid id);
        IEnumerable<Stock> GetAll();
        IEnumerable<Stock> GetAllActive();
        IEnumerable<Stock> GetAllInactive();
    }
}
