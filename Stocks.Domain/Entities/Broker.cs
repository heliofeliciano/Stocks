using Stocks.Domain.Shared.Entities;

namespace Stocks.Domain.Entities
{
    public class Broker : Entity
    {
        public Broker(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}
