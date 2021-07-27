using System;

namespace ClassLibrary.Models
{
    public class Company
    {
        public Guid Id { get; set; }
        public string CompanyName { get; set; }
        public string TradeName { get; set; }
        public string CNPJ { get; set; }
    }
}
