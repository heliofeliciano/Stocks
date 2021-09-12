using Stocks.Shared.ValueObjects;

namespace Stocks.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string nameCompany)
        {
            NameCompany = nameCompany;
        }

        public string NameCompany { get; private set; }
    }
}
