using System;

namespace ClassLibrary.Models
{
    public class Company
    {
        public Company()
        {
        }

        public Company(Guid id, string companyName, string tradeName, string cNPJ)
        {
            Id = id;
            CompanyName = companyName;
            TradeName = tradeName;
            CNPJ = cNPJ;
        }

        public Guid Id { get; set; }
        public string CompanyName { get; set; }
        public string TradeName { get; set; }
        public string CNPJ { get; set; }
    }
}
