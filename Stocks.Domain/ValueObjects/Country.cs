using Stocks.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stocks.Domain.ValueObjects
{
    public class Country : ValueObject
    {
        public Country(string name, string initials)
        {
            Name = name;
            Initials = initials;
        }

        public string Name { get; private set; }
        public string Initials { get; private set; }
    }
}
