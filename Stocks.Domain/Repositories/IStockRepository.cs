using Stocks.Domain.Entities;
using System;

namespace Stocks.Domain.Repositories
{
    public interface IStockRepository
    {
        public void Create(Stock stock);
        public void Update(Stock stock);
        public Stock GetById(Guid id);
    }
}
