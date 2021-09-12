using Stocks.Domain.ValueObjects;
using Stocks.Domain.Shared.Entities;

namespace Stocks.Domain.Entities
{
    public class Company : Entity
    {
        public Company(string name, Document document)
        {
            Name = name;
            Document = document;
        }

        public string Name { get; private set; }
        public Document Document { get; private set; }
    }
}
