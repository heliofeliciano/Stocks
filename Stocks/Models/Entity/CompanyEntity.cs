using System;

namespace Stocks.Models
{
    public class CompanyEntity : Entity
    {
        public string Name { get; set; }
        public string DocumentNumber { get; set; }
        public CountryEntity Country { get; set; }
        public string toValidDocumentNumber()
        {
            return string.Empty;
        }
    }
}
