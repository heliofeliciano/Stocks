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
            Active = true;
        }

        public string Name { get; private set; }
        public Document Document { get; private set; }
        public bool Active { get; private set; }

        public void TurnActive()
        {
            Active = true;
        }
        
        public void TurnInactive()
        {
            Active = false;
        }
    }
}
