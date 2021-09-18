using Stocks.Domain.Enums;
using Stocks.Domain.Shared.Entities;
using Stocks.Domain.ValueObjects;

namespace Stocks.Domain.Entities
{
    public class StockMarket : Entity
    {
        public StockMarket(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}
