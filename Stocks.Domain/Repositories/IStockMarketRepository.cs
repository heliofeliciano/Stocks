using Stocks.Domain.Entities;

namespace Stocks.Domain.Repositories
{
    public interface IStockMarketRepository
    {
        public void Create(StockMarket stockMarket);
        public void Update(StockMarket stockMarket);
    }
}
