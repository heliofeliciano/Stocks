using Stocks.Domain.Entities;

namespace Stocks.Domain.Repositories
{
    public interface IStockRepository
    {
        public void Create(Stock stock);
        public void Update(Stock stock);
    }
}
