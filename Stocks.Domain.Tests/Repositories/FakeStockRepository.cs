using Stocks.Domain.Entities;
using Stocks.Domain.Repositories;

namespace Stocks.Domain.Tests.Repositories
{
    public class FakeStockRepository : IStockRepository
    {
        public void Create(Stock stock)
        {
        }

        public void Update(Stock stock)
        {
        }
    }
}
