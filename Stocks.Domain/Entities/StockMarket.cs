using Stocks.Domain.Shared.Entities;
using Stocks.Domain.ValueObjects;

namespace Stocks.Domain.Entities
{
    public class StockMarket : Entity
    {
        public StockMarket(Name name, Country originiCountry)
        {
            Name = name;
            OriginiCountry = originiCountry;
        }

        public Name Name { get; private set; }
        public Country OriginiCountry { get; private set; }
    }
}
